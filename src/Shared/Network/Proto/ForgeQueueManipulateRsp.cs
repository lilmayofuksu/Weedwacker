// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ForgeQueueManipulateRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ForgeQueueManipulateRsp.proto</summary>
  public static partial class ForgeQueueManipulateRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ForgeQueueManipulateRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ForgeQueueManipulateRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Gb3JnZVF1ZXVlTWFuaXB1bGF0ZVJzcC5wcm90bxIfV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90bxoeRm9yZ2VRdWV1ZU1hbmlwdWxhdGVUeXBl",
            "LnByb3RvGg9JdGVtUGFyYW0ucHJvdG8i3AIKF0ZvcmdlUXVldWVNYW5pcHVs",
            "YXRlUnNwEkoKFmV4dHJhX291dHB1dF9pdGVtX2xpc3QYAyADKAsyKi5XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkl0ZW1QYXJhbRJSCg9tYW5p",
            "cHVsYXRlX3R5cGUYDCABKA4yOS5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3Jr",
            "LlByb3RvLkZvcmdlUXVldWVNYW5pcHVsYXRlVHlwZRJHChNVbmszMzAwX0pE",
            "SEZQQ0JPR0ZIGAQgAygLMiouV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90by5JdGVtUGFyYW0SRwoTVW5rMzMwMF9FT0xESkFNSERITRgOIAMoCzIq",
            "LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uSXRlbVBhcmFtEg8K",
            "B3JldGNvZGUYCyABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ForgeQueueManipulateTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ForgeQueueManipulateRsp), global::Weedwacker.Shared.Network.Proto.ForgeQueueManipulateRsp.Parser, new[]{ "ExtraOutputItemList", "ManipulateType", "Unk3300JDHFPCBOGFH", "Unk3300EOLDJAMHDHM", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 682;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class ForgeQueueManipulateRsp : pb::IMessage<ForgeQueueManipulateRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ForgeQueueManipulateRsp> _parser = new pb::MessageParser<ForgeQueueManipulateRsp>(() => new ForgeQueueManipulateRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ForgeQueueManipulateRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ForgeQueueManipulateRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeQueueManipulateRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeQueueManipulateRsp(ForgeQueueManipulateRsp other) : this() {
      extraOutputItemList_ = other.extraOutputItemList_.Clone();
      manipulateType_ = other.manipulateType_;
      unk3300JDHFPCBOGFH_ = other.unk3300JDHFPCBOGFH_.Clone();
      unk3300EOLDJAMHDHM_ = other.unk3300EOLDJAMHDHM_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForgeQueueManipulateRsp Clone() {
      return new ForgeQueueManipulateRsp(this);
    }

    /// <summary>Field number for the "extra_output_item_list" field.</summary>
    public const int ExtraOutputItemListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_extraOutputItemList_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> extraOutputItemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> ExtraOutputItemList {
      get { return extraOutputItemList_; }
    }

    /// <summary>Field number for the "manipulate_type" field.</summary>
    public const int ManipulateTypeFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.ForgeQueueManipulateType manipulateType_ = global::Weedwacker.Shared.Network.Proto.ForgeQueueManipulateType.ReceiveOutput;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ForgeQueueManipulateType ManipulateType {
      get { return manipulateType_; }
      set {
        manipulateType_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_JDHFPCBOGFH" field.</summary>
    public const int Unk3300JDHFPCBOGFHFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_unk3300JDHFPCBOGFH_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> unk3300JDHFPCBOGFH_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> Unk3300JDHFPCBOGFH {
      get { return unk3300JDHFPCBOGFH_; }
    }

    /// <summary>Field number for the "Unk3300_EOLDJAMHDHM" field.</summary>
    public const int Unk3300EOLDJAMHDHMFieldNumber = 14;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_unk3300EOLDJAMHDHM_codec
        = pb::FieldCodec.ForMessage(114, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> unk3300EOLDJAMHDHM_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> Unk3300EOLDJAMHDHM {
      get { return unk3300EOLDJAMHDHM_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ForgeQueueManipulateRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ForgeQueueManipulateRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!extraOutputItemList_.Equals(other.extraOutputItemList_)) return false;
      if (ManipulateType != other.ManipulateType) return false;
      if(!unk3300JDHFPCBOGFH_.Equals(other.unk3300JDHFPCBOGFH_)) return false;
      if(!unk3300EOLDJAMHDHM_.Equals(other.unk3300EOLDJAMHDHM_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= extraOutputItemList_.GetHashCode();
      if (ManipulateType != global::Weedwacker.Shared.Network.Proto.ForgeQueueManipulateType.ReceiveOutput) hash ^= ManipulateType.GetHashCode();
      hash ^= unk3300JDHFPCBOGFH_.GetHashCode();
      hash ^= unk3300EOLDJAMHDHM_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      extraOutputItemList_.WriteTo(output, _repeated_extraOutputItemList_codec);
      unk3300JDHFPCBOGFH_.WriteTo(output, _repeated_unk3300JDHFPCBOGFH_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
      }
      if (ManipulateType != global::Weedwacker.Shared.Network.Proto.ForgeQueueManipulateType.ReceiveOutput) {
        output.WriteRawTag(96);
        output.WriteEnum((int) ManipulateType);
      }
      unk3300EOLDJAMHDHM_.WriteTo(output, _repeated_unk3300EOLDJAMHDHM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      extraOutputItemList_.WriteTo(ref output, _repeated_extraOutputItemList_codec);
      unk3300JDHFPCBOGFH_.WriteTo(ref output, _repeated_unk3300JDHFPCBOGFH_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
      }
      if (ManipulateType != global::Weedwacker.Shared.Network.Proto.ForgeQueueManipulateType.ReceiveOutput) {
        output.WriteRawTag(96);
        output.WriteEnum((int) ManipulateType);
      }
      unk3300EOLDJAMHDHM_.WriteTo(ref output, _repeated_unk3300EOLDJAMHDHM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += extraOutputItemList_.CalculateSize(_repeated_extraOutputItemList_codec);
      if (ManipulateType != global::Weedwacker.Shared.Network.Proto.ForgeQueueManipulateType.ReceiveOutput) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ManipulateType);
      }
      size += unk3300JDHFPCBOGFH_.CalculateSize(_repeated_unk3300JDHFPCBOGFH_codec);
      size += unk3300EOLDJAMHDHM_.CalculateSize(_repeated_unk3300EOLDJAMHDHM_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ForgeQueueManipulateRsp other) {
      if (other == null) {
        return;
      }
      extraOutputItemList_.Add(other.extraOutputItemList_);
      if (other.ManipulateType != global::Weedwacker.Shared.Network.Proto.ForgeQueueManipulateType.ReceiveOutput) {
        ManipulateType = other.ManipulateType;
      }
      unk3300JDHFPCBOGFH_.Add(other.unk3300JDHFPCBOGFH_);
      unk3300EOLDJAMHDHM_.Add(other.unk3300EOLDJAMHDHM_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 26: {
            extraOutputItemList_.AddEntriesFrom(input, _repeated_extraOutputItemList_codec);
            break;
          }
          case 34: {
            unk3300JDHFPCBOGFH_.AddEntriesFrom(input, _repeated_unk3300JDHFPCBOGFH_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            ManipulateType = (global::Weedwacker.Shared.Network.Proto.ForgeQueueManipulateType) input.ReadEnum();
            break;
          }
          case 114: {
            unk3300EOLDJAMHDHM_.AddEntriesFrom(input, _repeated_unk3300EOLDJAMHDHM_codec);
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
          case 26: {
            extraOutputItemList_.AddEntriesFrom(ref input, _repeated_extraOutputItemList_codec);
            break;
          }
          case 34: {
            unk3300JDHFPCBOGFH_.AddEntriesFrom(ref input, _repeated_unk3300JDHFPCBOGFH_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            ManipulateType = (global::Weedwacker.Shared.Network.Proto.ForgeQueueManipulateType) input.ReadEnum();
            break;
          }
          case 114: {
            unk3300EOLDJAMHDHM_.AddEntriesFrom(ref input, _repeated_unk3300EOLDJAMHDHM_codec);
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
