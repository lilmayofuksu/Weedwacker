// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EnterReason.proto</summary>
  public static partial class EnterReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFFbnRlclJlYXNvbi5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90byr4DgoLRW50ZXJSZWFzb24SFQoRRU5URVJfUkVBU09OX05PTkUQ",
            "ABIWChJFTlRFUl9SRUFTT05fTE9HSU4QARIfChtFTlRFUl9SRUFTT05fRFVO",
            "R0VPTl9SRVBMQVkQCxIrCidFTlRFUl9SRUFTT05fRFVOR0VPTl9SRVZJVkVf",
            "T05fV0FZUE9JTlQQDBIeChpFTlRFUl9SRUFTT05fRFVOR0VPTl9FTlRFUhAN",
            "Eh0KGUVOVEVSX1JFQVNPTl9EVU5HRU9OX1FVSVQQDhITCg9FTlRFUl9SRUFT",
            "T05fR00QFRIfChtFTlRFUl9SRUFTT05fUVVFU1RfUk9MTEJBQ0sQHxIYChRF",
            "TlRFUl9SRUFTT05fUkVWSVZBTBAgEh8KG0VOVEVSX1JFQVNPTl9QRVJTT05B",
            "TF9TQ0VORRApEhwKGEVOVEVSX1JFQVNPTl9UUkFOU19QT0lOVBAqEiAKHEVO",
            "VEVSX1JFQVNPTl9DTElFTlRfVFJBTlNNSVQQKxIgChxFTlRFUl9SRUFTT05f",
            "Rk9SQ0VfRFJBR19CQUNLECwSGgoWRU5URVJfUkVBU09OX1RFQU1fS0lDSxAz",
            "EhoKFkVOVEVSX1JFQVNPTl9URUFNX0pPSU4QNBIaChZFTlRFUl9SRUFTT05f",
            "VEVBTV9CQUNLEDUSFQoRRU5URVJfUkVBU09OX01VSVAQNhImCiJFTlRFUl9S",
            "RUFTT05fRFVOR0VPTl9JTlZJVEVfQUNDRVBUEDcSFAoQRU5URVJfUkVBU09O",
            "X0xVQRA4EiYKIkVOVEVSX1JFQVNPTl9BQ1RJVklUWV9MT0FEX1RFUlJBSU4Q",
            "ORInCiNFTlRFUl9SRUFTT05fSE9TVF9GUk9NX1NJTkdMRV9UT19NUBA6EhgK",
            "FEVOVEVSX1JFQVNPTl9NUF9QTEFZEDsSHQoZRU5URVJfUkVBU09OX0FOQ0hP",
            "Ul9QT0lOVBA8EhwKGEVOVEVSX1JFQVNPTl9MVUFfU0tJUF9VSRA9Eh8KG0VO",
            "VEVSX1JFQVNPTl9SRUxPQURfVEVSUkFJThA+Eh8KG0VOVEVSX1JFQVNPTl9E",
            "UkFGVF9UUkFOU0ZFUhA/EhsKF0VOVEVSX1JFQVNPTl9FTlRFUl9IT01FEEAS",
            "GgoWRU5URVJfUkVBU09OX0VYSVRfSE9NRRBBEiMKH0VOVEVSX1JFQVNPTl9D",
            "SEFOR0VfSE9NRV9NT0RVTEUQQhIYChRFTlRFUl9SRUFTT05fR0FMTEVSWRBD",
            "EiAKHEVOVEVSX1JFQVNPTl9IT01FX1NDRU5FX0pVTVAQRBIeChpFTlRFUl9S",
            "RUFTT05fSElERV9BTkRfU0VFSxBFEiYKIkVOVEVSX1JFQVNPTl9TVU1NRVJf",
            "VElNRV9NSVNUX1pPTkUQRhIhCh1FTlRFUl9SRUFTT05fRk9SQ0VfUVVJVF9T",
            "Q0VORRBHEhwKGEVOVEVSX1JFQVNPTl9IRVJPX0NPVVJTRRBIEh4KGkVOVEVS",
            "X1JFQVNPTl9UUkFOU19DTElNQVRFEEkSKQolRU5URVJfUkVBU09OX1NVTU1F",
            "Ul9USU1FX0JPQVRfUkVTVEFSVBBKEiUKIUVOVEVSX1JFQVNPTl9UU1VSVU1J",
            "X01JU1RfQ0xJTUFURRBLEi4KKkVOVEVSX1JFQVNPTl9UU1VSVU1JX1JFR0lP",
            "TkFMX01JU1RfQ0xJTUFURRBMEiQKIEVOVEVSX1JFQVNPTl9XSU5URVJfQ0FN",
            "UF9SRVNUQVJUEE0SIwofRU5URVJfUkVBU09OX1RBTEtfRVhFQ19UUkFOU0ZF",
            "UhBOEiUKIUVOVEVSX1JFQVNPTl9TRUFMQU1QX0JPQVRfUkVTVEFSVBBPEiIK",
            "HkVOVEVSX1JFQVNPTl9TRUFMQU1QX0JPQVRfQkFDSxBQEikKJUVOVEVSX1JF",
            "QVNPTl9DSEFMTEVOR0VfSU5URVJSVVBUX0JBQ0sQURIoCiRFTlRFUl9SRUFT",
            "T05fSVJPRE9SSV9NQVNURVJfVFJBTlNGRVIQUhIdChlFTlRFUl9SRUFTT05f",
            "R0FMTEVSWV9CQUNLEFMSLAooRU5URVJfUkVBU09OX1NVTU1FUl9USU1FX1Yy",
            "X0JPQVRfUkVTVEFSVBBUEjIKLkVOVEVSX1JFQVNPTl9JU0xBTkRfUEFSVFlf",
            "R0FMTEVSWV9TVEFSVF9GQUlMRUQQVRIuCipFTlRFUl9SRUFTT05fR1JBVkVO",
            "X0lOTk9DRU5DRV9SQUNFX1JFU1RBUlQQVhIpCiVFTlRFUl9SRUFTT05fVklO",
            "VEFHRV9IVU5USU5HX1RSQU5TRkVSEFcSKAokRU5URVJfUkVBU09OX0ZVTkdV",
            "U19GSUdIVEVSX1RSQU5TRkVSEFgSHgoaRU5URVJfUkVBU09OX0JSSUNLX0JS",
            "RUFLRVIQWRIlCiFFTlRFUl9SRUFTT05fQlJJQ0tfQlJFQUtFUl9TSU5HTEUQ",
            "WhIkCiBFTlRFUl9SRUFTT05fVFJBTlNGRVJfR1VBUkRfU1RPUBBbEiQKIEVO",
            "VEVSX1JFQVNPTl9DT0lOX0NPTExFQ1RfU0lOR0xFEFxiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.EnterReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum EnterReason {
    [pbr::OriginalName("ENTER_REASON_NONE")] None = 0,
    [pbr::OriginalName("ENTER_REASON_LOGIN")] Login = 1,
    [pbr::OriginalName("ENTER_REASON_DUNGEON_REPLAY")] DungeonReplay = 11,
    [pbr::OriginalName("ENTER_REASON_DUNGEON_REVIVE_ON_WAYPOINT")] DungeonReviveOnWaypoint = 12,
    [pbr::OriginalName("ENTER_REASON_DUNGEON_ENTER")] DungeonEnter = 13,
    [pbr::OriginalName("ENTER_REASON_DUNGEON_QUIT")] DungeonQuit = 14,
    [pbr::OriginalName("ENTER_REASON_GM")] Gm = 21,
    [pbr::OriginalName("ENTER_REASON_QUEST_ROLLBACK")] QuestRollback = 31,
    [pbr::OriginalName("ENTER_REASON_REVIVAL")] Revival = 32,
    [pbr::OriginalName("ENTER_REASON_PERSONAL_SCENE")] PersonalScene = 41,
    [pbr::OriginalName("ENTER_REASON_TRANS_POINT")] TransPoint = 42,
    [pbr::OriginalName("ENTER_REASON_CLIENT_TRANSMIT")] ClientTransmit = 43,
    [pbr::OriginalName("ENTER_REASON_FORCE_DRAG_BACK")] ForceDragBack = 44,
    [pbr::OriginalName("ENTER_REASON_TEAM_KICK")] TeamKick = 51,
    [pbr::OriginalName("ENTER_REASON_TEAM_JOIN")] TeamJoin = 52,
    [pbr::OriginalName("ENTER_REASON_TEAM_BACK")] TeamBack = 53,
    [pbr::OriginalName("ENTER_REASON_MUIP")] Muip = 54,
    [pbr::OriginalName("ENTER_REASON_DUNGEON_INVITE_ACCEPT")] DungeonInviteAccept = 55,
    [pbr::OriginalName("ENTER_REASON_LUA")] Lua = 56,
    [pbr::OriginalName("ENTER_REASON_ACTIVITY_LOAD_TERRAIN")] ActivityLoadTerrain = 57,
    [pbr::OriginalName("ENTER_REASON_HOST_FROM_SINGLE_TO_MP")] HostFromSingleToMp = 58,
    [pbr::OriginalName("ENTER_REASON_MP_PLAY")] MpPlay = 59,
    [pbr::OriginalName("ENTER_REASON_ANCHOR_POINT")] AnchorPoint = 60,
    [pbr::OriginalName("ENTER_REASON_LUA_SKIP_UI")] LuaSkipUi = 61,
    [pbr::OriginalName("ENTER_REASON_RELOAD_TERRAIN")] ReloadTerrain = 62,
    [pbr::OriginalName("ENTER_REASON_DRAFT_TRANSFER")] DraftTransfer = 63,
    [pbr::OriginalName("ENTER_REASON_ENTER_HOME")] EnterHome = 64,
    [pbr::OriginalName("ENTER_REASON_EXIT_HOME")] ExitHome = 65,
    [pbr::OriginalName("ENTER_REASON_CHANGE_HOME_MODULE")] ChangeHomeModule = 66,
    [pbr::OriginalName("ENTER_REASON_GALLERY")] Gallery = 67,
    [pbr::OriginalName("ENTER_REASON_HOME_SCENE_JUMP")] HomeSceneJump = 68,
    [pbr::OriginalName("ENTER_REASON_HIDE_AND_SEEK")] HideAndSeek = 69,
    [pbr::OriginalName("ENTER_REASON_SUMMER_TIME_MIST_ZONE")] SummerTimeMistZone = 70,
    [pbr::OriginalName("ENTER_REASON_FORCE_QUIT_SCENE")] ForceQuitScene = 71,
    [pbr::OriginalName("ENTER_REASON_HERO_COURSE")] HeroCourse = 72,
    [pbr::OriginalName("ENTER_REASON_TRANS_CLIMATE")] TransClimate = 73,
    [pbr::OriginalName("ENTER_REASON_SUMMER_TIME_BOAT_RESTART")] SummerTimeBoatRestart = 74,
    [pbr::OriginalName("ENTER_REASON_TSURUMI_MIST_CLIMATE")] TsurumiMistClimate = 75,
    [pbr::OriginalName("ENTER_REASON_TSURUMI_REGIONAL_MIST_CLIMATE")] TsurumiRegionalMistClimate = 76,
    [pbr::OriginalName("ENTER_REASON_WINTER_CAMP_RESTART")] WinterCampRestart = 77,
    [pbr::OriginalName("ENTER_REASON_TALK_EXEC_TRANSFER")] TalkExecTransfer = 78,
    [pbr::OriginalName("ENTER_REASON_SEALAMP_BOAT_RESTART")] SealampBoatRestart = 79,
    [pbr::OriginalName("ENTER_REASON_SEALAMP_BOAT_BACK")] SealampBoatBack = 80,
    [pbr::OriginalName("ENTER_REASON_CHALLENGE_INTERRUPT_BACK")] ChallengeInterruptBack = 81,
    [pbr::OriginalName("ENTER_REASON_IRODORI_MASTER_TRANSFER")] IrodoriMasterTransfer = 82,
    [pbr::OriginalName("ENTER_REASON_GALLERY_BACK")] GalleryBack = 83,
    [pbr::OriginalName("ENTER_REASON_SUMMER_TIME_V2_BOAT_RESTART")] SummerTimeV2BoatRestart = 84,
    [pbr::OriginalName("ENTER_REASON_ISLAND_PARTY_GALLERY_START_FAILED")] IslandPartyGalleryStartFailed = 85,
    [pbr::OriginalName("ENTER_REASON_GRAVEN_INNOCENCE_RACE_RESTART")] GravenInnocenceRaceRestart = 86,
    [pbr::OriginalName("ENTER_REASON_VINTAGE_HUNTING_TRANSFER")] VintageHuntingTransfer = 87,
    [pbr::OriginalName("ENTER_REASON_FUNGUS_FIGHTER_TRANSFER")] FungusFighterTransfer = 88,
    [pbr::OriginalName("ENTER_REASON_BRICK_BREAKER")] BrickBreaker = 89,
    [pbr::OriginalName("ENTER_REASON_BRICK_BREAKER_SINGLE")] BrickBreakerSingle = 90,
    [pbr::OriginalName("ENTER_REASON_TRANSFER_GUARD_STOP")] TransferGuardStop = 91,
    [pbr::OriginalName("ENTER_REASON_COIN_COLLECT_SINGLE")] CoinCollectSingle = 92,
  }

  #endregion

}

#endregion Designer generated code
