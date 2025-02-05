// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SaveCoopDialogRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SaveCoopDialogRsp.proto</summary>
  public static partial class SaveCoopDialogRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SaveCoopDialogRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SaveCoopDialogRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdTYXZlQ29vcERpYWxvZ1JzcC5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90byJeChFTYXZlQ29vcERpYWxvZ1JzcBIPCgdyZXRjb2Rl",
            "GAUgASgFEhsKE1VuazMzMDBfQU1LRERKRVBBS00YDyABKA0SGwoTVW5rMzMw",
            "MF9LTUJHTklJQ05BRhgJIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SaveCoopDialogRsp), global::Weedwacker.Shared.Network.Proto.SaveCoopDialogRsp.Parser, new[]{ "Retcode", "Unk3300AMKDDJEPAKM", "Unk3300KMBGNIICNAF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1960;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class SaveCoopDialogRsp : pb::IMessage<SaveCoopDialogRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SaveCoopDialogRsp> _parser = new pb::MessageParser<SaveCoopDialogRsp>(() => new SaveCoopDialogRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SaveCoopDialogRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SaveCoopDialogRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SaveCoopDialogRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SaveCoopDialogRsp(SaveCoopDialogRsp other) : this() {
      retcode_ = other.retcode_;
      unk3300AMKDDJEPAKM_ = other.unk3300AMKDDJEPAKM_;
      unk3300KMBGNIICNAF_ = other.unk3300KMBGNIICNAF_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SaveCoopDialogRsp Clone() {
      return new SaveCoopDialogRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_AMKDDJEPAKM" field.</summary>
    public const int Unk3300AMKDDJEPAKMFieldNumber = 15;
    private uint unk3300AMKDDJEPAKM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300AMKDDJEPAKM {
      get { return unk3300AMKDDJEPAKM_; }
      set {
        unk3300AMKDDJEPAKM_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KMBGNIICNAF" field.</summary>
    public const int Unk3300KMBGNIICNAFFieldNumber = 9;
    private uint unk3300KMBGNIICNAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300KMBGNIICNAF {
      get { return unk3300KMBGNIICNAF_; }
      set {
        unk3300KMBGNIICNAF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SaveCoopDialogRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SaveCoopDialogRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (Unk3300AMKDDJEPAKM != other.Unk3300AMKDDJEPAKM) return false;
      if (Unk3300KMBGNIICNAF != other.Unk3300KMBGNIICNAF) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Unk3300AMKDDJEPAKM != 0) hash ^= Unk3300AMKDDJEPAKM.GetHashCode();
      if (Unk3300KMBGNIICNAF != 0) hash ^= Unk3300KMBGNIICNAF.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      if (Unk3300KMBGNIICNAF != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk3300KMBGNIICNAF);
      }
      if (Unk3300AMKDDJEPAKM != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300AMKDDJEPAKM);
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
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      if (Unk3300KMBGNIICNAF != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Unk3300KMBGNIICNAF);
      }
      if (Unk3300AMKDDJEPAKM != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300AMKDDJEPAKM);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (Unk3300AMKDDJEPAKM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300AMKDDJEPAKM);
      }
      if (Unk3300KMBGNIICNAF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300KMBGNIICNAF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SaveCoopDialogRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Unk3300AMKDDJEPAKM != 0) {
        Unk3300AMKDDJEPAKM = other.Unk3300AMKDDJEPAKM;
      }
      if (other.Unk3300KMBGNIICNAF != 0) {
        Unk3300KMBGNIICNAF = other.Unk3300KMBGNIICNAF;
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
            Retcode = input.ReadInt32();
            break;
          }
          case 72: {
            Unk3300KMBGNIICNAF = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk3300AMKDDJEPAKM = input.ReadUInt32();
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
            Retcode = input.ReadInt32();
            break;
          }
          case 72: {
            Unk3300KMBGNIICNAF = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk3300AMKDDJEPAKM = input.ReadUInt32();
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
