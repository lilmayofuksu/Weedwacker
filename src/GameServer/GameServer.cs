﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Authentication;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils.Configuration;

namespace Weedwacker.GameServer
{
    internal static class GameServer
    {
        private static readonly HttpClient client = new HttpClient();

        public static GameConfig Configuration;
        public static SortedList<int,Connection> OnlinePlayers = new(); // <gameUid,connection>
        private static HashSet<World> Worlds = new();
        public static SortedList<int, AvatarCompiledData> AvatarInfo = new(); // <avatarId,data>
        public static async Task<bool> VerifyToken(string accountUid, string token)
        {
            var req = JsonConvert.SerializeObject(new VerifyTokenRequestJson() { uid = accountUid, token = token });
            var contentData = new StringContent(req, Encoding.UTF8, "application/json");
            var rsp = await client.PostAsync(Configuration.Server.WebServerUrl + "/hk4e_global/mdk/shield/api/verify", contentData);
            var result = JsonConvert.DeserializeObject<LoginResultJson>(await rsp.Content.ReadAsStringAsync());
            if(result.message == "OK")
            {
                return true;
            }
            return false;
        }

        internal static void RegisterWorld(World world)
        {
            Worlds.Add(world);
        }

        public static AvatarCompiledData? GetAvatarInfo(int avatarId)
        {
            if (AvatarInfo.TryGetValue(avatarId, out AvatarCompiledData? avatarInfo))
            {
                return avatarInfo;
            }
            else return null;
            
        }

        public static async Task Start()
        {
            Configuration = await Config.Load<GameConfig>("GameConfig.json");
            await GameData.LoadAllResourcesAsync(Configuration.structure.Resources);
            Shared.Utils.Crypto.LoadKeys(Configuration.structure.keys);
            await Database.DatabaseManager.Initialize();

            foreach (int id in GameData.AvatarDataMap.Keys)
            {
                AvatarInfo.Add(id, new AvatarCompiledData(id));
            }

            Listener.StartListener();
        }

        public static int GetShopNextRefreshTime(int shopType)
        {
            //TODO
            return int.MaxValue;
        }

        internal static async Task<SocialDetail?> GetSocialDetailByUid(int askerUid, uint reqUid)
        {
            SocialDetail socialDetail;
            if (OnlinePlayers.TryGetValue((int)reqUid, out Connection session))
            {
                return session.Player.SocialManager.GetSocialDetail(askerUid);            
            }
            else
            {
                var player = await Database.DatabaseManager.GetPlayerByGameUidAsync((int)reqUid);
                if (player != null)
                    return player.SocialManager.GetSocialDetail(askerUid);
                else
                    return null;
            }
        }

    }
}
