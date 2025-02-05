// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HideAndSeekStageInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HideAndSeekStageInfo.proto</summary>
  public static partial class HideAndSeekStageInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HideAndSeekStageInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HideAndSeekStageInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpIaWRlQW5kU2Vla1N0YWdlSW5mby5wcm90bxIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90bxohSGlkZUFuZFNlZWtQbGF5ZXJCYXR0bGVJbmZv",
            "LnByb3RvGhpIaWRlQW5kU2Vla1N0YWdlVHlwZS5wcm90byKNAwoUSGlkZUFu",
            "ZFNlZWtTdGFnZUluZm8SEgoKaHVudGVyX3VpZBgJIAEoDRJhCg9iYXR0bGVf",
            "aW5mb19tYXAYCCADKAsySC5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlBy",
            "b3RvLkhpZGVBbmRTZWVrU3RhZ2VJbmZvLkJhdHRsZUluZm9NYXBFbnRyeRIX",
            "Cg9pc19yZWNvcmRfc2NvcmUYBSABKAgSFgoOaGlkZXJfdWlkX2xpc3QYAiAD",
            "KA0SDgoGbWFwX2lkGA0gASgNEkkKCnN0YWdlX3R5cGUYBiABKA4yNS5XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkhpZGVBbmRTZWVrU3RhZ2VU",
            "eXBlGnIKEkJhdHRsZUluZm9NYXBFbnRyeRILCgNrZXkYASABKA0SSwoFdmFs",
            "dWUYAiABKAsyPC5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkhp",
            "ZGVBbmRTZWVrUGxheWVyQmF0dGxlSW5mbzoCOAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HideAndSeekPlayerBattleInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.HideAndSeekStageTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HideAndSeekStageInfo), global::Weedwacker.Shared.Network.Proto.HideAndSeekStageInfo.Parser, new[]{ "HunterUid", "BattleInfoMap", "IsRecordScore", "HiderUidList", "MapId", "StageType" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HideAndSeekStageInfo : pb::IMessage<HideAndSeekStageInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HideAndSeekStageInfo> _parser = new pb::MessageParser<HideAndSeekStageInfo>(() => new HideAndSeekStageInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HideAndSeekStageInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HideAndSeekStageInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HideAndSeekStageInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HideAndSeekStageInfo(HideAndSeekStageInfo other) : this() {
      hunterUid_ = other.hunterUid_;
      battleInfoMap_ = other.battleInfoMap_.Clone();
      isRecordScore_ = other.isRecordScore_;
      hiderUidList_ = other.hiderUidList_.Clone();
      mapId_ = other.mapId_;
      stageType_ = other.stageType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HideAndSeekStageInfo Clone() {
      return new HideAndSeekStageInfo(this);
    }

    /// <summary>Field number for the "hunter_uid" field.</summary>
    public const int HunterUidFieldNumber = 9;
    private uint hunterUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HunterUid {
      get { return hunterUid_; }
      set {
        hunterUid_ = value;
      }
    }

    /// <summary>Field number for the "battle_info_map" field.</summary>
    public const int BattleInfoMapFieldNumber = 8;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.HideAndSeekPlayerBattleInfo>.Codec _map_battleInfoMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.HideAndSeekPlayerBattleInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.HideAndSeekPlayerBattleInfo.Parser), 66);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.HideAndSeekPlayerBattleInfo> battleInfoMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.HideAndSeekPlayerBattleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.HideAndSeekPlayerBattleInfo> BattleInfoMap {
      get { return battleInfoMap_; }
    }

    /// <summary>Field number for the "is_record_score" field.</summary>
    public const int IsRecordScoreFieldNumber = 5;
    private bool isRecordScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRecordScore {
      get { return isRecordScore_; }
      set {
        isRecordScore_ = value;
      }
    }

    /// <summary>Field number for the "hider_uid_list" field.</summary>
    public const int HiderUidListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_hiderUidList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> hiderUidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HiderUidList {
      get { return hiderUidList_; }
    }

    /// <summary>Field number for the "map_id" field.</summary>
    public const int MapIdFieldNumber = 13;
    private uint mapId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MapId {
      get { return mapId_; }
      set {
        mapId_ = value;
      }
    }

    /// <summary>Field number for the "stage_type" field.</summary>
    public const int StageTypeFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.HideAndSeekStageType stageType_ = global::Weedwacker.Shared.Network.Proto.HideAndSeekStageType.Prepare;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.HideAndSeekStageType StageType {
      get { return stageType_; }
      set {
        stageType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HideAndSeekStageInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HideAndSeekStageInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HunterUid != other.HunterUid) return false;
      if (!BattleInfoMap.Equals(other.BattleInfoMap)) return false;
      if (IsRecordScore != other.IsRecordScore) return false;
      if(!hiderUidList_.Equals(other.hiderUidList_)) return false;
      if (MapId != other.MapId) return false;
      if (StageType != other.StageType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HunterUid != 0) hash ^= HunterUid.GetHashCode();
      hash ^= BattleInfoMap.GetHashCode();
      if (IsRecordScore != false) hash ^= IsRecordScore.GetHashCode();
      hash ^= hiderUidList_.GetHashCode();
      if (MapId != 0) hash ^= MapId.GetHashCode();
      if (StageType != global::Weedwacker.Shared.Network.Proto.HideAndSeekStageType.Prepare) hash ^= StageType.GetHashCode();
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
      hiderUidList_.WriteTo(output, _repeated_hiderUidList_codec);
      if (IsRecordScore != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsRecordScore);
      }
      if (StageType != global::Weedwacker.Shared.Network.Proto.HideAndSeekStageType.Prepare) {
        output.WriteRawTag(48);
        output.WriteEnum((int) StageType);
      }
      battleInfoMap_.WriteTo(output, _map_battleInfoMap_codec);
      if (HunterUid != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(HunterUid);
      }
      if (MapId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MapId);
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
      hiderUidList_.WriteTo(ref output, _repeated_hiderUidList_codec);
      if (IsRecordScore != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsRecordScore);
      }
      if (StageType != global::Weedwacker.Shared.Network.Proto.HideAndSeekStageType.Prepare) {
        output.WriteRawTag(48);
        output.WriteEnum((int) StageType);
      }
      battleInfoMap_.WriteTo(ref output, _map_battleInfoMap_codec);
      if (HunterUid != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(HunterUid);
      }
      if (MapId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MapId);
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
      if (HunterUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HunterUid);
      }
      size += battleInfoMap_.CalculateSize(_map_battleInfoMap_codec);
      if (IsRecordScore != false) {
        size += 1 + 1;
      }
      size += hiderUidList_.CalculateSize(_repeated_hiderUidList_codec);
      if (MapId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MapId);
      }
      if (StageType != global::Weedwacker.Shared.Network.Proto.HideAndSeekStageType.Prepare) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) StageType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HideAndSeekStageInfo other) {
      if (other == null) {
        return;
      }
      if (other.HunterUid != 0) {
        HunterUid = other.HunterUid;
      }
      battleInfoMap_.Add(other.battleInfoMap_);
      if (other.IsRecordScore != false) {
        IsRecordScore = other.IsRecordScore;
      }
      hiderUidList_.Add(other.hiderUidList_);
      if (other.MapId != 0) {
        MapId = other.MapId;
      }
      if (other.StageType != global::Weedwacker.Shared.Network.Proto.HideAndSeekStageType.Prepare) {
        StageType = other.StageType;
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
          case 18:
          case 16: {
            hiderUidList_.AddEntriesFrom(input, _repeated_hiderUidList_codec);
            break;
          }
          case 40: {
            IsRecordScore = input.ReadBool();
            break;
          }
          case 48: {
            StageType = (global::Weedwacker.Shared.Network.Proto.HideAndSeekStageType) input.ReadEnum();
            break;
          }
          case 66: {
            battleInfoMap_.AddEntriesFrom(input, _map_battleInfoMap_codec);
            break;
          }
          case 72: {
            HunterUid = input.ReadUInt32();
            break;
          }
          case 104: {
            MapId = input.ReadUInt32();
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
          case 18:
          case 16: {
            hiderUidList_.AddEntriesFrom(ref input, _repeated_hiderUidList_codec);
            break;
          }
          case 40: {
            IsRecordScore = input.ReadBool();
            break;
          }
          case 48: {
            StageType = (global::Weedwacker.Shared.Network.Proto.HideAndSeekStageType) input.ReadEnum();
            break;
          }
          case 66: {
            battleInfoMap_.AddEntriesFrom(ref input, _map_battleInfoMap_codec);
            break;
          }
          case 72: {
            HunterUid = input.ReadUInt32();
            break;
          }
          case 104: {
            MapId = input.ReadUInt32();
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
