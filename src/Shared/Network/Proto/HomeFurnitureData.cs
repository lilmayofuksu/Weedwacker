// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeFurnitureData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeFurnitureData.proto</summary>
  public static partial class HomeFurnitureDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeFurnitureData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeFurnitureDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdIb21lRnVybml0dXJlRGF0YS5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90bxoMVmVjdG9yLnByb3RvIuABChFIb21lRnVybml0dXJl",
            "RGF0YRIUCgxmdXJuaXR1cmVfaWQYCCABKA0SHgoWcGFyZW50X2Z1cm5pdHVy",
            "ZV9pbmRleBgPIAEoBRIMCgRndWlkGAwgASgNEjoKCXNwYXduX3JvdBgGIAEo",
            "CzInLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uVmVjdG9yEjoK",
            "CXNwYXduX3BvcxgCIAEoCzInLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsu",
            "UHJvdG8uVmVjdG9yEg8KB3ZlcnNpb24YCyABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeFurnitureData), global::Weedwacker.Shared.Network.Proto.HomeFurnitureData.Parser, new[]{ "FurnitureId", "ParentFurnitureIndex", "Guid", "SpawnRot", "SpawnPos", "Version" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeFurnitureData : pb::IMessage<HomeFurnitureData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeFurnitureData> _parser = new pb::MessageParser<HomeFurnitureData>(() => new HomeFurnitureData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeFurnitureData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeFurnitureDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureData(HomeFurnitureData other) : this() {
      furnitureId_ = other.furnitureId_;
      parentFurnitureIndex_ = other.parentFurnitureIndex_;
      guid_ = other.guid_;
      spawnRot_ = other.spawnRot_ != null ? other.spawnRot_.Clone() : null;
      spawnPos_ = other.spawnPos_ != null ? other.spawnPos_.Clone() : null;
      version_ = other.version_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeFurnitureData Clone() {
      return new HomeFurnitureData(this);
    }

    /// <summary>Field number for the "furniture_id" field.</summary>
    public const int FurnitureIdFieldNumber = 8;
    private uint furnitureId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FurnitureId {
      get { return furnitureId_; }
      set {
        furnitureId_ = value;
      }
    }

    /// <summary>Field number for the "parent_furniture_index" field.</summary>
    public const int ParentFurnitureIndexFieldNumber = 15;
    private int parentFurnitureIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ParentFurnitureIndex {
      get { return parentFurnitureIndex_; }
      set {
        parentFurnitureIndex_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 12;
    private uint guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "spawn_rot" field.</summary>
    public const int SpawnRotFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.Vector spawnRot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector SpawnRot {
      get { return spawnRot_; }
      set {
        spawnRot_ = value;
      }
    }

    /// <summary>Field number for the "spawn_pos" field.</summary>
    public const int SpawnPosFieldNumber = 2;
    private global::Weedwacker.Shared.Network.Proto.Vector spawnPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector SpawnPos {
      get { return spawnPos_; }
      set {
        spawnPos_ = value;
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 11;
    private uint version_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Version {
      get { return version_; }
      set {
        version_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeFurnitureData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeFurnitureData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FurnitureId != other.FurnitureId) return false;
      if (ParentFurnitureIndex != other.ParentFurnitureIndex) return false;
      if (Guid != other.Guid) return false;
      if (!object.Equals(SpawnRot, other.SpawnRot)) return false;
      if (!object.Equals(SpawnPos, other.SpawnPos)) return false;
      if (Version != other.Version) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FurnitureId != 0) hash ^= FurnitureId.GetHashCode();
      if (ParentFurnitureIndex != 0) hash ^= ParentFurnitureIndex.GetHashCode();
      if (Guid != 0) hash ^= Guid.GetHashCode();
      if (spawnRot_ != null) hash ^= SpawnRot.GetHashCode();
      if (spawnPos_ != null) hash ^= SpawnPos.GetHashCode();
      if (Version != 0) hash ^= Version.GetHashCode();
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
      if (spawnPos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SpawnPos);
      }
      if (spawnRot_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(SpawnRot);
      }
      if (FurnitureId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(FurnitureId);
      }
      if (Version != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Version);
      }
      if (Guid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Guid);
      }
      if (ParentFurnitureIndex != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(ParentFurnitureIndex);
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
      if (spawnPos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SpawnPos);
      }
      if (spawnRot_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(SpawnRot);
      }
      if (FurnitureId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(FurnitureId);
      }
      if (Version != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Version);
      }
      if (Guid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Guid);
      }
      if (ParentFurnitureIndex != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(ParentFurnitureIndex);
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
      if (FurnitureId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FurnitureId);
      }
      if (ParentFurnitureIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ParentFurnitureIndex);
      }
      if (Guid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Guid);
      }
      if (spawnRot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpawnRot);
      }
      if (spawnPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpawnPos);
      }
      if (Version != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Version);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeFurnitureData other) {
      if (other == null) {
        return;
      }
      if (other.FurnitureId != 0) {
        FurnitureId = other.FurnitureId;
      }
      if (other.ParentFurnitureIndex != 0) {
        ParentFurnitureIndex = other.ParentFurnitureIndex;
      }
      if (other.Guid != 0) {
        Guid = other.Guid;
      }
      if (other.spawnRot_ != null) {
        if (spawnRot_ == null) {
          SpawnRot = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        SpawnRot.MergeFrom(other.SpawnRot);
      }
      if (other.spawnPos_ != null) {
        if (spawnPos_ == null) {
          SpawnPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        SpawnPos.MergeFrom(other.SpawnPos);
      }
      if (other.Version != 0) {
        Version = other.Version;
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
          case 18: {
            if (spawnPos_ == null) {
              SpawnPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(SpawnPos);
            break;
          }
          case 50: {
            if (spawnRot_ == null) {
              SpawnRot = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(SpawnRot);
            break;
          }
          case 64: {
            FurnitureId = input.ReadUInt32();
            break;
          }
          case 88: {
            Version = input.ReadUInt32();
            break;
          }
          case 96: {
            Guid = input.ReadUInt32();
            break;
          }
          case 120: {
            ParentFurnitureIndex = input.ReadInt32();
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
          case 18: {
            if (spawnPos_ == null) {
              SpawnPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(SpawnPos);
            break;
          }
          case 50: {
            if (spawnRot_ == null) {
              SpawnRot = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(SpawnRot);
            break;
          }
          case 64: {
            FurnitureId = input.ReadUInt32();
            break;
          }
          case 88: {
            Version = input.ReadUInt32();
            break;
          }
          case 96: {
            Guid = input.ReadUInt32();
            break;
          }
          case 120: {
            ParentFurnitureIndex = input.ReadInt32();
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
