// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PropValue.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PropValue.proto</summary>
  public static partial class PropValueReflection {

    #region Descriptor
    /// <summary>File descriptor for PropValue.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PropValueReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9Qcm9wVmFsdWUucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsu",
            "UHJvdG8iTwoJUHJvcFZhbHVlEgwKBHR5cGUYASABKA0SCwoDdmFsGAQgASgD",
            "Eg4KBGl2YWwYAiABKANIABIOCgRmdmFsGAMgASgCSABCBwoFdmFsdWViBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PropValue), global::Weedwacker.Shared.Network.Proto.PropValue.Parser, new[]{ "Type", "Val", "Ival", "Fval" }, new[]{ "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PropValue : pb::IMessage<PropValue>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PropValue> _parser = new pb::MessageParser<PropValue>(() => new PropValue());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PropValue> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PropValueReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropValue() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropValue(PropValue other) : this() {
      type_ = other.type_;
      val_ = other.val_;
      switch (other.ValueCase) {
        case ValueOneofCase.Ival:
          Ival = other.Ival;
          break;
        case ValueOneofCase.Fval:
          Fval = other.Fval;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropValue Clone() {
      return new PropValue(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private uint type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "val" field.</summary>
    public const int ValFieldNumber = 4;
    private long val_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Val {
      get { return val_; }
      set {
        val_ = value;
      }
    }

    /// <summary>Field number for the "ival" field.</summary>
    public const int IvalFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Ival {
      get { return valueCase_ == ValueOneofCase.Ival ? (long) value_ : 0L; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.Ival;
      }
    }

    /// <summary>Field number for the "fval" field.</summary>
    public const int FvalFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Fval {
      get { return valueCase_ == ValueOneofCase.Fval ? (float) value_ : 0F; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.Fval;
      }
    }

    private object value_;
    /// <summary>Enum of possible cases for the "value" oneof.</summary>
    public enum ValueOneofCase {
      None = 0,
      Ival = 2,
      Fval = 3,
    }
    private ValueOneofCase valueCase_ = ValueOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValueOneofCase ValueCase {
      get { return valueCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearValue() {
      valueCase_ = ValueOneofCase.None;
      value_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PropValue);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PropValue other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Val != other.Val) return false;
      if (Ival != other.Ival) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Fval, other.Fval)) return false;
      if (ValueCase != other.ValueCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Val != 0L) hash ^= Val.GetHashCode();
      if (valueCase_ == ValueOneofCase.Ival) hash ^= Ival.GetHashCode();
      if (valueCase_ == ValueOneofCase.Fval) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Fval);
      hash ^= (int) valueCase_;
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
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Type);
      }
      if (valueCase_ == ValueOneofCase.Ival) {
        output.WriteRawTag(16);
        output.WriteInt64(Ival);
      }
      if (valueCase_ == ValueOneofCase.Fval) {
        output.WriteRawTag(29);
        output.WriteFloat(Fval);
      }
      if (Val != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Val);
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
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Type);
      }
      if (valueCase_ == ValueOneofCase.Ival) {
        output.WriteRawTag(16);
        output.WriteInt64(Ival);
      }
      if (valueCase_ == ValueOneofCase.Fval) {
        output.WriteRawTag(29);
        output.WriteFloat(Fval);
      }
      if (Val != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Val);
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
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Type);
      }
      if (Val != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Val);
      }
      if (valueCase_ == ValueOneofCase.Ival) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Ival);
      }
      if (valueCase_ == ValueOneofCase.Fval) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PropValue other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Val != 0L) {
        Val = other.Val;
      }
      switch (other.ValueCase) {
        case ValueOneofCase.Ival:
          Ival = other.Ival;
          break;
        case ValueOneofCase.Fval:
          Fval = other.Fval;
          break;
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
            Type = input.ReadUInt32();
            break;
          }
          case 16: {
            Ival = input.ReadInt64();
            break;
          }
          case 29: {
            Fval = input.ReadFloat();
            break;
          }
          case 32: {
            Val = input.ReadInt64();
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
            Type = input.ReadUInt32();
            break;
          }
          case 16: {
            Ival = input.ReadInt64();
            break;
          }
          case 29: {
            Fval = input.ReadFloat();
            break;
          }
          case 32: {
            Val = input.ReadInt64();
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
