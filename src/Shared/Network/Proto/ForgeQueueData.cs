// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ForgeQueueData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ForgeQueueData.proto</summary>
  public static partial class ForgeQueueDataReflection {

    #region Descriptor
    /// <summary>File descriptor for ForgeQueueData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ForgeQueueDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRGb3JnZVF1ZXVlRGF0YS5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90byLGAQoORm9yZ2VRdWV1ZURhdGESGwoTVW5rMzMwMF9LRElQ",
            "TE5CSEdESBgBIAEoDRIQCghmb3JnZV9pZBgFIAEoDRIbChNVbmszMzAwX0dK",
            "RUVDSEtERUJEGAcgASgNEhsKE1VuazMzMDBfT09PSk5BQkdIT00YBCABKA0S",
            "GwoTVW5rMzMwMF9QSkNLRk5OSU1OTRgPIAEoDRIRCglhdmF0YXJfaWQYDCAB",
            "KA0SGwoTVW5rMzMwMF9QSktIUENJTUFJRBgDIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ForgeQueueData), global::Weedwacker.Shared.Network.Proto.ForgeQueueData.Parser, new[]{ "Unk3300KDIPLNBHGDH", "ForgeId", "Unk3300GJEECHKDEBD", "Unk3300OOOJNABGHOM", "Unk3300PJCKFNNIMNM", "AvatarId", "Unk3300PJKHPCIMAID" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ForgeQueueData : pb::IMessage<ForgeQueueData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ForgeQueueData> _parser = new pb::MessageParser<ForgeQueueData>(() => new ForgeQueueData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ForgeQueueData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ForgeQueueDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeQueueData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeQueueData(ForgeQueueData other) : this() {
      unk3300KDIPLNBHGDH_ = other.unk3300KDIPLNBHGDH_;
      forgeId_ = other.forgeId_;
      unk3300GJEECHKDEBD_ = other.unk3300GJEECHKDEBD_;
      unk3300OOOJNABGHOM_ = other.unk3300OOOJNABGHOM_;
      unk3300PJCKFNNIMNM_ = other.unk3300PJCKFNNIMNM_;
      avatarId_ = other.avatarId_;
      unk3300PJKHPCIMAID_ = other.unk3300PJKHPCIMAID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeQueueData Clone() {
      return new ForgeQueueData(this);
    }

    /// <summary>Field number for the "Unk3300_KDIPLNBHGDH" field.</summary>
    public const int Unk3300KDIPLNBHGDHFieldNumber = 1;
    private uint unk3300KDIPLNBHGDH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300KDIPLNBHGDH {
      get { return unk3300KDIPLNBHGDH_; }
      set {
        unk3300KDIPLNBHGDH_ = value;
      }
    }

    /// <summary>Field number for the "forge_id" field.</summary>
    public const int ForgeIdFieldNumber = 5;
    private uint forgeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ForgeId {
      get { return forgeId_; }
      set {
        forgeId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_GJEECHKDEBD" field.</summary>
    public const int Unk3300GJEECHKDEBDFieldNumber = 7;
    private uint unk3300GJEECHKDEBD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300GJEECHKDEBD {
      get { return unk3300GJEECHKDEBD_; }
      set {
        unk3300GJEECHKDEBD_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_OOOJNABGHOM" field.</summary>
    public const int Unk3300OOOJNABGHOMFieldNumber = 4;
    private uint unk3300OOOJNABGHOM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300OOOJNABGHOM {
      get { return unk3300OOOJNABGHOM_; }
      set {
        unk3300OOOJNABGHOM_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_PJCKFNNIMNM" field.</summary>
    public const int Unk3300PJCKFNNIMNMFieldNumber = 15;
    private uint unk3300PJCKFNNIMNM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300PJCKFNNIMNM {
      get { return unk3300PJCKFNNIMNM_; }
      set {
        unk3300PJCKFNNIMNM_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 12;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_PJKHPCIMAID" field.</summary>
    public const int Unk3300PJKHPCIMAIDFieldNumber = 3;
    private uint unk3300PJKHPCIMAID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300PJKHPCIMAID {
      get { return unk3300PJKHPCIMAID_; }
      set {
        unk3300PJKHPCIMAID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ForgeQueueData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ForgeQueueData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300KDIPLNBHGDH != other.Unk3300KDIPLNBHGDH) return false;
      if (ForgeId != other.ForgeId) return false;
      if (Unk3300GJEECHKDEBD != other.Unk3300GJEECHKDEBD) return false;
      if (Unk3300OOOJNABGHOM != other.Unk3300OOOJNABGHOM) return false;
      if (Unk3300PJCKFNNIMNM != other.Unk3300PJCKFNNIMNM) return false;
      if (AvatarId != other.AvatarId) return false;
      if (Unk3300PJKHPCIMAID != other.Unk3300PJKHPCIMAID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300KDIPLNBHGDH != 0) hash ^= Unk3300KDIPLNBHGDH.GetHashCode();
      if (ForgeId != 0) hash ^= ForgeId.GetHashCode();
      if (Unk3300GJEECHKDEBD != 0) hash ^= Unk3300GJEECHKDEBD.GetHashCode();
      if (Unk3300OOOJNABGHOM != 0) hash ^= Unk3300OOOJNABGHOM.GetHashCode();
      if (Unk3300PJCKFNNIMNM != 0) hash ^= Unk3300PJCKFNNIMNM.GetHashCode();
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      if (Unk3300PJKHPCIMAID != 0) hash ^= Unk3300PJKHPCIMAID.GetHashCode();
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
      if (Unk3300KDIPLNBHGDH != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300KDIPLNBHGDH);
      }
      if (Unk3300PJKHPCIMAID != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3300PJKHPCIMAID);
      }
      if (Unk3300OOOJNABGHOM != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300OOOJNABGHOM);
      }
      if (ForgeId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ForgeId);
      }
      if (Unk3300GJEECHKDEBD != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300GJEECHKDEBD);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(AvatarId);
      }
      if (Unk3300PJCKFNNIMNM != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300PJCKFNNIMNM);
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
      if (Unk3300KDIPLNBHGDH != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300KDIPLNBHGDH);
      }
      if (Unk3300PJKHPCIMAID != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3300PJKHPCIMAID);
      }
      if (Unk3300OOOJNABGHOM != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300OOOJNABGHOM);
      }
      if (ForgeId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ForgeId);
      }
      if (Unk3300GJEECHKDEBD != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300GJEECHKDEBD);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(AvatarId);
      }
      if (Unk3300PJCKFNNIMNM != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300PJCKFNNIMNM);
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
      if (Unk3300KDIPLNBHGDH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300KDIPLNBHGDH);
      }
      if (ForgeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ForgeId);
      }
      if (Unk3300GJEECHKDEBD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300GJEECHKDEBD);
      }
      if (Unk3300OOOJNABGHOM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300OOOJNABGHOM);
      }
      if (Unk3300PJCKFNNIMNM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300PJCKFNNIMNM);
      }
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      if (Unk3300PJKHPCIMAID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300PJKHPCIMAID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ForgeQueueData other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300KDIPLNBHGDH != 0) {
        Unk3300KDIPLNBHGDH = other.Unk3300KDIPLNBHGDH;
      }
      if (other.ForgeId != 0) {
        ForgeId = other.ForgeId;
      }
      if (other.Unk3300GJEECHKDEBD != 0) {
        Unk3300GJEECHKDEBD = other.Unk3300GJEECHKDEBD;
      }
      if (other.Unk3300OOOJNABGHOM != 0) {
        Unk3300OOOJNABGHOM = other.Unk3300OOOJNABGHOM;
      }
      if (other.Unk3300PJCKFNNIMNM != 0) {
        Unk3300PJCKFNNIMNM = other.Unk3300PJCKFNNIMNM;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      if (other.Unk3300PJKHPCIMAID != 0) {
        Unk3300PJKHPCIMAID = other.Unk3300PJKHPCIMAID;
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
            Unk3300KDIPLNBHGDH = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk3300PJKHPCIMAID = input.ReadUInt32();
            break;
          }
          case 32: {
            Unk3300OOOJNABGHOM = input.ReadUInt32();
            break;
          }
          case 40: {
            ForgeId = input.ReadUInt32();
            break;
          }
          case 56: {
            Unk3300GJEECHKDEBD = input.ReadUInt32();
            break;
          }
          case 96: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk3300PJCKFNNIMNM = input.ReadUInt32();
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
            Unk3300KDIPLNBHGDH = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk3300PJKHPCIMAID = input.ReadUInt32();
            break;
          }
          case 32: {
            Unk3300OOOJNABGHOM = input.ReadUInt32();
            break;
          }
          case 40: {
            ForgeId = input.ReadUInt32();
            break;
          }
          case 56: {
            Unk3300GJEECHKDEBD = input.ReadUInt32();
            break;
          }
          case 96: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk3300PJCKFNNIMNM = input.ReadUInt32();
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
