// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FungusCultivateReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FungusCultivateReq.proto</summary>
  public static partial class FungusCultivateReqReflection {

    #region Descriptor
    /// <summary>File descriptor for FungusCultivateReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FungusCultivateReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhGdW5ndXNDdWx0aXZhdGVSZXEucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG8i5gEKEkZ1bmd1c0N1bHRpdmF0ZVJlcRIbChNVbmsz",
            "MzAwX0lPQU5MSkJNQkFJGAEgASgNEhsKE1VuazMzMDBfREpFR0pEQUNERUYY",
            "BiABKA0SGwoTVW5rMzMwMF9JTUVHRk5PTERDRRgCIAEoDRIbChNVbmszMzAw",
            "X1BHSktFSUNGS0xMGAUgASgNEhsKE1VuazMzMDBfTUJQTElDQkZBR0wYByAB",
            "KA0SFAoMY3VsdGl2YXRlX2lkGAwgASgNEgwKBHRpbWUYDyABKA0SGwoTVW5r",
            "MzMwMF9BRUdDTkhMT1BFUBgIIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FungusCultivateReq), global::Weedwacker.Shared.Network.Proto.FungusCultivateReq.Parser, new[]{ "Unk3300IOANLJBMBAI", "Unk3300DJEGJDACDEF", "Unk3300IMEGFNOLDCE", "Unk3300PGJKEICFKLL", "Unk3300MBPLICBFAGL", "CultivateId", "Time", "Unk3300AEGCNHLOPEP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 23545;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class FungusCultivateReq : pb::IMessage<FungusCultivateReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FungusCultivateReq> _parser = new pb::MessageParser<FungusCultivateReq>(() => new FungusCultivateReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FungusCultivateReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FungusCultivateReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusCultivateReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusCultivateReq(FungusCultivateReq other) : this() {
      unk3300IOANLJBMBAI_ = other.unk3300IOANLJBMBAI_;
      unk3300DJEGJDACDEF_ = other.unk3300DJEGJDACDEF_;
      unk3300IMEGFNOLDCE_ = other.unk3300IMEGFNOLDCE_;
      unk3300PGJKEICFKLL_ = other.unk3300PGJKEICFKLL_;
      unk3300MBPLICBFAGL_ = other.unk3300MBPLICBFAGL_;
      cultivateId_ = other.cultivateId_;
      time_ = other.time_;
      unk3300AEGCNHLOPEP_ = other.unk3300AEGCNHLOPEP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusCultivateReq Clone() {
      return new FungusCultivateReq(this);
    }

    /// <summary>Field number for the "Unk3300_IOANLJBMBAI" field.</summary>
    public const int Unk3300IOANLJBMBAIFieldNumber = 1;
    private uint unk3300IOANLJBMBAI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300IOANLJBMBAI {
      get { return unk3300IOANLJBMBAI_; }
      set {
        unk3300IOANLJBMBAI_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_DJEGJDACDEF" field.</summary>
    public const int Unk3300DJEGJDACDEFFieldNumber = 6;
    private uint unk3300DJEGJDACDEF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300DJEGJDACDEF {
      get { return unk3300DJEGJDACDEF_; }
      set {
        unk3300DJEGJDACDEF_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_IMEGFNOLDCE" field.</summary>
    public const int Unk3300IMEGFNOLDCEFieldNumber = 2;
    private uint unk3300IMEGFNOLDCE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300IMEGFNOLDCE {
      get { return unk3300IMEGFNOLDCE_; }
      set {
        unk3300IMEGFNOLDCE_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_PGJKEICFKLL" field.</summary>
    public const int Unk3300PGJKEICFKLLFieldNumber = 5;
    private uint unk3300PGJKEICFKLL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300PGJKEICFKLL {
      get { return unk3300PGJKEICFKLL_; }
      set {
        unk3300PGJKEICFKLL_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_MBPLICBFAGL" field.</summary>
    public const int Unk3300MBPLICBFAGLFieldNumber = 7;
    private uint unk3300MBPLICBFAGL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300MBPLICBFAGL {
      get { return unk3300MBPLICBFAGL_; }
      set {
        unk3300MBPLICBFAGL_ = value;
      }
    }

    /// <summary>Field number for the "cultivate_id" field.</summary>
    public const int CultivateIdFieldNumber = 12;
    private uint cultivateId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CultivateId {
      get { return cultivateId_; }
      set {
        cultivateId_ = value;
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 15;
    private uint time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_AEGCNHLOPEP" field.</summary>
    public const int Unk3300AEGCNHLOPEPFieldNumber = 8;
    private uint unk3300AEGCNHLOPEP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300AEGCNHLOPEP {
      get { return unk3300AEGCNHLOPEP_; }
      set {
        unk3300AEGCNHLOPEP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FungusCultivateReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FungusCultivateReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300IOANLJBMBAI != other.Unk3300IOANLJBMBAI) return false;
      if (Unk3300DJEGJDACDEF != other.Unk3300DJEGJDACDEF) return false;
      if (Unk3300IMEGFNOLDCE != other.Unk3300IMEGFNOLDCE) return false;
      if (Unk3300PGJKEICFKLL != other.Unk3300PGJKEICFKLL) return false;
      if (Unk3300MBPLICBFAGL != other.Unk3300MBPLICBFAGL) return false;
      if (CultivateId != other.CultivateId) return false;
      if (Time != other.Time) return false;
      if (Unk3300AEGCNHLOPEP != other.Unk3300AEGCNHLOPEP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300IOANLJBMBAI != 0) hash ^= Unk3300IOANLJBMBAI.GetHashCode();
      if (Unk3300DJEGJDACDEF != 0) hash ^= Unk3300DJEGJDACDEF.GetHashCode();
      if (Unk3300IMEGFNOLDCE != 0) hash ^= Unk3300IMEGFNOLDCE.GetHashCode();
      if (Unk3300PGJKEICFKLL != 0) hash ^= Unk3300PGJKEICFKLL.GetHashCode();
      if (Unk3300MBPLICBFAGL != 0) hash ^= Unk3300MBPLICBFAGL.GetHashCode();
      if (CultivateId != 0) hash ^= CultivateId.GetHashCode();
      if (Time != 0) hash ^= Time.GetHashCode();
      if (Unk3300AEGCNHLOPEP != 0) hash ^= Unk3300AEGCNHLOPEP.GetHashCode();
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
      if (Unk3300IOANLJBMBAI != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300IOANLJBMBAI);
      }
      if (Unk3300IMEGFNOLDCE != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300IMEGFNOLDCE);
      }
      if (Unk3300PGJKEICFKLL != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300PGJKEICFKLL);
      }
      if (Unk3300DJEGJDACDEF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300DJEGJDACDEF);
      }
      if (Unk3300MBPLICBFAGL != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300MBPLICBFAGL);
      }
      if (Unk3300AEGCNHLOPEP != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3300AEGCNHLOPEP);
      }
      if (CultivateId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CultivateId);
      }
      if (Time != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Time);
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
      if (Unk3300IOANLJBMBAI != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300IOANLJBMBAI);
      }
      if (Unk3300IMEGFNOLDCE != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300IMEGFNOLDCE);
      }
      if (Unk3300PGJKEICFKLL != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300PGJKEICFKLL);
      }
      if (Unk3300DJEGJDACDEF != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300DJEGJDACDEF);
      }
      if (Unk3300MBPLICBFAGL != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300MBPLICBFAGL);
      }
      if (Unk3300AEGCNHLOPEP != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3300AEGCNHLOPEP);
      }
      if (CultivateId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CultivateId);
      }
      if (Time != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Time);
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
      if (Unk3300IOANLJBMBAI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300IOANLJBMBAI);
      }
      if (Unk3300DJEGJDACDEF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300DJEGJDACDEF);
      }
      if (Unk3300IMEGFNOLDCE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300IMEGFNOLDCE);
      }
      if (Unk3300PGJKEICFKLL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300PGJKEICFKLL);
      }
      if (Unk3300MBPLICBFAGL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300MBPLICBFAGL);
      }
      if (CultivateId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CultivateId);
      }
      if (Time != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Time);
      }
      if (Unk3300AEGCNHLOPEP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300AEGCNHLOPEP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FungusCultivateReq other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300IOANLJBMBAI != 0) {
        Unk3300IOANLJBMBAI = other.Unk3300IOANLJBMBAI;
      }
      if (other.Unk3300DJEGJDACDEF != 0) {
        Unk3300DJEGJDACDEF = other.Unk3300DJEGJDACDEF;
      }
      if (other.Unk3300IMEGFNOLDCE != 0) {
        Unk3300IMEGFNOLDCE = other.Unk3300IMEGFNOLDCE;
      }
      if (other.Unk3300PGJKEICFKLL != 0) {
        Unk3300PGJKEICFKLL = other.Unk3300PGJKEICFKLL;
      }
      if (other.Unk3300MBPLICBFAGL != 0) {
        Unk3300MBPLICBFAGL = other.Unk3300MBPLICBFAGL;
      }
      if (other.CultivateId != 0) {
        CultivateId = other.CultivateId;
      }
      if (other.Time != 0) {
        Time = other.Time;
      }
      if (other.Unk3300AEGCNHLOPEP != 0) {
        Unk3300AEGCNHLOPEP = other.Unk3300AEGCNHLOPEP;
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
            Unk3300IOANLJBMBAI = input.ReadUInt32();
            break;
          }
          case 16: {
            Unk3300IMEGFNOLDCE = input.ReadUInt32();
            break;
          }
          case 40: {
            Unk3300PGJKEICFKLL = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300DJEGJDACDEF = input.ReadUInt32();
            break;
          }
          case 56: {
            Unk3300MBPLICBFAGL = input.ReadUInt32();
            break;
          }
          case 64: {
            Unk3300AEGCNHLOPEP = input.ReadUInt32();
            break;
          }
          case 96: {
            CultivateId = input.ReadUInt32();
            break;
          }
          case 120: {
            Time = input.ReadUInt32();
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
            Unk3300IOANLJBMBAI = input.ReadUInt32();
            break;
          }
          case 16: {
            Unk3300IMEGFNOLDCE = input.ReadUInt32();
            break;
          }
          case 40: {
            Unk3300PGJKEICFKLL = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300DJEGJDACDEF = input.ReadUInt32();
            break;
          }
          case 56: {
            Unk3300MBPLICBFAGL = input.ReadUInt32();
            break;
          }
          case 64: {
            Unk3300AEGCNHLOPEP = input.ReadUInt32();
            break;
          }
          case 96: {
            CultivateId = input.ReadUInt32();
            break;
          }
          case 120: {
            Time = input.ReadUInt32();
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
