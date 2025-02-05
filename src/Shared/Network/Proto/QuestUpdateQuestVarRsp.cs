// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QuestUpdateQuestVarRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from QuestUpdateQuestVarRsp.proto</summary>
  public static partial class QuestUpdateQuestVarRspReflection {

    #region Descriptor
    /// <summary>File descriptor for QuestUpdateQuestVarRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestUpdateQuestVarRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxRdWVzdFVwZGF0ZVF1ZXN0VmFyUnNwLnByb3RvEh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvInIKFlF1ZXN0VXBkYXRlUXVlc3RWYXJSc3AS",
            "DwoHcmV0Y29kZRgHIAEoBRIcChRwYXJlbnRfcXVlc3RfdmFyX3NlcRgBIAEo",
            "DRIXCg9wYXJlbnRfcXVlc3RfaWQYCCABKA0SEAoIcXVlc3RfaWQYCyABKA1i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.QuestUpdateQuestVarRsp), global::Weedwacker.Shared.Network.Proto.QuestUpdateQuestVarRsp.Parser, new[]{ "Retcode", "ParentQuestVarSeq", "ParentQuestId", "QuestId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 416;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class QuestUpdateQuestVarRsp : pb::IMessage<QuestUpdateQuestVarRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QuestUpdateQuestVarRsp> _parser = new pb::MessageParser<QuestUpdateQuestVarRsp>(() => new QuestUpdateQuestVarRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QuestUpdateQuestVarRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.QuestUpdateQuestVarRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestUpdateQuestVarRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestUpdateQuestVarRsp(QuestUpdateQuestVarRsp other) : this() {
      retcode_ = other.retcode_;
      parentQuestVarSeq_ = other.parentQuestVarSeq_;
      parentQuestId_ = other.parentQuestId_;
      questId_ = other.questId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestUpdateQuestVarRsp Clone() {
      return new QuestUpdateQuestVarRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "parent_quest_var_seq" field.</summary>
    public const int ParentQuestVarSeqFieldNumber = 1;
    private uint parentQuestVarSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParentQuestVarSeq {
      get { return parentQuestVarSeq_; }
      set {
        parentQuestVarSeq_ = value;
      }
    }

    /// <summary>Field number for the "parent_quest_id" field.</summary>
    public const int ParentQuestIdFieldNumber = 8;
    private uint parentQuestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParentQuestId {
      get { return parentQuestId_; }
      set {
        parentQuestId_ = value;
      }
    }

    /// <summary>Field number for the "quest_id" field.</summary>
    public const int QuestIdFieldNumber = 11;
    private uint questId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QuestId {
      get { return questId_; }
      set {
        questId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QuestUpdateQuestVarRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QuestUpdateQuestVarRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (ParentQuestVarSeq != other.ParentQuestVarSeq) return false;
      if (ParentQuestId != other.ParentQuestId) return false;
      if (QuestId != other.QuestId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (ParentQuestVarSeq != 0) hash ^= ParentQuestVarSeq.GetHashCode();
      if (ParentQuestId != 0) hash ^= ParentQuestId.GetHashCode();
      if (QuestId != 0) hash ^= QuestId.GetHashCode();
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
      if (ParentQuestVarSeq != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ParentQuestVarSeq);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      if (ParentQuestId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ParentQuestId);
      }
      if (QuestId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(QuestId);
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
      if (ParentQuestVarSeq != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ParentQuestVarSeq);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      if (ParentQuestId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ParentQuestId);
      }
      if (QuestId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(QuestId);
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
      if (ParentQuestVarSeq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParentQuestVarSeq);
      }
      if (ParentQuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParentQuestId);
      }
      if (QuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuestId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QuestUpdateQuestVarRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.ParentQuestVarSeq != 0) {
        ParentQuestVarSeq = other.ParentQuestVarSeq;
      }
      if (other.ParentQuestId != 0) {
        ParentQuestId = other.ParentQuestId;
      }
      if (other.QuestId != 0) {
        QuestId = other.QuestId;
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
            ParentQuestVarSeq = input.ReadUInt32();
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 64: {
            ParentQuestId = input.ReadUInt32();
            break;
          }
          case 88: {
            QuestId = input.ReadUInt32();
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
            ParentQuestVarSeq = input.ReadUInt32();
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 64: {
            ParentQuestId = input.ReadUInt32();
            break;
          }
          case 88: {
            QuestId = input.ReadUInt32();
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
