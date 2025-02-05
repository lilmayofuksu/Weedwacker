// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonBlock.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CustomDungeonBlock.proto</summary>
  public static partial class CustomDungeonBlockReflection {

    #region Descriptor
    /// <summary>File descriptor for CustomDungeonBlock.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomDungeonBlockReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDdXN0b21EdW5nZW9uQmxvY2sucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG8aDFZlY3Rvci5wcm90byKgAQoSQ3VzdG9tRHVuZ2Vv",
            "bkJsb2NrEhAKCGJsb2NrX2lkGAYgASgNEjQKA3JvdBgMIAEoCzInLldlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uVmVjdG9yEjQKA3BvcxgNIAEo",
            "CzInLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uVmVjdG9yEgwK",
            "BGd1aWQYDyABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CustomDungeonBlock), global::Weedwacker.Shared.Network.Proto.CustomDungeonBlock.Parser, new[]{ "BlockId", "Rot", "Pos", "Guid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CustomDungeonBlock : pb::IMessage<CustomDungeonBlock>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomDungeonBlock> _parser = new pb::MessageParser<CustomDungeonBlock>(() => new CustomDungeonBlock());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomDungeonBlock> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CustomDungeonBlockReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonBlock() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonBlock(CustomDungeonBlock other) : this() {
      blockId_ = other.blockId_;
      rot_ = other.rot_ != null ? other.rot_.Clone() : null;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      guid_ = other.guid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonBlock Clone() {
      return new CustomDungeonBlock(this);
    }

    /// <summary>Field number for the "block_id" field.</summary>
    public const int BlockIdFieldNumber = 6;
    private uint blockId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BlockId {
      get { return blockId_; }
      set {
        blockId_ = value;
      }
    }

    /// <summary>Field number for the "rot" field.</summary>
    public const int RotFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.Vector rot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Rot {
      get { return rot_; }
      set {
        rot_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 13;
    private global::Weedwacker.Shared.Network.Proto.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 15;
    private uint guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomDungeonBlock);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomDungeonBlock other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BlockId != other.BlockId) return false;
      if (!object.Equals(Rot, other.Rot)) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (Guid != other.Guid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BlockId != 0) hash ^= BlockId.GetHashCode();
      if (rot_ != null) hash ^= Rot.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (Guid != 0) hash ^= Guid.GetHashCode();
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
      if (BlockId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BlockId);
      }
      if (rot_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Rot);
      }
      if (pos_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Pos);
      }
      if (Guid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Guid);
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
      if (BlockId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(BlockId);
      }
      if (rot_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Rot);
      }
      if (pos_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Pos);
      }
      if (Guid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Guid);
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
      if (BlockId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BlockId);
      }
      if (rot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rot);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (Guid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Guid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomDungeonBlock other) {
      if (other == null) {
        return;
      }
      if (other.BlockId != 0) {
        BlockId = other.BlockId;
      }
      if (other.rot_ != null) {
        if (rot_ == null) {
          Rot = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Rot.MergeFrom(other.Rot);
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.Guid != 0) {
        Guid = other.Guid;
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
            BlockId = input.ReadUInt32();
            break;
          }
          case 98: {
            if (rot_ == null) {
              Rot = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Rot);
            break;
          }
          case 106: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 120: {
            Guid = input.ReadUInt32();
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
            BlockId = input.ReadUInt32();
            break;
          }
          case 98: {
            if (rot_ == null) {
              Rot = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Rot);
            break;
          }
          case 106: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 120: {
            Guid = input.ReadUInt32();
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
