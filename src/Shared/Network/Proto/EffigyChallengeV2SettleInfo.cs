// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EffigyChallengeV2SettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EffigyChallengeV2SettleInfo.proto</summary>
  public static partial class EffigyChallengeV2SettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EffigyChallengeV2SettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EffigyChallengeV2SettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFFZmZpZ3lDaGFsbGVuZ2VWMlNldHRsZUluZm8ucHJvdG8SH1dlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8i0QEKG0VmZmlneUNoYWxsZW5nZVYy",
            "U2V0dGxlSW5mbxIhChljaGFsbGVuZ2VfbW9kZV9kaWZmaWN1bHR5GA0gASgN",
            "EhsKE1VuazMzMDBfTUhPSUlQSktBTU4YDiABKA0SGwoTVW5rMzMwMF9QSEVJ",
            "TUxPS0lKRxgLIAEoDRIbChNVbmszMzAwX09OS1BHRk9MREZMGAwgASgNEhsK",
            "E1VuazMzMDBfTkdCS05ESEpQQ1AYBSABKAgSGwoTVW5rMzMwMF9BS01QQ0RJ",
            "S0JKRBgJIAEoCGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EffigyChallengeV2SettleInfo), global::Weedwacker.Shared.Network.Proto.EffigyChallengeV2SettleInfo.Parser, new[]{ "ChallengeModeDifficulty", "Unk3300MHOIIPJKAMN", "Unk3300PHEIMLOKIJG", "Unk3300ONKPGFOLDFL", "Unk3300NGBKNDHJPCP", "Unk3300AKMPCDIKBJD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EffigyChallengeV2SettleInfo : pb::IMessage<EffigyChallengeV2SettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EffigyChallengeV2SettleInfo> _parser = new pb::MessageParser<EffigyChallengeV2SettleInfo>(() => new EffigyChallengeV2SettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EffigyChallengeV2SettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EffigyChallengeV2SettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeV2SettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeV2SettleInfo(EffigyChallengeV2SettleInfo other) : this() {
      challengeModeDifficulty_ = other.challengeModeDifficulty_;
      unk3300MHOIIPJKAMN_ = other.unk3300MHOIIPJKAMN_;
      unk3300PHEIMLOKIJG_ = other.unk3300PHEIMLOKIJG_;
      unk3300ONKPGFOLDFL_ = other.unk3300ONKPGFOLDFL_;
      unk3300NGBKNDHJPCP_ = other.unk3300NGBKNDHJPCP_;
      unk3300AKMPCDIKBJD_ = other.unk3300AKMPCDIKBJD_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeV2SettleInfo Clone() {
      return new EffigyChallengeV2SettleInfo(this);
    }

    /// <summary>Field number for the "challenge_mode_difficulty" field.</summary>
    public const int ChallengeModeDifficultyFieldNumber = 13;
    private uint challengeModeDifficulty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeModeDifficulty {
      get { return challengeModeDifficulty_; }
      set {
        challengeModeDifficulty_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_MHOIIPJKAMN" field.</summary>
    public const int Unk3300MHOIIPJKAMNFieldNumber = 14;
    private uint unk3300MHOIIPJKAMN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300MHOIIPJKAMN {
      get { return unk3300MHOIIPJKAMN_; }
      set {
        unk3300MHOIIPJKAMN_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_PHEIMLOKIJG" field.</summary>
    public const int Unk3300PHEIMLOKIJGFieldNumber = 11;
    private uint unk3300PHEIMLOKIJG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300PHEIMLOKIJG {
      get { return unk3300PHEIMLOKIJG_; }
      set {
        unk3300PHEIMLOKIJG_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_ONKPGFOLDFL" field.</summary>
    public const int Unk3300ONKPGFOLDFLFieldNumber = 12;
    private uint unk3300ONKPGFOLDFL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300ONKPGFOLDFL {
      get { return unk3300ONKPGFOLDFL_; }
      set {
        unk3300ONKPGFOLDFL_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_NGBKNDHJPCP" field.</summary>
    public const int Unk3300NGBKNDHJPCPFieldNumber = 5;
    private bool unk3300NGBKNDHJPCP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300NGBKNDHJPCP {
      get { return unk3300NGBKNDHJPCP_; }
      set {
        unk3300NGBKNDHJPCP_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_AKMPCDIKBJD" field.</summary>
    public const int Unk3300AKMPCDIKBJDFieldNumber = 9;
    private bool unk3300AKMPCDIKBJD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300AKMPCDIKBJD {
      get { return unk3300AKMPCDIKBJD_; }
      set {
        unk3300AKMPCDIKBJD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EffigyChallengeV2SettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EffigyChallengeV2SettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChallengeModeDifficulty != other.ChallengeModeDifficulty) return false;
      if (Unk3300MHOIIPJKAMN != other.Unk3300MHOIIPJKAMN) return false;
      if (Unk3300PHEIMLOKIJG != other.Unk3300PHEIMLOKIJG) return false;
      if (Unk3300ONKPGFOLDFL != other.Unk3300ONKPGFOLDFL) return false;
      if (Unk3300NGBKNDHJPCP != other.Unk3300NGBKNDHJPCP) return false;
      if (Unk3300AKMPCDIKBJD != other.Unk3300AKMPCDIKBJD) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChallengeModeDifficulty != 0) hash ^= ChallengeModeDifficulty.GetHashCode();
      if (Unk3300MHOIIPJKAMN != 0) hash ^= Unk3300MHOIIPJKAMN.GetHashCode();
      if (Unk3300PHEIMLOKIJG != 0) hash ^= Unk3300PHEIMLOKIJG.GetHashCode();
      if (Unk3300ONKPGFOLDFL != 0) hash ^= Unk3300ONKPGFOLDFL.GetHashCode();
      if (Unk3300NGBKNDHJPCP != false) hash ^= Unk3300NGBKNDHJPCP.GetHashCode();
      if (Unk3300AKMPCDIKBJD != false) hash ^= Unk3300AKMPCDIKBJD.GetHashCode();
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
      if (Unk3300NGBKNDHJPCP != false) {
        output.WriteRawTag(40);
        output.WriteBool(Unk3300NGBKNDHJPCP);
      }
      if (Unk3300AKMPCDIKBJD != false) {
        output.WriteRawTag(72);
        output.WriteBool(Unk3300AKMPCDIKBJD);
      }
      if (Unk3300PHEIMLOKIJG != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300PHEIMLOKIJG);
      }
      if (Unk3300ONKPGFOLDFL != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk3300ONKPGFOLDFL);
      }
      if (ChallengeModeDifficulty != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChallengeModeDifficulty);
      }
      if (Unk3300MHOIIPJKAMN != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300MHOIIPJKAMN);
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
      if (Unk3300NGBKNDHJPCP != false) {
        output.WriteRawTag(40);
        output.WriteBool(Unk3300NGBKNDHJPCP);
      }
      if (Unk3300AKMPCDIKBJD != false) {
        output.WriteRawTag(72);
        output.WriteBool(Unk3300AKMPCDIKBJD);
      }
      if (Unk3300PHEIMLOKIJG != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300PHEIMLOKIJG);
      }
      if (Unk3300ONKPGFOLDFL != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk3300ONKPGFOLDFL);
      }
      if (ChallengeModeDifficulty != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChallengeModeDifficulty);
      }
      if (Unk3300MHOIIPJKAMN != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300MHOIIPJKAMN);
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
      if (ChallengeModeDifficulty != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeModeDifficulty);
      }
      if (Unk3300MHOIIPJKAMN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300MHOIIPJKAMN);
      }
      if (Unk3300PHEIMLOKIJG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300PHEIMLOKIJG);
      }
      if (Unk3300ONKPGFOLDFL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300ONKPGFOLDFL);
      }
      if (Unk3300NGBKNDHJPCP != false) {
        size += 1 + 1;
      }
      if (Unk3300AKMPCDIKBJD != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EffigyChallengeV2SettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.ChallengeModeDifficulty != 0) {
        ChallengeModeDifficulty = other.ChallengeModeDifficulty;
      }
      if (other.Unk3300MHOIIPJKAMN != 0) {
        Unk3300MHOIIPJKAMN = other.Unk3300MHOIIPJKAMN;
      }
      if (other.Unk3300PHEIMLOKIJG != 0) {
        Unk3300PHEIMLOKIJG = other.Unk3300PHEIMLOKIJG;
      }
      if (other.Unk3300ONKPGFOLDFL != 0) {
        Unk3300ONKPGFOLDFL = other.Unk3300ONKPGFOLDFL;
      }
      if (other.Unk3300NGBKNDHJPCP != false) {
        Unk3300NGBKNDHJPCP = other.Unk3300NGBKNDHJPCP;
      }
      if (other.Unk3300AKMPCDIKBJD != false) {
        Unk3300AKMPCDIKBJD = other.Unk3300AKMPCDIKBJD;
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
          case 40: {
            Unk3300NGBKNDHJPCP = input.ReadBool();
            break;
          }
          case 72: {
            Unk3300AKMPCDIKBJD = input.ReadBool();
            break;
          }
          case 88: {
            Unk3300PHEIMLOKIJG = input.ReadUInt32();
            break;
          }
          case 96: {
            Unk3300ONKPGFOLDFL = input.ReadUInt32();
            break;
          }
          case 104: {
            ChallengeModeDifficulty = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300MHOIIPJKAMN = input.ReadUInt32();
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
          case 40: {
            Unk3300NGBKNDHJPCP = input.ReadBool();
            break;
          }
          case 72: {
            Unk3300AKMPCDIKBJD = input.ReadBool();
            break;
          }
          case 88: {
            Unk3300PHEIMLOKIJG = input.ReadUInt32();
            break;
          }
          case 96: {
            Unk3300ONKPGFOLDFL = input.ReadUInt32();
            break;
          }
          case 104: {
            ChallengeModeDifficulty = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300MHOIIPJKAMN = input.ReadUInt32();
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
