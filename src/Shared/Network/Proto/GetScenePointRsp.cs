// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetScenePointRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GetScenePointRsp.proto</summary>
  public static partial class GetScenePointRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetScenePointRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetScenePointRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZHZXRTY2VuZVBvaW50UnNwLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvIu0CChBHZXRTY2VuZVBvaW50UnNwEhgKEHVubG9ja19h",
            "cmVhX2xpc3QYCSADKA0SGQoRbG9ja2VkX3BvaW50X2xpc3QYDyADKA0SDwoH",
            "cmV0Y29kZRgNIAEoBRIZChF1bmhpZGVfcG9pbnRfbGlzdBgDIAMoDRIXCg9o",
            "aWRlX3BvaW50X2xpc3QYCiADKA0SIAoYZ3JvdXBfdW5saW1pdF9wb2ludF9s",
            "aXN0GAEgAygNEicKH25vdF9pbnRlcmFjdF9kdW5nZW9uX2VudHJ5X2xpc3QY",
            "CyADKA0SKAogdG9fYmVfZXhwbG9yZV9kdW5nZW9uX2VudHJ5X2xpc3QYBiAD",
            "KA0SJwofbm90X2V4cGxvcmVkX2R1bmdlb25fZW50cnlfbGlzdBgHIAMoDRIS",
            "CgpiZWxvbmdfdWlkGAwgASgNEhsKE3VubG9ja2VkX3BvaW50X2xpc3QYAiAD",
            "KA0SEAoIc2NlbmVfaWQYCCABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GetScenePointRsp), global::Weedwacker.Shared.Network.Proto.GetScenePointRsp.Parser, new[]{ "UnlockAreaList", "LockedPointList", "Retcode", "UnhidePointList", "HidePointList", "GroupUnlimitPointList", "NotInteractDungeonEntryList", "ToBeExploreDungeonEntryList", "NotExploredDungeonEntryList", "BelongUid", "UnlockedPointList", "SceneId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 225;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GetScenePointRsp : pb::IMessage<GetScenePointRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetScenePointRsp> _parser = new pb::MessageParser<GetScenePointRsp>(() => new GetScenePointRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetScenePointRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GetScenePointRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetScenePointRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetScenePointRsp(GetScenePointRsp other) : this() {
      unlockAreaList_ = other.unlockAreaList_.Clone();
      lockedPointList_ = other.lockedPointList_.Clone();
      retcode_ = other.retcode_;
      unhidePointList_ = other.unhidePointList_.Clone();
      hidePointList_ = other.hidePointList_.Clone();
      groupUnlimitPointList_ = other.groupUnlimitPointList_.Clone();
      notInteractDungeonEntryList_ = other.notInteractDungeonEntryList_.Clone();
      toBeExploreDungeonEntryList_ = other.toBeExploreDungeonEntryList_.Clone();
      notExploredDungeonEntryList_ = other.notExploredDungeonEntryList_.Clone();
      belongUid_ = other.belongUid_;
      unlockedPointList_ = other.unlockedPointList_.Clone();
      sceneId_ = other.sceneId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetScenePointRsp Clone() {
      return new GetScenePointRsp(this);
    }

    /// <summary>Field number for the "unlock_area_list" field.</summary>
    public const int UnlockAreaListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_unlockAreaList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> unlockAreaList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockAreaList {
      get { return unlockAreaList_; }
    }

    /// <summary>Field number for the "locked_point_list" field.</summary>
    public const int LockedPointListFieldNumber = 15;
    private static readonly pb::FieldCodec<uint> _repeated_lockedPointList_codec
        = pb::FieldCodec.ForUInt32(122);
    private readonly pbc::RepeatedField<uint> lockedPointList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LockedPointList {
      get { return lockedPointList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "unhide_point_list" field.</summary>
    public const int UnhidePointListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_unhidePointList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> unhidePointList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnhidePointList {
      get { return unhidePointList_; }
    }

    /// <summary>Field number for the "hide_point_list" field.</summary>
    public const int HidePointListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_hidePointList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> hidePointList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HidePointList {
      get { return hidePointList_; }
    }

    /// <summary>Field number for the "group_unlimit_point_list" field.</summary>
    public const int GroupUnlimitPointListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_groupUnlimitPointList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> groupUnlimitPointList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> GroupUnlimitPointList {
      get { return groupUnlimitPointList_; }
    }

    /// <summary>Field number for the "not_interact_dungeon_entry_list" field.</summary>
    public const int NotInteractDungeonEntryListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_notInteractDungeonEntryList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> notInteractDungeonEntryList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> NotInteractDungeonEntryList {
      get { return notInteractDungeonEntryList_; }
    }

    /// <summary>Field number for the "to_be_explore_dungeon_entry_list" field.</summary>
    public const int ToBeExploreDungeonEntryListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_toBeExploreDungeonEntryList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> toBeExploreDungeonEntryList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ToBeExploreDungeonEntryList {
      get { return toBeExploreDungeonEntryList_; }
    }

    /// <summary>Field number for the "not_explored_dungeon_entry_list" field.</summary>
    public const int NotExploredDungeonEntryListFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_notExploredDungeonEntryList_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> notExploredDungeonEntryList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> NotExploredDungeonEntryList {
      get { return notExploredDungeonEntryList_; }
    }

    /// <summary>Field number for the "belong_uid" field.</summary>
    public const int BelongUidFieldNumber = 12;
    private uint belongUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BelongUid {
      get { return belongUid_; }
      set {
        belongUid_ = value;
      }
    }

    /// <summary>Field number for the "unlocked_point_list" field.</summary>
    public const int UnlockedPointListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_unlockedPointList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> unlockedPointList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockedPointList {
      get { return unlockedPointList_; }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 8;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetScenePointRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetScenePointRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unlockAreaList_.Equals(other.unlockAreaList_)) return false;
      if(!lockedPointList_.Equals(other.lockedPointList_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!unhidePointList_.Equals(other.unhidePointList_)) return false;
      if(!hidePointList_.Equals(other.hidePointList_)) return false;
      if(!groupUnlimitPointList_.Equals(other.groupUnlimitPointList_)) return false;
      if(!notInteractDungeonEntryList_.Equals(other.notInteractDungeonEntryList_)) return false;
      if(!toBeExploreDungeonEntryList_.Equals(other.toBeExploreDungeonEntryList_)) return false;
      if(!notExploredDungeonEntryList_.Equals(other.notExploredDungeonEntryList_)) return false;
      if (BelongUid != other.BelongUid) return false;
      if(!unlockedPointList_.Equals(other.unlockedPointList_)) return false;
      if (SceneId != other.SceneId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unlockAreaList_.GetHashCode();
      hash ^= lockedPointList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= unhidePointList_.GetHashCode();
      hash ^= hidePointList_.GetHashCode();
      hash ^= groupUnlimitPointList_.GetHashCode();
      hash ^= notInteractDungeonEntryList_.GetHashCode();
      hash ^= toBeExploreDungeonEntryList_.GetHashCode();
      hash ^= notExploredDungeonEntryList_.GetHashCode();
      if (BelongUid != 0) hash ^= BelongUid.GetHashCode();
      hash ^= unlockedPointList_.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
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
      groupUnlimitPointList_.WriteTo(output, _repeated_groupUnlimitPointList_codec);
      unlockedPointList_.WriteTo(output, _repeated_unlockedPointList_codec);
      unhidePointList_.WriteTo(output, _repeated_unhidePointList_codec);
      toBeExploreDungeonEntryList_.WriteTo(output, _repeated_toBeExploreDungeonEntryList_codec);
      notExploredDungeonEntryList_.WriteTo(output, _repeated_notExploredDungeonEntryList_codec);
      if (SceneId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SceneId);
      }
      unlockAreaList_.WriteTo(output, _repeated_unlockAreaList_codec);
      hidePointList_.WriteTo(output, _repeated_hidePointList_codec);
      notInteractDungeonEntryList_.WriteTo(output, _repeated_notInteractDungeonEntryList_codec);
      if (BelongUid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BelongUid);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Retcode);
      }
      lockedPointList_.WriteTo(output, _repeated_lockedPointList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      groupUnlimitPointList_.WriteTo(ref output, _repeated_groupUnlimitPointList_codec);
      unlockedPointList_.WriteTo(ref output, _repeated_unlockedPointList_codec);
      unhidePointList_.WriteTo(ref output, _repeated_unhidePointList_codec);
      toBeExploreDungeonEntryList_.WriteTo(ref output, _repeated_toBeExploreDungeonEntryList_codec);
      notExploredDungeonEntryList_.WriteTo(ref output, _repeated_notExploredDungeonEntryList_codec);
      if (SceneId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SceneId);
      }
      unlockAreaList_.WriteTo(ref output, _repeated_unlockAreaList_codec);
      hidePointList_.WriteTo(ref output, _repeated_hidePointList_codec);
      notInteractDungeonEntryList_.WriteTo(ref output, _repeated_notInteractDungeonEntryList_codec);
      if (BelongUid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BelongUid);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Retcode);
      }
      lockedPointList_.WriteTo(ref output, _repeated_lockedPointList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unlockAreaList_.CalculateSize(_repeated_unlockAreaList_codec);
      size += lockedPointList_.CalculateSize(_repeated_lockedPointList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += unhidePointList_.CalculateSize(_repeated_unhidePointList_codec);
      size += hidePointList_.CalculateSize(_repeated_hidePointList_codec);
      size += groupUnlimitPointList_.CalculateSize(_repeated_groupUnlimitPointList_codec);
      size += notInteractDungeonEntryList_.CalculateSize(_repeated_notInteractDungeonEntryList_codec);
      size += toBeExploreDungeonEntryList_.CalculateSize(_repeated_toBeExploreDungeonEntryList_codec);
      size += notExploredDungeonEntryList_.CalculateSize(_repeated_notExploredDungeonEntryList_codec);
      if (BelongUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BelongUid);
      }
      size += unlockedPointList_.CalculateSize(_repeated_unlockedPointList_codec);
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetScenePointRsp other) {
      if (other == null) {
        return;
      }
      unlockAreaList_.Add(other.unlockAreaList_);
      lockedPointList_.Add(other.lockedPointList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      unhidePointList_.Add(other.unhidePointList_);
      hidePointList_.Add(other.hidePointList_);
      groupUnlimitPointList_.Add(other.groupUnlimitPointList_);
      notInteractDungeonEntryList_.Add(other.notInteractDungeonEntryList_);
      toBeExploreDungeonEntryList_.Add(other.toBeExploreDungeonEntryList_);
      notExploredDungeonEntryList_.Add(other.notExploredDungeonEntryList_);
      if (other.BelongUid != 0) {
        BelongUid = other.BelongUid;
      }
      unlockedPointList_.Add(other.unlockedPointList_);
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
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
          case 10:
          case 8: {
            groupUnlimitPointList_.AddEntriesFrom(input, _repeated_groupUnlimitPointList_codec);
            break;
          }
          case 18:
          case 16: {
            unlockedPointList_.AddEntriesFrom(input, _repeated_unlockedPointList_codec);
            break;
          }
          case 26:
          case 24: {
            unhidePointList_.AddEntriesFrom(input, _repeated_unhidePointList_codec);
            break;
          }
          case 50:
          case 48: {
            toBeExploreDungeonEntryList_.AddEntriesFrom(input, _repeated_toBeExploreDungeonEntryList_codec);
            break;
          }
          case 58:
          case 56: {
            notExploredDungeonEntryList_.AddEntriesFrom(input, _repeated_notExploredDungeonEntryList_codec);
            break;
          }
          case 64: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            unlockAreaList_.AddEntriesFrom(input, _repeated_unlockAreaList_codec);
            break;
          }
          case 82:
          case 80: {
            hidePointList_.AddEntriesFrom(input, _repeated_hidePointList_codec);
            break;
          }
          case 90:
          case 88: {
            notInteractDungeonEntryList_.AddEntriesFrom(input, _repeated_notInteractDungeonEntryList_codec);
            break;
          }
          case 96: {
            BelongUid = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadInt32();
            break;
          }
          case 122:
          case 120: {
            lockedPointList_.AddEntriesFrom(input, _repeated_lockedPointList_codec);
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
          case 10:
          case 8: {
            groupUnlimitPointList_.AddEntriesFrom(ref input, _repeated_groupUnlimitPointList_codec);
            break;
          }
          case 18:
          case 16: {
            unlockedPointList_.AddEntriesFrom(ref input, _repeated_unlockedPointList_codec);
            break;
          }
          case 26:
          case 24: {
            unhidePointList_.AddEntriesFrom(ref input, _repeated_unhidePointList_codec);
            break;
          }
          case 50:
          case 48: {
            toBeExploreDungeonEntryList_.AddEntriesFrom(ref input, _repeated_toBeExploreDungeonEntryList_codec);
            break;
          }
          case 58:
          case 56: {
            notExploredDungeonEntryList_.AddEntriesFrom(ref input, _repeated_notExploredDungeonEntryList_codec);
            break;
          }
          case 64: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            unlockAreaList_.AddEntriesFrom(ref input, _repeated_unlockAreaList_codec);
            break;
          }
          case 82:
          case 80: {
            hidePointList_.AddEntriesFrom(ref input, _repeated_hidePointList_codec);
            break;
          }
          case 90:
          case 88: {
            notInteractDungeonEntryList_.AddEntriesFrom(ref input, _repeated_notInteractDungeonEntryList_codec);
            break;
          }
          case 96: {
            BelongUid = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadInt32();
            break;
          }
          case 122:
          case 120: {
            lockedPointList_.AddEntriesFrom(ref input, _repeated_lockedPointList_codec);
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
