// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BrickBreakerActivityStageInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BrickBreakerActivityStageInfo.proto</summary>
  public static partial class BrickBreakerActivityStageInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for BrickBreakerActivityStageInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BrickBreakerActivityStageInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNCcmlja0JyZWFrZXJBY3Rpdml0eVN0YWdlSW5mby5wcm90bxIfV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90byJrCh1Ccmlja0JyZWFrZXJBY3Rp",
            "dml0eVN0YWdlSW5mbxIQCghzdGFnZV9pZBgDIAEoDRIbChNVbmszMzAwX0FM",
            "T0dJS05IRUlNGAIgASgIEhsKE1VuazMzMDBfRkZLSUVETkdOR0sYCiABKAhi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BrickBreakerActivityStageInfo), global::Weedwacker.Shared.Network.Proto.BrickBreakerActivityStageInfo.Parser, new[]{ "StageId", "Unk3300ALOGIKNHEIM", "Unk3300FFKIEDNGNGK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BrickBreakerActivityStageInfo : pb::IMessage<BrickBreakerActivityStageInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BrickBreakerActivityStageInfo> _parser = new pb::MessageParser<BrickBreakerActivityStageInfo>(() => new BrickBreakerActivityStageInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BrickBreakerActivityStageInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BrickBreakerActivityStageInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BrickBreakerActivityStageInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BrickBreakerActivityStageInfo(BrickBreakerActivityStageInfo other) : this() {
      stageId_ = other.stageId_;
      unk3300ALOGIKNHEIM_ = other.unk3300ALOGIKNHEIM_;
      unk3300FFKIEDNGNGK_ = other.unk3300FFKIEDNGNGK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BrickBreakerActivityStageInfo Clone() {
      return new BrickBreakerActivityStageInfo(this);
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 3;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_ALOGIKNHEIM" field.</summary>
    public const int Unk3300ALOGIKNHEIMFieldNumber = 2;
    private bool unk3300ALOGIKNHEIM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300ALOGIKNHEIM {
      get { return unk3300ALOGIKNHEIM_; }
      set {
        unk3300ALOGIKNHEIM_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_FFKIEDNGNGK" field.</summary>
    public const int Unk3300FFKIEDNGNGKFieldNumber = 10;
    private bool unk3300FFKIEDNGNGK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300FFKIEDNGNGK {
      get { return unk3300FFKIEDNGNGK_; }
      set {
        unk3300FFKIEDNGNGK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BrickBreakerActivityStageInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BrickBreakerActivityStageInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StageId != other.StageId) return false;
      if (Unk3300ALOGIKNHEIM != other.Unk3300ALOGIKNHEIM) return false;
      if (Unk3300FFKIEDNGNGK != other.Unk3300FFKIEDNGNGK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (Unk3300ALOGIKNHEIM != false) hash ^= Unk3300ALOGIKNHEIM.GetHashCode();
      if (Unk3300FFKIEDNGNGK != false) hash ^= Unk3300FFKIEDNGNGK.GetHashCode();
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
      if (Unk3300ALOGIKNHEIM != false) {
        output.WriteRawTag(16);
        output.WriteBool(Unk3300ALOGIKNHEIM);
      }
      if (StageId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StageId);
      }
      if (Unk3300FFKIEDNGNGK != false) {
        output.WriteRawTag(80);
        output.WriteBool(Unk3300FFKIEDNGNGK);
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
      if (Unk3300ALOGIKNHEIM != false) {
        output.WriteRawTag(16);
        output.WriteBool(Unk3300ALOGIKNHEIM);
      }
      if (StageId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StageId);
      }
      if (Unk3300FFKIEDNGNGK != false) {
        output.WriteRawTag(80);
        output.WriteBool(Unk3300FFKIEDNGNGK);
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
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (Unk3300ALOGIKNHEIM != false) {
        size += 1 + 1;
      }
      if (Unk3300FFKIEDNGNGK != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BrickBreakerActivityStageInfo other) {
      if (other == null) {
        return;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.Unk3300ALOGIKNHEIM != false) {
        Unk3300ALOGIKNHEIM = other.Unk3300ALOGIKNHEIM;
      }
      if (other.Unk3300FFKIEDNGNGK != false) {
        Unk3300FFKIEDNGNGK = other.Unk3300FFKIEDNGNGK;
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
          case 16: {
            Unk3300ALOGIKNHEIM = input.ReadBool();
            break;
          }
          case 24: {
            StageId = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300FFKIEDNGNGK = input.ReadBool();
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
          case 16: {
            Unk3300ALOGIKNHEIM = input.ReadBool();
            break;
          }
          case 24: {
            StageId = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300FFKIEDNGNGK = input.ReadBool();
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
