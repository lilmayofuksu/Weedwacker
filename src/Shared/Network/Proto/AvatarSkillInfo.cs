// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarSkillInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AvatarSkillInfo.proto</summary>
  public static partial class AvatarSkillInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarSkillInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarSkillInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVBdmF0YXJTa2lsbEluZm8ucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG8iXAoPQXZhdGFyU2tpbGxJbmZvEhQKDHBhc3NfY2RfdGlt",
            "ZRgBIAEoDRIZChFmdWxsX2NkX3RpbWVfbGlzdBgCIAMoDRIYChBtYXhfY2hh",
            "cmdlX2NvdW50GAMgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AvatarSkillInfo), global::Weedwacker.Shared.Network.Proto.AvatarSkillInfo.Parser, new[]{ "PassCdTime", "FullCdTimeList", "MaxChargeCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AvatarSkillInfo : pb::IMessage<AvatarSkillInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarSkillInfo> _parser = new pb::MessageParser<AvatarSkillInfo>(() => new AvatarSkillInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarSkillInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AvatarSkillInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarSkillInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarSkillInfo(AvatarSkillInfo other) : this() {
      passCdTime_ = other.passCdTime_;
      fullCdTimeList_ = other.fullCdTimeList_.Clone();
      maxChargeCount_ = other.maxChargeCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarSkillInfo Clone() {
      return new AvatarSkillInfo(this);
    }

    /// <summary>Field number for the "pass_cd_time" field.</summary>
    public const int PassCdTimeFieldNumber = 1;
    private uint passCdTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PassCdTime {
      get { return passCdTime_; }
      set {
        passCdTime_ = value;
      }
    }

    /// <summary>Field number for the "full_cd_time_list" field.</summary>
    public const int FullCdTimeListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_fullCdTimeList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> fullCdTimeList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FullCdTimeList {
      get { return fullCdTimeList_; }
    }

    /// <summary>Field number for the "max_charge_count" field.</summary>
    public const int MaxChargeCountFieldNumber = 3;
    private uint maxChargeCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxChargeCount {
      get { return maxChargeCount_; }
      set {
        maxChargeCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvatarSkillInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarSkillInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PassCdTime != other.PassCdTime) return false;
      if(!fullCdTimeList_.Equals(other.fullCdTimeList_)) return false;
      if (MaxChargeCount != other.MaxChargeCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PassCdTime != 0) hash ^= PassCdTime.GetHashCode();
      hash ^= fullCdTimeList_.GetHashCode();
      if (MaxChargeCount != 0) hash ^= MaxChargeCount.GetHashCode();
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
      if (PassCdTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PassCdTime);
      }
      fullCdTimeList_.WriteTo(output, _repeated_fullCdTimeList_codec);
      if (MaxChargeCount != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(MaxChargeCount);
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
      if (PassCdTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PassCdTime);
      }
      fullCdTimeList_.WriteTo(ref output, _repeated_fullCdTimeList_codec);
      if (MaxChargeCount != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(MaxChargeCount);
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
      if (PassCdTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PassCdTime);
      }
      size += fullCdTimeList_.CalculateSize(_repeated_fullCdTimeList_codec);
      if (MaxChargeCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxChargeCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvatarSkillInfo other) {
      if (other == null) {
        return;
      }
      if (other.PassCdTime != 0) {
        PassCdTime = other.PassCdTime;
      }
      fullCdTimeList_.Add(other.fullCdTimeList_);
      if (other.MaxChargeCount != 0) {
        MaxChargeCount = other.MaxChargeCount;
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
          case 8: {
            PassCdTime = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            fullCdTimeList_.AddEntriesFrom(input, _repeated_fullCdTimeList_codec);
            break;
          }
          case 24: {
            MaxChargeCount = input.ReadUInt32();
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
          case 8: {
            PassCdTime = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            fullCdTimeList_.AddEntriesFrom(ref input, _repeated_fullCdTimeList_codec);
            break;
          }
          case 24: {
            MaxChargeCount = input.ReadUInt32();
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
