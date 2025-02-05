// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarSkillUpgradeRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AvatarSkillUpgradeRsp.proto</summary>
  public static partial class AvatarSkillUpgradeRspReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarSkillUpgradeRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarSkillUpgradeRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtBdmF0YXJTa2lsbFVwZ3JhZGVSc3AucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8ifAoVQXZhdGFyU2tpbGxVcGdyYWRlUnNwEhEK",
            "CWN1cl9sZXZlbBgGIAEoDRIXCg9hdmF0YXJfc2tpbGxfaWQYDSABKA0SDwoH",
            "cmV0Y29kZRgPIAEoBRIRCglvbGRfbGV2ZWwYASABKA0SEwoLYXZhdGFyX2d1",
            "aWQYBSABKARiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AvatarSkillUpgradeRsp), global::Weedwacker.Shared.Network.Proto.AvatarSkillUpgradeRsp.Parser, new[]{ "CurLevel", "AvatarSkillId", "Retcode", "OldLevel", "AvatarGuid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1048;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class AvatarSkillUpgradeRsp : pb::IMessage<AvatarSkillUpgradeRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarSkillUpgradeRsp> _parser = new pb::MessageParser<AvatarSkillUpgradeRsp>(() => new AvatarSkillUpgradeRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarSkillUpgradeRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AvatarSkillUpgradeRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarSkillUpgradeRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarSkillUpgradeRsp(AvatarSkillUpgradeRsp other) : this() {
      curLevel_ = other.curLevel_;
      avatarSkillId_ = other.avatarSkillId_;
      retcode_ = other.retcode_;
      oldLevel_ = other.oldLevel_;
      avatarGuid_ = other.avatarGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarSkillUpgradeRsp Clone() {
      return new AvatarSkillUpgradeRsp(this);
    }

    /// <summary>Field number for the "cur_level" field.</summary>
    public const int CurLevelFieldNumber = 6;
    private uint curLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurLevel {
      get { return curLevel_; }
      set {
        curLevel_ = value;
      }
    }

    /// <summary>Field number for the "avatar_skill_id" field.</summary>
    public const int AvatarSkillIdFieldNumber = 13;
    private uint avatarSkillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarSkillId {
      get { return avatarSkillId_; }
      set {
        avatarSkillId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 15;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "old_level" field.</summary>
    public const int OldLevelFieldNumber = 1;
    private uint oldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OldLevel {
      get { return oldLevel_; }
      set {
        oldLevel_ = value;
      }
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 5;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvatarSkillUpgradeRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarSkillUpgradeRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurLevel != other.CurLevel) return false;
      if (AvatarSkillId != other.AvatarSkillId) return false;
      if (Retcode != other.Retcode) return false;
      if (OldLevel != other.OldLevel) return false;
      if (AvatarGuid != other.AvatarGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurLevel != 0) hash ^= CurLevel.GetHashCode();
      if (AvatarSkillId != 0) hash ^= AvatarSkillId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (OldLevel != 0) hash ^= OldLevel.GetHashCode();
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
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
      if (OldLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(OldLevel);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(AvatarGuid);
      }
      if (CurLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CurLevel);
      }
      if (AvatarSkillId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(AvatarSkillId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(Retcode);
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
      if (OldLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(OldLevel);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(AvatarGuid);
      }
      if (CurLevel != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CurLevel);
      }
      if (AvatarSkillId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(AvatarSkillId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(Retcode);
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
      if (CurLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurLevel);
      }
      if (AvatarSkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarSkillId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (OldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OldLevel);
      }
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvatarSkillUpgradeRsp other) {
      if (other == null) {
        return;
      }
      if (other.CurLevel != 0) {
        CurLevel = other.CurLevel;
      }
      if (other.AvatarSkillId != 0) {
        AvatarSkillId = other.AvatarSkillId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.OldLevel != 0) {
        OldLevel = other.OldLevel;
      }
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
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
            OldLevel = input.ReadUInt32();
            break;
          }
          case 40: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 48: {
            CurLevel = input.ReadUInt32();
            break;
          }
          case 104: {
            AvatarSkillId = input.ReadUInt32();
            break;
          }
          case 120: {
            Retcode = input.ReadInt32();
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
            OldLevel = input.ReadUInt32();
            break;
          }
          case 40: {
            AvatarGuid = input.ReadUInt64();
            break;
          }
          case 48: {
            CurLevel = input.ReadUInt32();
            break;
          }
          case 104: {
            AvatarSkillId = input.ReadUInt32();
            break;
          }
          case 120: {
            Retcode = input.ReadInt32();
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
