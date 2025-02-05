// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeBlueprintSlotInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeBlueprintSlotInfo.proto</summary>
  public static partial class HomeBlueprintSlotInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeBlueprintSlotInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeBlueprintSlotInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtIb21lQmx1ZXByaW50U2xvdEluZm8ucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8inwEKFUhvbWVCbHVlcHJpbnRTbG90SW5mbxIT",
            "CgtjcmVhdGVfdGltZRgMIAEoDRIQCghzY2VuZV9pZBgKIAEoDRISCgpzaGFy",
            "ZV9jb2RlGAkgASgJEhEKCW1vZHVsZV9pZBgDIAEoDRIQCghibG9ja19pZBgC",
            "IAEoDRIPCgdzbG90X2lkGAggASgNEhUKDWlzX2FsbG93X2NvcHkYBiABKAhi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeBlueprintSlotInfo), global::Weedwacker.Shared.Network.Proto.HomeBlueprintSlotInfo.Parser, new[]{ "CreateTime", "SceneId", "ShareCode", "ModuleId", "BlockId", "SlotId", "IsAllowCopy" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeBlueprintSlotInfo : pb::IMessage<HomeBlueprintSlotInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeBlueprintSlotInfo> _parser = new pb::MessageParser<HomeBlueprintSlotInfo>(() => new HomeBlueprintSlotInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeBlueprintSlotInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeBlueprintSlotInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlueprintSlotInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlueprintSlotInfo(HomeBlueprintSlotInfo other) : this() {
      createTime_ = other.createTime_;
      sceneId_ = other.sceneId_;
      shareCode_ = other.shareCode_;
      moduleId_ = other.moduleId_;
      blockId_ = other.blockId_;
      slotId_ = other.slotId_;
      isAllowCopy_ = other.isAllowCopy_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlueprintSlotInfo Clone() {
      return new HomeBlueprintSlotInfo(this);
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 12;
    private uint createTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 10;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "share_code" field.</summary>
    public const int ShareCodeFieldNumber = 9;
    private string shareCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ShareCode {
      get { return shareCode_; }
      set {
        shareCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "module_id" field.</summary>
    public const int ModuleIdFieldNumber = 3;
    private uint moduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ModuleId {
      get { return moduleId_; }
      set {
        moduleId_ = value;
      }
    }

    /// <summary>Field number for the "block_id" field.</summary>
    public const int BlockIdFieldNumber = 2;
    private uint blockId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BlockId {
      get { return blockId_; }
      set {
        blockId_ = value;
      }
    }

    /// <summary>Field number for the "slot_id" field.</summary>
    public const int SlotIdFieldNumber = 8;
    private uint slotId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SlotId {
      get { return slotId_; }
      set {
        slotId_ = value;
      }
    }

    /// <summary>Field number for the "is_allow_copy" field.</summary>
    public const int IsAllowCopyFieldNumber = 6;
    private bool isAllowCopy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAllowCopy {
      get { return isAllowCopy_; }
      set {
        isAllowCopy_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeBlueprintSlotInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeBlueprintSlotInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CreateTime != other.CreateTime) return false;
      if (SceneId != other.SceneId) return false;
      if (ShareCode != other.ShareCode) return false;
      if (ModuleId != other.ModuleId) return false;
      if (BlockId != other.BlockId) return false;
      if (SlotId != other.SlotId) return false;
      if (IsAllowCopy != other.IsAllowCopy) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CreateTime != 0) hash ^= CreateTime.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (ShareCode.Length != 0) hash ^= ShareCode.GetHashCode();
      if (ModuleId != 0) hash ^= ModuleId.GetHashCode();
      if (BlockId != 0) hash ^= BlockId.GetHashCode();
      if (SlotId != 0) hash ^= SlotId.GetHashCode();
      if (IsAllowCopy != false) hash ^= IsAllowCopy.GetHashCode();
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
      if (BlockId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BlockId);
      }
      if (ModuleId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ModuleId);
      }
      if (IsAllowCopy != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsAllowCopy);
      }
      if (SlotId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SlotId);
      }
      if (ShareCode.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(ShareCode);
      }
      if (SceneId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(SceneId);
      }
      if (CreateTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CreateTime);
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
      if (BlockId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BlockId);
      }
      if (ModuleId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ModuleId);
      }
      if (IsAllowCopy != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsAllowCopy);
      }
      if (SlotId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SlotId);
      }
      if (ShareCode.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(ShareCode);
      }
      if (SceneId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(SceneId);
      }
      if (CreateTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CreateTime);
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
      if (CreateTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CreateTime);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (ShareCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ShareCode);
      }
      if (ModuleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ModuleId);
      }
      if (BlockId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BlockId);
      }
      if (SlotId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SlotId);
      }
      if (IsAllowCopy != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeBlueprintSlotInfo other) {
      if (other == null) {
        return;
      }
      if (other.CreateTime != 0) {
        CreateTime = other.CreateTime;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.ShareCode.Length != 0) {
        ShareCode = other.ShareCode;
      }
      if (other.ModuleId != 0) {
        ModuleId = other.ModuleId;
      }
      if (other.BlockId != 0) {
        BlockId = other.BlockId;
      }
      if (other.SlotId != 0) {
        SlotId = other.SlotId;
      }
      if (other.IsAllowCopy != false) {
        IsAllowCopy = other.IsAllowCopy;
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
          case 16: {
            BlockId = input.ReadUInt32();
            break;
          }
          case 24: {
            ModuleId = input.ReadUInt32();
            break;
          }
          case 48: {
            IsAllowCopy = input.ReadBool();
            break;
          }
          case 64: {
            SlotId = input.ReadUInt32();
            break;
          }
          case 74: {
            ShareCode = input.ReadString();
            break;
          }
          case 80: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 96: {
            CreateTime = input.ReadUInt32();
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
          case 16: {
            BlockId = input.ReadUInt32();
            break;
          }
          case 24: {
            ModuleId = input.ReadUInt32();
            break;
          }
          case 48: {
            IsAllowCopy = input.ReadBool();
            break;
          }
          case 64: {
            SlotId = input.ReadUInt32();
            break;
          }
          case 74: {
            ShareCode = input.ReadString();
            break;
          }
          case 80: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 96: {
            CreateTime = input.ReadUInt32();
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
