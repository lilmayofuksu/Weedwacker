// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ModifierDurability.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ModifierDurability.proto</summary>
  public static partial class ModifierDurabilityReflection {

    #region Descriptor
    /// <summary>File descriptor for ModifierDurability.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModifierDurabilityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhNb2RpZmllckR1cmFiaWxpdHkucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG8iSAoSTW9kaWZpZXJEdXJhYmlsaXR5EhQKDHJlZHVj",
            "ZV9yYXRpbxgBIAEoAhIcChRyZW1haW5pbmdfZHVyYWJpbGl0eRgCIAEoAmIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ModifierDurability), global::Weedwacker.Shared.Network.Proto.ModifierDurability.Parser, new[]{ "ReduceRatio", "RemainingDurability" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ModifierDurability : pb::IMessage<ModifierDurability>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ModifierDurability> _parser = new pb::MessageParser<ModifierDurability>(() => new ModifierDurability());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ModifierDurability> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ModifierDurabilityReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModifierDurability() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModifierDurability(ModifierDurability other) : this() {
      reduceRatio_ = other.reduceRatio_;
      remainingDurability_ = other.remainingDurability_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ModifierDurability Clone() {
      return new ModifierDurability(this);
    }

    /// <summary>Field number for the "reduce_ratio" field.</summary>
    public const int ReduceRatioFieldNumber = 1;
    private float reduceRatio_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float ReduceRatio {
      get { return reduceRatio_; }
      set {
        reduceRatio_ = value;
      }
    }

    /// <summary>Field number for the "remaining_durability" field.</summary>
    public const int RemainingDurabilityFieldNumber = 2;
    private float remainingDurability_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float RemainingDurability {
      get { return remainingDurability_; }
      set {
        remainingDurability_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ModifierDurability);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ModifierDurability other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ReduceRatio, other.ReduceRatio)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RemainingDurability, other.RemainingDurability)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ReduceRatio != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ReduceRatio);
      if (RemainingDurability != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RemainingDurability);
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
      if (ReduceRatio != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(ReduceRatio);
      }
      if (RemainingDurability != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(RemainingDurability);
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
      if (ReduceRatio != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(ReduceRatio);
      }
      if (RemainingDurability != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(RemainingDurability);
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
      if (ReduceRatio != 0F) {
        size += 1 + 4;
      }
      if (RemainingDurability != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ModifierDurability other) {
      if (other == null) {
        return;
      }
      if (other.ReduceRatio != 0F) {
        ReduceRatio = other.ReduceRatio;
      }
      if (other.RemainingDurability != 0F) {
        RemainingDurability = other.RemainingDurability;
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
          case 13: {
            ReduceRatio = input.ReadFloat();
            break;
          }
          case 21: {
            RemainingDurability = input.ReadFloat();
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
          case 13: {
            ReduceRatio = input.ReadFloat();
            break;
          }
          case 21: {
            RemainingDurability = input.ReadFloat();
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
