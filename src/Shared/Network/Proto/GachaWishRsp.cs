// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GachaWishRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GachaWishRsp.proto</summary>
  public static partial class GachaWishRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GachaWishRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GachaWishRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJHYWNoYVdpc2hSc3AucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdv",
            "cmsuUHJvdG8ipQEKDEdhY2hhV2lzaFJzcBIbChNVbmszMzAwX05NT0tHRkdE",
            "RkZDGAYgASgNEhsKE1VuazMzMDBfS0VJSkZNS0FLREgYDyABKA0SGQoRZ2Fj",
            "aGFfc2NoZWR1bGVfaWQYCyABKA0SDwoHcmV0Y29kZRgNIAEoBRIbChNVbmsz",
            "MzAwX0JMTE1QQUpOQ1BJGAogASgNEhIKCmdhY2hhX3R5cGUYCCABKA1iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GachaWishRsp), global::Weedwacker.Shared.Network.Proto.GachaWishRsp.Parser, new[]{ "Unk3300NMOKGFGDFFC", "Unk3300KEIJFMKAKDH", "GachaScheduleId", "Retcode", "Unk3300BLLMPAJNCPI", "GachaType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1543;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GachaWishRsp : pb::IMessage<GachaWishRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GachaWishRsp> _parser = new pb::MessageParser<GachaWishRsp>(() => new GachaWishRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GachaWishRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GachaWishRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaWishRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaWishRsp(GachaWishRsp other) : this() {
      unk3300NMOKGFGDFFC_ = other.unk3300NMOKGFGDFFC_;
      unk3300KEIJFMKAKDH_ = other.unk3300KEIJFMKAKDH_;
      gachaScheduleId_ = other.gachaScheduleId_;
      retcode_ = other.retcode_;
      unk3300BLLMPAJNCPI_ = other.unk3300BLLMPAJNCPI_;
      gachaType_ = other.gachaType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaWishRsp Clone() {
      return new GachaWishRsp(this);
    }

    /// <summary>Field number for the "Unk3300_NMOKGFGDFFC" field.</summary>
    public const int Unk3300NMOKGFGDFFCFieldNumber = 6;
    private uint unk3300NMOKGFGDFFC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300NMOKGFGDFFC {
      get { return unk3300NMOKGFGDFFC_; }
      set {
        unk3300NMOKGFGDFFC_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KEIJFMKAKDH" field.</summary>
    public const int Unk3300KEIJFMKAKDHFieldNumber = 15;
    private uint unk3300KEIJFMKAKDH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300KEIJFMKAKDH {
      get { return unk3300KEIJFMKAKDH_; }
      set {
        unk3300KEIJFMKAKDH_ = value;
      }
    }

    /// <summary>Field number for the "gacha_schedule_id" field.</summary>
    public const int GachaScheduleIdFieldNumber = 11;
    private uint gachaScheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GachaScheduleId {
      get { return gachaScheduleId_; }
      set {
        gachaScheduleId_ = value;
      }
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

    /// <summary>Field number for the "Unk3300_BLLMPAJNCPI" field.</summary>
    public const int Unk3300BLLMPAJNCPIFieldNumber = 10;
    private uint unk3300BLLMPAJNCPI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300BLLMPAJNCPI {
      get { return unk3300BLLMPAJNCPI_; }
      set {
        unk3300BLLMPAJNCPI_ = value;
      }
    }

    /// <summary>Field number for the "gacha_type" field.</summary>
    public const int GachaTypeFieldNumber = 8;
    private uint gachaType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GachaType {
      get { return gachaType_; }
      set {
        gachaType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GachaWishRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GachaWishRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300NMOKGFGDFFC != other.Unk3300NMOKGFGDFFC) return false;
      if (Unk3300KEIJFMKAKDH != other.Unk3300KEIJFMKAKDH) return false;
      if (GachaScheduleId != other.GachaScheduleId) return false;
      if (Retcode != other.Retcode) return false;
      if (Unk3300BLLMPAJNCPI != other.Unk3300BLLMPAJNCPI) return false;
      if (GachaType != other.GachaType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300NMOKGFGDFFC != 0) hash ^= Unk3300NMOKGFGDFFC.GetHashCode();
      if (Unk3300KEIJFMKAKDH != 0) hash ^= Unk3300KEIJFMKAKDH.GetHashCode();
      if (GachaScheduleId != 0) hash ^= GachaScheduleId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Unk3300BLLMPAJNCPI != 0) hash ^= Unk3300BLLMPAJNCPI.GetHashCode();
      if (GachaType != 0) hash ^= GachaType.GetHashCode();
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
      if (Unk3300NMOKGFGDFFC != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300NMOKGFGDFFC);
      }
      if (GachaType != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(GachaType);
      }
      if (Unk3300BLLMPAJNCPI != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300BLLMPAJNCPI);
      }
      if (GachaScheduleId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GachaScheduleId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Retcode);
      }
      if (Unk3300KEIJFMKAKDH != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300KEIJFMKAKDH);
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
      if (Unk3300NMOKGFGDFFC != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300NMOKGFGDFFC);
      }
      if (GachaType != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(GachaType);
      }
      if (Unk3300BLLMPAJNCPI != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300BLLMPAJNCPI);
      }
      if (GachaScheduleId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GachaScheduleId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Retcode);
      }
      if (Unk3300KEIJFMKAKDH != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300KEIJFMKAKDH);
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
      if (Unk3300NMOKGFGDFFC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300NMOKGFGDFFC);
      }
      if (Unk3300KEIJFMKAKDH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300KEIJFMKAKDH);
      }
      if (GachaScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaScheduleId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (Unk3300BLLMPAJNCPI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300BLLMPAJNCPI);
      }
      if (GachaType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GachaWishRsp other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300NMOKGFGDFFC != 0) {
        Unk3300NMOKGFGDFFC = other.Unk3300NMOKGFGDFFC;
      }
      if (other.Unk3300KEIJFMKAKDH != 0) {
        Unk3300KEIJFMKAKDH = other.Unk3300KEIJFMKAKDH;
      }
      if (other.GachaScheduleId != 0) {
        GachaScheduleId = other.GachaScheduleId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Unk3300BLLMPAJNCPI != 0) {
        Unk3300BLLMPAJNCPI = other.Unk3300BLLMPAJNCPI;
      }
      if (other.GachaType != 0) {
        GachaType = other.GachaType;
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
          case 48: {
            Unk3300NMOKGFGDFFC = input.ReadUInt32();
            break;
          }
          case 64: {
            GachaType = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300BLLMPAJNCPI = input.ReadUInt32();
            break;
          }
          case 88: {
            GachaScheduleId = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadInt32();
            break;
          }
          case 120: {
            Unk3300KEIJFMKAKDH = input.ReadUInt32();
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
          case 48: {
            Unk3300NMOKGFGDFFC = input.ReadUInt32();
            break;
          }
          case 64: {
            GachaType = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300BLLMPAJNCPI = input.ReadUInt32();
            break;
          }
          case 88: {
            GachaScheduleId = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadInt32();
            break;
          }
          case 120: {
            Unk3300KEIJFMKAKDH = input.ReadUInt32();
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
