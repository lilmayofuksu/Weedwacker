// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ExecuteGroupTriggerReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ExecuteGroupTriggerReq.proto</summary>
  public static partial class ExecuteGroupTriggerReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ExecuteGroupTriggerReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExecuteGroupTriggerReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxFeGVjdXRlR3JvdXBUcmlnZ2VyUmVxLnByb3RvEh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvIpEBChZFeGVjdXRlR3JvdXBUcmlnZ2VyUmVx",
            "EhgKEHNvdXJjZV9lbnRpdHlfaWQYByABKA0SDgoGcGFyYW0zGAYgASgFEg4K",
            "BnBhcmFtMRgJIAEoBRITCgtzb3VyY2VfbmFtZRgIIAEoCRIYChB0YXJnZXRf",
            "ZW50aXR5X2lkGA8gASgNEg4KBnBhcmFtMhgEIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ExecuteGroupTriggerReq), global::Weedwacker.Shared.Network.Proto.ExecuteGroupTriggerReq.Parser, new[]{ "SourceEntityId", "Param3", "Param1", "SourceName", "TargetEntityId", "Param2" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 263;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class ExecuteGroupTriggerReq : pb::IMessage<ExecuteGroupTriggerReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExecuteGroupTriggerReq> _parser = new pb::MessageParser<ExecuteGroupTriggerReq>(() => new ExecuteGroupTriggerReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExecuteGroupTriggerReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ExecuteGroupTriggerReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExecuteGroupTriggerReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExecuteGroupTriggerReq(ExecuteGroupTriggerReq other) : this() {
      sourceEntityId_ = other.sourceEntityId_;
      param3_ = other.param3_;
      param1_ = other.param1_;
      sourceName_ = other.sourceName_;
      targetEntityId_ = other.targetEntityId_;
      param2_ = other.param2_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExecuteGroupTriggerReq Clone() {
      return new ExecuteGroupTriggerReq(this);
    }

    /// <summary>Field number for the "source_entity_id" field.</summary>
    public const int SourceEntityIdFieldNumber = 7;
    private uint sourceEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceEntityId {
      get { return sourceEntityId_; }
      set {
        sourceEntityId_ = value;
      }
    }

    /// <summary>Field number for the "param3" field.</summary>
    public const int Param3FieldNumber = 6;
    private int param3_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Param3 {
      get { return param3_; }
      set {
        param3_ = value;
      }
    }

    /// <summary>Field number for the "param1" field.</summary>
    public const int Param1FieldNumber = 9;
    private int param1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Param1 {
      get { return param1_; }
      set {
        param1_ = value;
      }
    }

    /// <summary>Field number for the "source_name" field.</summary>
    public const int SourceNameFieldNumber = 8;
    private string sourceName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SourceName {
      get { return sourceName_; }
      set {
        sourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target_entity_id" field.</summary>
    public const int TargetEntityIdFieldNumber = 15;
    private uint targetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetEntityId {
      get { return targetEntityId_; }
      set {
        targetEntityId_ = value;
      }
    }

    /// <summary>Field number for the "param2" field.</summary>
    public const int Param2FieldNumber = 4;
    private int param2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Param2 {
      get { return param2_; }
      set {
        param2_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExecuteGroupTriggerReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExecuteGroupTriggerReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SourceEntityId != other.SourceEntityId) return false;
      if (Param3 != other.Param3) return false;
      if (Param1 != other.Param1) return false;
      if (SourceName != other.SourceName) return false;
      if (TargetEntityId != other.TargetEntityId) return false;
      if (Param2 != other.Param2) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SourceEntityId != 0) hash ^= SourceEntityId.GetHashCode();
      if (Param3 != 0) hash ^= Param3.GetHashCode();
      if (Param1 != 0) hash ^= Param1.GetHashCode();
      if (SourceName.Length != 0) hash ^= SourceName.GetHashCode();
      if (TargetEntityId != 0) hash ^= TargetEntityId.GetHashCode();
      if (Param2 != 0) hash ^= Param2.GetHashCode();
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
      if (Param2 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Param2);
      }
      if (Param3 != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Param3);
      }
      if (SourceEntityId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(SourceEntityId);
      }
      if (SourceName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(SourceName);
      }
      if (Param1 != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Param1);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TargetEntityId);
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
      if (Param2 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Param2);
      }
      if (Param3 != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Param3);
      }
      if (SourceEntityId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(SourceEntityId);
      }
      if (SourceName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(SourceName);
      }
      if (Param1 != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Param1);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TargetEntityId);
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
      if (SourceEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceEntityId);
      }
      if (Param3 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Param3);
      }
      if (Param1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Param1);
      }
      if (SourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceName);
      }
      if (TargetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetEntityId);
      }
      if (Param2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Param2);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExecuteGroupTriggerReq other) {
      if (other == null) {
        return;
      }
      if (other.SourceEntityId != 0) {
        SourceEntityId = other.SourceEntityId;
      }
      if (other.Param3 != 0) {
        Param3 = other.Param3;
      }
      if (other.Param1 != 0) {
        Param1 = other.Param1;
      }
      if (other.SourceName.Length != 0) {
        SourceName = other.SourceName;
      }
      if (other.TargetEntityId != 0) {
        TargetEntityId = other.TargetEntityId;
      }
      if (other.Param2 != 0) {
        Param2 = other.Param2;
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
          case 32: {
            Param2 = input.ReadInt32();
            break;
          }
          case 48: {
            Param3 = input.ReadInt32();
            break;
          }
          case 56: {
            SourceEntityId = input.ReadUInt32();
            break;
          }
          case 66: {
            SourceName = input.ReadString();
            break;
          }
          case 72: {
            Param1 = input.ReadInt32();
            break;
          }
          case 120: {
            TargetEntityId = input.ReadUInt32();
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
          case 32: {
            Param2 = input.ReadInt32();
            break;
          }
          case 48: {
            Param3 = input.ReadInt32();
            break;
          }
          case 56: {
            SourceEntityId = input.ReadUInt32();
            break;
          }
          case 66: {
            SourceName = input.ReadString();
            break;
          }
          case 72: {
            Param1 = input.ReadInt32();
            break;
          }
          case 120: {
            TargetEntityId = input.ReadUInt32();
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
