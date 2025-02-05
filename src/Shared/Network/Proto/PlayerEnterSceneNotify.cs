// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerEnterSceneNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlayerEnterSceneNotify.proto</summary>
  public static partial class PlayerEnterSceneNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerEnterSceneNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerEnterSceneNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxQbGF5ZXJFbnRlclNjZW5lTm90aWZ5LnByb3RvEh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvGg9FbnRlclR5cGUucHJvdG8aDFZlY3Rvci5w",
            "cm90byKCBAoWUGxheWVyRW50ZXJTY2VuZU5vdGlmeRITCgp3b3JsZF90eXBl",
            "GMgJIAEoDRIiChppc19maXJzdF9sb2dpbl9lbnRlcl9zY2VuZRggIAEoCBIT",
            "Cgt3b3JsZF9sZXZlbBgEIAEoDRI0CgNwb3MYASABKAsyJy5XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvLlZlY3RvchIbChNVbmszMzAwX09LTU5P",
            "Rk9IS09CGAMgASgIEhUKDXByZXZfc2NlbmVfaWQYDSABKA0SGQoRZW50ZXJf",
            "c2NlbmVfdG9rZW4YBiABKA0SEgoKZHVuZ2Vvbl9pZBgCIAEoDRIQCghzY2Vu",
            "ZV9pZBgLIAEoDRI4CgR0eXBlGAwgASgOMiouV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90by5FbnRlclR5cGUSGQoRc2NlbmVfdGFnX2lkX2xpc3QY",
            "BSADKA0SGAoQc2NlbmVfYmVnaW5fdGltZRgJIAEoBBIVCgxlbnRlcl9yZWFz",
            "b24YnwIgASgNEhIKCnRhcmdldF91aWQYCCABKA0SOQoIcHJldl9wb3MYCiAB",
            "KAsyJy5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLlZlY3RvchIa",
            "ChFzY2VuZV90cmFuc2FjdGlvbhjyAiABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.EnterTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PlayerEnterSceneNotify), global::Weedwacker.Shared.Network.Proto.PlayerEnterSceneNotify.Parser, new[]{ "WorldType", "IsFirstLoginEnterScene", "WorldLevel", "Pos", "Unk3300OKMNOFOHKOB", "PrevSceneId", "EnterSceneToken", "DungeonId", "SceneId", "Type", "SceneTagIdList", "SceneBeginTime", "EnterReason", "TargetUid", "PrevPos", "SceneTransaction" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 279;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class PlayerEnterSceneNotify : pb::IMessage<PlayerEnterSceneNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerEnterSceneNotify> _parser = new pb::MessageParser<PlayerEnterSceneNotify>(() => new PlayerEnterSceneNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerEnterSceneNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PlayerEnterSceneNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterSceneNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterSceneNotify(PlayerEnterSceneNotify other) : this() {
      worldType_ = other.worldType_;
      isFirstLoginEnterScene_ = other.isFirstLoginEnterScene_;
      worldLevel_ = other.worldLevel_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      unk3300OKMNOFOHKOB_ = other.unk3300OKMNOFOHKOB_;
      prevSceneId_ = other.prevSceneId_;
      enterSceneToken_ = other.enterSceneToken_;
      dungeonId_ = other.dungeonId_;
      sceneId_ = other.sceneId_;
      type_ = other.type_;
      sceneTagIdList_ = other.sceneTagIdList_.Clone();
      sceneBeginTime_ = other.sceneBeginTime_;
      enterReason_ = other.enterReason_;
      targetUid_ = other.targetUid_;
      prevPos_ = other.prevPos_ != null ? other.prevPos_.Clone() : null;
      sceneTransaction_ = other.sceneTransaction_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerEnterSceneNotify Clone() {
      return new PlayerEnterSceneNotify(this);
    }

    /// <summary>Field number for the "world_type" field.</summary>
    public const int WorldTypeFieldNumber = 1224;
    private uint worldType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldType {
      get { return worldType_; }
      set {
        worldType_ = value;
      }
    }

    /// <summary>Field number for the "is_first_login_enter_scene" field.</summary>
    public const int IsFirstLoginEnterSceneFieldNumber = 32;
    private bool isFirstLoginEnterScene_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFirstLoginEnterScene {
      get { return isFirstLoginEnterScene_; }
      set {
        isFirstLoginEnterScene_ = value;
      }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 4;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 1;
    private global::Weedwacker.Shared.Network.Proto.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_OKMNOFOHKOB" field.</summary>
    public const int Unk3300OKMNOFOHKOBFieldNumber = 3;
    private bool unk3300OKMNOFOHKOB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300OKMNOFOHKOB {
      get { return unk3300OKMNOFOHKOB_; }
      set {
        unk3300OKMNOFOHKOB_ = value;
      }
    }

    /// <summary>Field number for the "prev_scene_id" field.</summary>
    public const int PrevSceneIdFieldNumber = 13;
    private uint prevSceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PrevSceneId {
      get { return prevSceneId_; }
      set {
        prevSceneId_ = value;
      }
    }

    /// <summary>Field number for the "enter_scene_token" field.</summary>
    public const int EnterSceneTokenFieldNumber = 6;
    private uint enterSceneToken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EnterSceneToken {
      get { return enterSceneToken_; }
      set {
        enterSceneToken_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 2;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 11;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.EnterType type_ = global::Weedwacker.Shared.Network.Proto.EnterType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.EnterType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "scene_tag_id_list" field.</summary>
    public const int SceneTagIdListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_sceneTagIdList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> sceneTagIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SceneTagIdList {
      get { return sceneTagIdList_; }
    }

    /// <summary>Field number for the "scene_begin_time" field.</summary>
    public const int SceneBeginTimeFieldNumber = 9;
    private ulong sceneBeginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong SceneBeginTime {
      get { return sceneBeginTime_; }
      set {
        sceneBeginTime_ = value;
      }
    }

    /// <summary>Field number for the "enter_reason" field.</summary>
    public const int EnterReasonFieldNumber = 287;
    private uint enterReason_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EnterReason {
      get { return enterReason_; }
      set {
        enterReason_ = value;
      }
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 8;
    private uint targetUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetUid {
      get { return targetUid_; }
      set {
        targetUid_ = value;
      }
    }

    /// <summary>Field number for the "prev_pos" field.</summary>
    public const int PrevPosFieldNumber = 10;
    private global::Weedwacker.Shared.Network.Proto.Vector prevPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector PrevPos {
      get { return prevPos_; }
      set {
        prevPos_ = value;
      }
    }

    /// <summary>Field number for the "scene_transaction" field.</summary>
    public const int SceneTransactionFieldNumber = 370;
    private string sceneTransaction_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SceneTransaction {
      get { return sceneTransaction_; }
      set {
        sceneTransaction_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerEnterSceneNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerEnterSceneNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WorldType != other.WorldType) return false;
      if (IsFirstLoginEnterScene != other.IsFirstLoginEnterScene) return false;
      if (WorldLevel != other.WorldLevel) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (Unk3300OKMNOFOHKOB != other.Unk3300OKMNOFOHKOB) return false;
      if (PrevSceneId != other.PrevSceneId) return false;
      if (EnterSceneToken != other.EnterSceneToken) return false;
      if (DungeonId != other.DungeonId) return false;
      if (SceneId != other.SceneId) return false;
      if (Type != other.Type) return false;
      if(!sceneTagIdList_.Equals(other.sceneTagIdList_)) return false;
      if (SceneBeginTime != other.SceneBeginTime) return false;
      if (EnterReason != other.EnterReason) return false;
      if (TargetUid != other.TargetUid) return false;
      if (!object.Equals(PrevPos, other.PrevPos)) return false;
      if (SceneTransaction != other.SceneTransaction) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WorldType != 0) hash ^= WorldType.GetHashCode();
      if (IsFirstLoginEnterScene != false) hash ^= IsFirstLoginEnterScene.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (Unk3300OKMNOFOHKOB != false) hash ^= Unk3300OKMNOFOHKOB.GetHashCode();
      if (PrevSceneId != 0) hash ^= PrevSceneId.GetHashCode();
      if (EnterSceneToken != 0) hash ^= EnterSceneToken.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (Type != global::Weedwacker.Shared.Network.Proto.EnterType.None) hash ^= Type.GetHashCode();
      hash ^= sceneTagIdList_.GetHashCode();
      if (SceneBeginTime != 0UL) hash ^= SceneBeginTime.GetHashCode();
      if (EnterReason != 0) hash ^= EnterReason.GetHashCode();
      if (TargetUid != 0) hash ^= TargetUid.GetHashCode();
      if (prevPos_ != null) hash ^= PrevPos.GetHashCode();
      if (SceneTransaction.Length != 0) hash ^= SceneTransaction.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (pos_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Pos);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DungeonId);
      }
      if (Unk3300OKMNOFOHKOB != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk3300OKMNOFOHKOB);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WorldLevel);
      }
      sceneTagIdList_.WriteTo(output, _repeated_sceneTagIdList_codec);
      if (EnterSceneToken != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EnterSceneToken);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(TargetUid);
      }
      if (SceneBeginTime != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(SceneBeginTime);
      }
      if (prevPos_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(PrevPos);
      }
      if (SceneId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(SceneId);
      }
      if (Type != global::Weedwacker.Shared.Network.Proto.EnterType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Type);
      }
      if (PrevSceneId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(PrevSceneId);
      }
      if (IsFirstLoginEnterScene != false) {
        output.WriteRawTag(128, 2);
        output.WriteBool(IsFirstLoginEnterScene);
      }
      if (EnterReason != 0) {
        output.WriteRawTag(248, 17);
        output.WriteUInt32(EnterReason);
      }
      if (SceneTransaction.Length != 0) {
        output.WriteRawTag(146, 23);
        output.WriteString(SceneTransaction);
      }
      if (WorldType != 0) {
        output.WriteRawTag(192, 76);
        output.WriteUInt32(WorldType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (pos_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Pos);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DungeonId);
      }
      if (Unk3300OKMNOFOHKOB != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk3300OKMNOFOHKOB);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WorldLevel);
      }
      sceneTagIdList_.WriteTo(ref output, _repeated_sceneTagIdList_codec);
      if (EnterSceneToken != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EnterSceneToken);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(TargetUid);
      }
      if (SceneBeginTime != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(SceneBeginTime);
      }
      if (prevPos_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(PrevPos);
      }
      if (SceneId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(SceneId);
      }
      if (Type != global::Weedwacker.Shared.Network.Proto.EnterType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Type);
      }
      if (PrevSceneId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(PrevSceneId);
      }
      if (IsFirstLoginEnterScene != false) {
        output.WriteRawTag(128, 2);
        output.WriteBool(IsFirstLoginEnterScene);
      }
      if (EnterReason != 0) {
        output.WriteRawTag(248, 17);
        output.WriteUInt32(EnterReason);
      }
      if (SceneTransaction.Length != 0) {
        output.WriteRawTag(146, 23);
        output.WriteString(SceneTransaction);
      }
      if (WorldType != 0) {
        output.WriteRawTag(192, 76);
        output.WriteUInt32(WorldType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (WorldType != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(WorldType);
      }
      if (IsFirstLoginEnterScene != false) {
        size += 2 + 1;
      }
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (Unk3300OKMNOFOHKOB != false) {
        size += 1 + 1;
      }
      if (PrevSceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PrevSceneId);
      }
      if (EnterSceneToken != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EnterSceneToken);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (Type != global::Weedwacker.Shared.Network.Proto.EnterType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      size += sceneTagIdList_.CalculateSize(_repeated_sceneTagIdList_codec);
      if (SceneBeginTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(SceneBeginTime);
      }
      if (EnterReason != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(EnterReason);
      }
      if (TargetUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetUid);
      }
      if (prevPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PrevPos);
      }
      if (SceneTransaction.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(SceneTransaction);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerEnterSceneNotify other) {
      if (other == null) {
        return;
      }
      if (other.WorldType != 0) {
        WorldType = other.WorldType;
      }
      if (other.IsFirstLoginEnterScene != false) {
        IsFirstLoginEnterScene = other.IsFirstLoginEnterScene;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.Unk3300OKMNOFOHKOB != false) {
        Unk3300OKMNOFOHKOB = other.Unk3300OKMNOFOHKOB;
      }
      if (other.PrevSceneId != 0) {
        PrevSceneId = other.PrevSceneId;
      }
      if (other.EnterSceneToken != 0) {
        EnterSceneToken = other.EnterSceneToken;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.Type != global::Weedwacker.Shared.Network.Proto.EnterType.None) {
        Type = other.Type;
      }
      sceneTagIdList_.Add(other.sceneTagIdList_);
      if (other.SceneBeginTime != 0UL) {
        SceneBeginTime = other.SceneBeginTime;
      }
      if (other.EnterReason != 0) {
        EnterReason = other.EnterReason;
      }
      if (other.TargetUid != 0) {
        TargetUid = other.TargetUid;
      }
      if (other.prevPos_ != null) {
        if (prevPos_ == null) {
          PrevPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        PrevPos.MergeFrom(other.PrevPos);
      }
      if (other.SceneTransaction.Length != 0) {
        SceneTransaction = other.SceneTransaction;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 16: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk3300OKMNOFOHKOB = input.ReadBool();
            break;
          }
          case 32: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            sceneTagIdList_.AddEntriesFrom(input, _repeated_sceneTagIdList_codec);
            break;
          }
          case 48: {
            EnterSceneToken = input.ReadUInt32();
            break;
          }
          case 64: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 72: {
            SceneBeginTime = input.ReadUInt64();
            break;
          }
          case 82: {
            if (prevPos_ == null) {
              PrevPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(PrevPos);
            break;
          }
          case 88: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 96: {
            Type = (global::Weedwacker.Shared.Network.Proto.EnterType) input.ReadEnum();
            break;
          }
          case 104: {
            PrevSceneId = input.ReadUInt32();
            break;
          }
          case 256: {
            IsFirstLoginEnterScene = input.ReadBool();
            break;
          }
          case 2296: {
            EnterReason = input.ReadUInt32();
            break;
          }
          case 2962: {
            SceneTransaction = input.ReadString();
            break;
          }
          case 9792: {
            WorldType = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 16: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk3300OKMNOFOHKOB = input.ReadBool();
            break;
          }
          case 32: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            sceneTagIdList_.AddEntriesFrom(ref input, _repeated_sceneTagIdList_codec);
            break;
          }
          case 48: {
            EnterSceneToken = input.ReadUInt32();
            break;
          }
          case 64: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 72: {
            SceneBeginTime = input.ReadUInt64();
            break;
          }
          case 82: {
            if (prevPos_ == null) {
              PrevPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(PrevPos);
            break;
          }
          case 88: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 96: {
            Type = (global::Weedwacker.Shared.Network.Proto.EnterType) input.ReadEnum();
            break;
          }
          case 104: {
            PrevSceneId = input.ReadUInt32();
            break;
          }
          case 256: {
            IsFirstLoginEnterScene = input.ReadBool();
            break;
          }
          case 2296: {
            EnterReason = input.ReadUInt32();
            break;
          }
          case 2962: {
            SceneTransaction = input.ReadString();
            break;
          }
          case 9792: {
            WorldType = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
