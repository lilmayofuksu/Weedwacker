// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FungusFighterTrainingInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FungusFighterTrainingInfoNotify.proto</summary>
  public static partial class FungusFighterTrainingInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for FungusFighterTrainingInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FungusFighterTrainingInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVGdW5ndXNGaWdodGVyVHJhaW5pbmdJbmZvTm90aWZ5LnByb3RvEh9XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvIt4BCh9GdW5ndXNGaWdodGVy",
            "VHJhaW5pbmdJbmZvTm90aWZ5Eg8KB2J1ZmZfaWQYDiABKA0SGwoTVW5rMzMw",
            "MF9JT0VFTENBTURDSxgKIAEoDRIbChNVbmszMzAwX0hHUEdOQ01OREpOGAQg",
            "ASgNEhsKE1VuazMzMDBfRURIQU5FR05NSk0YAyABKA0SGwoTVW5rMzMwMF9H",
            "TUxJUEZETURPRxgGIAEoDRIbChNVbmszMzAwX0VLQU1DUE5HQ0dIGA0gASgN",
            "EhkKEW1heF9tb25zdGVyX2NvdW50GAkgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FungusFighterTrainingInfoNotify), global::Weedwacker.Shared.Network.Proto.FungusFighterTrainingInfoNotify.Parser, new[]{ "BuffId", "Unk3300IOEELCAMDCK", "Unk3300HGPGNCMNDJN", "Unk3300EDHANEGNMJM", "Unk3300GMLIPFDMDOG", "Unk3300EKAMCPNGCGH", "MaxMonsterCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 5533;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class FungusFighterTrainingInfoNotify : pb::IMessage<FungusFighterTrainingInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FungusFighterTrainingInfoNotify> _parser = new pb::MessageParser<FungusFighterTrainingInfoNotify>(() => new FungusFighterTrainingInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FungusFighterTrainingInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FungusFighterTrainingInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusFighterTrainingInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusFighterTrainingInfoNotify(FungusFighterTrainingInfoNotify other) : this() {
      buffId_ = other.buffId_;
      unk3300IOEELCAMDCK_ = other.unk3300IOEELCAMDCK_;
      unk3300HGPGNCMNDJN_ = other.unk3300HGPGNCMNDJN_;
      unk3300EDHANEGNMJM_ = other.unk3300EDHANEGNMJM_;
      unk3300GMLIPFDMDOG_ = other.unk3300GMLIPFDMDOG_;
      unk3300EKAMCPNGCGH_ = other.unk3300EKAMCPNGCGH_;
      maxMonsterCount_ = other.maxMonsterCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusFighterTrainingInfoNotify Clone() {
      return new FungusFighterTrainingInfoNotify(this);
    }

    /// <summary>Field number for the "buff_id" field.</summary>
    public const int BuffIdFieldNumber = 14;
    private uint buffId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuffId {
      get { return buffId_; }
      set {
        buffId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_IOEELCAMDCK" field.</summary>
    public const int Unk3300IOEELCAMDCKFieldNumber = 10;
    private uint unk3300IOEELCAMDCK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300IOEELCAMDCK {
      get { return unk3300IOEELCAMDCK_; }
      set {
        unk3300IOEELCAMDCK_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HGPGNCMNDJN" field.</summary>
    public const int Unk3300HGPGNCMNDJNFieldNumber = 4;
    private uint unk3300HGPGNCMNDJN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300HGPGNCMNDJN {
      get { return unk3300HGPGNCMNDJN_; }
      set {
        unk3300HGPGNCMNDJN_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_EDHANEGNMJM" field.</summary>
    public const int Unk3300EDHANEGNMJMFieldNumber = 3;
    private uint unk3300EDHANEGNMJM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300EDHANEGNMJM {
      get { return unk3300EDHANEGNMJM_; }
      set {
        unk3300EDHANEGNMJM_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_GMLIPFDMDOG" field.</summary>
    public const int Unk3300GMLIPFDMDOGFieldNumber = 6;
    private uint unk3300GMLIPFDMDOG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300GMLIPFDMDOG {
      get { return unk3300GMLIPFDMDOG_; }
      set {
        unk3300GMLIPFDMDOG_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_EKAMCPNGCGH" field.</summary>
    public const int Unk3300EKAMCPNGCGHFieldNumber = 13;
    private uint unk3300EKAMCPNGCGH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300EKAMCPNGCGH {
      get { return unk3300EKAMCPNGCGH_; }
      set {
        unk3300EKAMCPNGCGH_ = value;
      }
    }

    /// <summary>Field number for the "max_monster_count" field.</summary>
    public const int MaxMonsterCountFieldNumber = 9;
    private uint maxMonsterCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxMonsterCount {
      get { return maxMonsterCount_; }
      set {
        maxMonsterCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FungusFighterTrainingInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FungusFighterTrainingInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BuffId != other.BuffId) return false;
      if (Unk3300IOEELCAMDCK != other.Unk3300IOEELCAMDCK) return false;
      if (Unk3300HGPGNCMNDJN != other.Unk3300HGPGNCMNDJN) return false;
      if (Unk3300EDHANEGNMJM != other.Unk3300EDHANEGNMJM) return false;
      if (Unk3300GMLIPFDMDOG != other.Unk3300GMLIPFDMDOG) return false;
      if (Unk3300EKAMCPNGCGH != other.Unk3300EKAMCPNGCGH) return false;
      if (MaxMonsterCount != other.MaxMonsterCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BuffId != 0) hash ^= BuffId.GetHashCode();
      if (Unk3300IOEELCAMDCK != 0) hash ^= Unk3300IOEELCAMDCK.GetHashCode();
      if (Unk3300HGPGNCMNDJN != 0) hash ^= Unk3300HGPGNCMNDJN.GetHashCode();
      if (Unk3300EDHANEGNMJM != 0) hash ^= Unk3300EDHANEGNMJM.GetHashCode();
      if (Unk3300GMLIPFDMDOG != 0) hash ^= Unk3300GMLIPFDMDOG.GetHashCode();
      if (Unk3300EKAMCPNGCGH != 0) hash ^= Unk3300EKAMCPNGCGH.GetHashCode();
      if (MaxMonsterCount != 0) hash ^= MaxMonsterCount.GetHashCode();
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
      if (Unk3300EDHANEGNMJM != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3300EDHANEGNMJM);
      }
      if (Unk3300HGPGNCMNDJN != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300HGPGNCMNDJN);
      }
      if (Unk3300GMLIPFDMDOG != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300GMLIPFDMDOG);
      }
      if (MaxMonsterCount != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MaxMonsterCount);
      }
      if (Unk3300IOEELCAMDCK != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300IOEELCAMDCK);
      }
      if (Unk3300EKAMCPNGCGH != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300EKAMCPNGCGH);
      }
      if (BuffId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(BuffId);
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
      if (Unk3300EDHANEGNMJM != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3300EDHANEGNMJM);
      }
      if (Unk3300HGPGNCMNDJN != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300HGPGNCMNDJN);
      }
      if (Unk3300GMLIPFDMDOG != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300GMLIPFDMDOG);
      }
      if (MaxMonsterCount != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(MaxMonsterCount);
      }
      if (Unk3300IOEELCAMDCK != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300IOEELCAMDCK);
      }
      if (Unk3300EKAMCPNGCGH != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300EKAMCPNGCGH);
      }
      if (BuffId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(BuffId);
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
      if (BuffId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuffId);
      }
      if (Unk3300IOEELCAMDCK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300IOEELCAMDCK);
      }
      if (Unk3300HGPGNCMNDJN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300HGPGNCMNDJN);
      }
      if (Unk3300EDHANEGNMJM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300EDHANEGNMJM);
      }
      if (Unk3300GMLIPFDMDOG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300GMLIPFDMDOG);
      }
      if (Unk3300EKAMCPNGCGH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300EKAMCPNGCGH);
      }
      if (MaxMonsterCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxMonsterCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FungusFighterTrainingInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.BuffId != 0) {
        BuffId = other.BuffId;
      }
      if (other.Unk3300IOEELCAMDCK != 0) {
        Unk3300IOEELCAMDCK = other.Unk3300IOEELCAMDCK;
      }
      if (other.Unk3300HGPGNCMNDJN != 0) {
        Unk3300HGPGNCMNDJN = other.Unk3300HGPGNCMNDJN;
      }
      if (other.Unk3300EDHANEGNMJM != 0) {
        Unk3300EDHANEGNMJM = other.Unk3300EDHANEGNMJM;
      }
      if (other.Unk3300GMLIPFDMDOG != 0) {
        Unk3300GMLIPFDMDOG = other.Unk3300GMLIPFDMDOG;
      }
      if (other.Unk3300EKAMCPNGCGH != 0) {
        Unk3300EKAMCPNGCGH = other.Unk3300EKAMCPNGCGH;
      }
      if (other.MaxMonsterCount != 0) {
        MaxMonsterCount = other.MaxMonsterCount;
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
          case 24: {
            Unk3300EDHANEGNMJM = input.ReadUInt32();
            break;
          }
          case 32: {
            Unk3300HGPGNCMNDJN = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300GMLIPFDMDOG = input.ReadUInt32();
            break;
          }
          case 72: {
            MaxMonsterCount = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300IOEELCAMDCK = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300EKAMCPNGCGH = input.ReadUInt32();
            break;
          }
          case 112: {
            BuffId = input.ReadUInt32();
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
          case 24: {
            Unk3300EDHANEGNMJM = input.ReadUInt32();
            break;
          }
          case 32: {
            Unk3300HGPGNCMNDJN = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300GMLIPFDMDOG = input.ReadUInt32();
            break;
          }
          case 72: {
            MaxMonsterCount = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300IOEELCAMDCK = input.ReadUInt32();
            break;
          }
          case 104: {
            Unk3300EKAMCPNGCGH = input.ReadUInt32();
            break;
          }
          case 112: {
            BuffId = input.ReadUInt32();
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
