// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TriggerRoguelikeCurseNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from TriggerRoguelikeCurseNotify.proto</summary>
  public static partial class TriggerRoguelikeCurseNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for TriggerRoguelikeCurseNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TriggerRoguelikeCurseNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFUcmlnZ2VyUm9ndWVsaWtlQ3Vyc2VOb3RpZnkucHJvdG8SH1dlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8ijAEKG1RyaWdnZXJSb2d1ZWxpa2VD",
            "dXJzZU5vdGlmeRIbChNVbmszMzAwX1BPTElFTkJDTkxGGAcgASgNEhsKE1Vu",
            "azMzMDBfTEpISklCRFBCQkMYCiABKA0SGAoQaXNfdHJpZ2dlcl9jdXJzZRgL",
            "IAEoCBIZChFlZmZlY3RfcGFyYW1fbGlzdBgJIAMoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.TriggerRoguelikeCurseNotify), global::Weedwacker.Shared.Network.Proto.TriggerRoguelikeCurseNotify.Parser, new[]{ "Unk3300POLIENBCNLF", "Unk3300LJHJIBDPBBC", "IsTriggerCurse", "EffectParamList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8965;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class TriggerRoguelikeCurseNotify : pb::IMessage<TriggerRoguelikeCurseNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TriggerRoguelikeCurseNotify> _parser = new pb::MessageParser<TriggerRoguelikeCurseNotify>(() => new TriggerRoguelikeCurseNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TriggerRoguelikeCurseNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.TriggerRoguelikeCurseNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TriggerRoguelikeCurseNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TriggerRoguelikeCurseNotify(TriggerRoguelikeCurseNotify other) : this() {
      unk3300POLIENBCNLF_ = other.unk3300POLIENBCNLF_;
      unk3300LJHJIBDPBBC_ = other.unk3300LJHJIBDPBBC_;
      isTriggerCurse_ = other.isTriggerCurse_;
      effectParamList_ = other.effectParamList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TriggerRoguelikeCurseNotify Clone() {
      return new TriggerRoguelikeCurseNotify(this);
    }

    /// <summary>Field number for the "Unk3300_POLIENBCNLF" field.</summary>
    public const int Unk3300POLIENBCNLFFieldNumber = 7;
    private uint unk3300POLIENBCNLF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300POLIENBCNLF {
      get { return unk3300POLIENBCNLF_; }
      set {
        unk3300POLIENBCNLF_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_LJHJIBDPBBC" field.</summary>
    public const int Unk3300LJHJIBDPBBCFieldNumber = 10;
    private uint unk3300LJHJIBDPBBC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300LJHJIBDPBBC {
      get { return unk3300LJHJIBDPBBC_; }
      set {
        unk3300LJHJIBDPBBC_ = value;
      }
    }

    /// <summary>Field number for the "is_trigger_curse" field.</summary>
    public const int IsTriggerCurseFieldNumber = 11;
    private bool isTriggerCurse_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTriggerCurse {
      get { return isTriggerCurse_; }
      set {
        isTriggerCurse_ = value;
      }
    }

    /// <summary>Field number for the "effect_param_list" field.</summary>
    public const int EffectParamListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_effectParamList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> effectParamList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EffectParamList {
      get { return effectParamList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TriggerRoguelikeCurseNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TriggerRoguelikeCurseNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300POLIENBCNLF != other.Unk3300POLIENBCNLF) return false;
      if (Unk3300LJHJIBDPBBC != other.Unk3300LJHJIBDPBBC) return false;
      if (IsTriggerCurse != other.IsTriggerCurse) return false;
      if(!effectParamList_.Equals(other.effectParamList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300POLIENBCNLF != 0) hash ^= Unk3300POLIENBCNLF.GetHashCode();
      if (Unk3300LJHJIBDPBBC != 0) hash ^= Unk3300LJHJIBDPBBC.GetHashCode();
      if (IsTriggerCurse != false) hash ^= IsTriggerCurse.GetHashCode();
      hash ^= effectParamList_.GetHashCode();
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
      if (Unk3300POLIENBCNLF != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300POLIENBCNLF);
      }
      effectParamList_.WriteTo(output, _repeated_effectParamList_codec);
      if (Unk3300LJHJIBDPBBC != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300LJHJIBDPBBC);
      }
      if (IsTriggerCurse != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsTriggerCurse);
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
      if (Unk3300POLIENBCNLF != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300POLIENBCNLF);
      }
      effectParamList_.WriteTo(ref output, _repeated_effectParamList_codec);
      if (Unk3300LJHJIBDPBBC != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300LJHJIBDPBBC);
      }
      if (IsTriggerCurse != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsTriggerCurse);
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
      if (Unk3300POLIENBCNLF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300POLIENBCNLF);
      }
      if (Unk3300LJHJIBDPBBC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LJHJIBDPBBC);
      }
      if (IsTriggerCurse != false) {
        size += 1 + 1;
      }
      size += effectParamList_.CalculateSize(_repeated_effectParamList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TriggerRoguelikeCurseNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300POLIENBCNLF != 0) {
        Unk3300POLIENBCNLF = other.Unk3300POLIENBCNLF;
      }
      if (other.Unk3300LJHJIBDPBBC != 0) {
        Unk3300LJHJIBDPBBC = other.Unk3300LJHJIBDPBBC;
      }
      if (other.IsTriggerCurse != false) {
        IsTriggerCurse = other.IsTriggerCurse;
      }
      effectParamList_.Add(other.effectParamList_);
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
          case 56: {
            Unk3300POLIENBCNLF = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            effectParamList_.AddEntriesFrom(input, _repeated_effectParamList_codec);
            break;
          }
          case 80: {
            Unk3300LJHJIBDPBBC = input.ReadUInt32();
            break;
          }
          case 88: {
            IsTriggerCurse = input.ReadBool();
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
          case 56: {
            Unk3300POLIENBCNLF = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            effectParamList_.AddEntriesFrom(ref input, _repeated_effectParamList_codec);
            break;
          }
          case 80: {
            Unk3300LJHJIBDPBBC = input.ReadUInt32();
            break;
          }
          case 88: {
            IsTriggerCurse = input.ReadBool();
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
