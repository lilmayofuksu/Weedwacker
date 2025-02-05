// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EntityRendererChangedInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EntityRendererChangedInfo.proto</summary>
  public static partial class EntityRendererChangedInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EntityRendererChangedInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EntityRendererChangedInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9FbnRpdHlSZW5kZXJlckNoYW5nZWRJbmZvLnByb3RvEh9XZWVkd2Fja2Vy",
            "LlNoYXJlZC5OZXR3b3JrLlByb3RvIu4BChlFbnRpdHlSZW5kZXJlckNoYW5n",
            "ZWRJbmZvEmsKEWNoYW5nZWRfcmVuZGVyZXJzGAEgAygLMlAuV2VlZHdhY2tl",
            "ci5TaGFyZWQuTmV0d29yay5Qcm90by5FbnRpdHlSZW5kZXJlckNoYW5nZWRJ",
            "bmZvLkNoYW5nZWRSZW5kZXJlcnNFbnRyeRIYChB2aXNpYmlsaXR5X2NvdW50",
            "GAIgASgNEhEKCWlzX2NhY2hlZBgDIAEoCBo3ChVDaGFuZ2VkUmVuZGVyZXJz",
            "RW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVlGAIgASgNOgI4AWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EntityRendererChangedInfo), global::Weedwacker.Shared.Network.Proto.EntityRendererChangedInfo.Parser, new[]{ "ChangedRenderers", "VisibilityCount", "IsCached" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EntityRendererChangedInfo : pb::IMessage<EntityRendererChangedInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EntityRendererChangedInfo> _parser = new pb::MessageParser<EntityRendererChangedInfo>(() => new EntityRendererChangedInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EntityRendererChangedInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EntityRendererChangedInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityRendererChangedInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityRendererChangedInfo(EntityRendererChangedInfo other) : this() {
      changedRenderers_ = other.changedRenderers_.Clone();
      visibilityCount_ = other.visibilityCount_;
      isCached_ = other.isCached_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EntityRendererChangedInfo Clone() {
      return new EntityRendererChangedInfo(this);
    }

    /// <summary>Field number for the "changed_renderers" field.</summary>
    public const int ChangedRenderersFieldNumber = 1;
    private static readonly pbc::MapField<string, uint>.Codec _map_changedRenderers_codec
        = new pbc::MapField<string, uint>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForUInt32(16, 0), 10);
    private readonly pbc::MapField<string, uint> changedRenderers_ = new pbc::MapField<string, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, uint> ChangedRenderers {
      get { return changedRenderers_; }
    }

    /// <summary>Field number for the "visibility_count" field.</summary>
    public const int VisibilityCountFieldNumber = 2;
    private uint visibilityCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint VisibilityCount {
      get { return visibilityCount_; }
      set {
        visibilityCount_ = value;
      }
    }

    /// <summary>Field number for the "is_cached" field.</summary>
    public const int IsCachedFieldNumber = 3;
    private bool isCached_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCached {
      get { return isCached_; }
      set {
        isCached_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EntityRendererChangedInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EntityRendererChangedInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!ChangedRenderers.Equals(other.ChangedRenderers)) return false;
      if (VisibilityCount != other.VisibilityCount) return false;
      if (IsCached != other.IsCached) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= ChangedRenderers.GetHashCode();
      if (VisibilityCount != 0) hash ^= VisibilityCount.GetHashCode();
      if (IsCached != false) hash ^= IsCached.GetHashCode();
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
      changedRenderers_.WriteTo(output, _map_changedRenderers_codec);
      if (VisibilityCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(VisibilityCount);
      }
      if (IsCached != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsCached);
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
      changedRenderers_.WriteTo(ref output, _map_changedRenderers_codec);
      if (VisibilityCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(VisibilityCount);
      }
      if (IsCached != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsCached);
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
      size += changedRenderers_.CalculateSize(_map_changedRenderers_codec);
      if (VisibilityCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(VisibilityCount);
      }
      if (IsCached != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EntityRendererChangedInfo other) {
      if (other == null) {
        return;
      }
      changedRenderers_.Add(other.changedRenderers_);
      if (other.VisibilityCount != 0) {
        VisibilityCount = other.VisibilityCount;
      }
      if (other.IsCached != false) {
        IsCached = other.IsCached;
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
          case 10: {
            changedRenderers_.AddEntriesFrom(input, _map_changedRenderers_codec);
            break;
          }
          case 16: {
            VisibilityCount = input.ReadUInt32();
            break;
          }
          case 24: {
            IsCached = input.ReadBool();
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
          case 10: {
            changedRenderers_.AddEntriesFrom(ref input, _map_changedRenderers_codec);
            break;
          }
          case 16: {
            VisibilityCount = input.ReadUInt32();
            break;
          }
          case 24: {
            IsCached = input.ReadBool();
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
