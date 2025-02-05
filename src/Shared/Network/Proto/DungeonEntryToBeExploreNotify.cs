// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonEntryToBeExploreNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from DungeonEntryToBeExploreNotify.proto</summary>
  public static partial class DungeonEntryToBeExploreNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonEntryToBeExploreNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonEntryToBeExploreNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNEdW5nZW9uRW50cnlUb0JlRXhwbG9yZU5vdGlmeS5wcm90bxIfV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90byJ4Ch1EdW5nZW9uRW50cnlUb0Jl",
            "RXhwbG9yZU5vdGlmeRIQCghzY2VuZV9pZBgGIAEoDRIkChxkdW5nZW9uX2Vu",
            "dHJ5X3NjZW5lX3BvaW50X2lkGAMgASgNEh8KF2R1bmdlb25fZW50cnlfY29u",
            "ZmlnX2lkGAIgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.DungeonEntryToBeExploreNotify), global::Weedwacker.Shared.Network.Proto.DungeonEntryToBeExploreNotify.Parser, new[]{ "SceneId", "DungeonEntryScenePointId", "DungeonEntryConfigId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 3196;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class DungeonEntryToBeExploreNotify : pb::IMessage<DungeonEntryToBeExploreNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DungeonEntryToBeExploreNotify> _parser = new pb::MessageParser<DungeonEntryToBeExploreNotify>(() => new DungeonEntryToBeExploreNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DungeonEntryToBeExploreNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.DungeonEntryToBeExploreNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryToBeExploreNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryToBeExploreNotify(DungeonEntryToBeExploreNotify other) : this() {
      sceneId_ = other.sceneId_;
      dungeonEntryScenePointId_ = other.dungeonEntryScenePointId_;
      dungeonEntryConfigId_ = other.dungeonEntryConfigId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryToBeExploreNotify Clone() {
      return new DungeonEntryToBeExploreNotify(this);
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 6;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_entry_scene_point_id" field.</summary>
    public const int DungeonEntryScenePointIdFieldNumber = 3;
    private uint dungeonEntryScenePointId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonEntryScenePointId {
      get { return dungeonEntryScenePointId_; }
      set {
        dungeonEntryScenePointId_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_entry_config_id" field.</summary>
    public const int DungeonEntryConfigIdFieldNumber = 2;
    private uint dungeonEntryConfigId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonEntryConfigId {
      get { return dungeonEntryConfigId_; }
      set {
        dungeonEntryConfigId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DungeonEntryToBeExploreNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DungeonEntryToBeExploreNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SceneId != other.SceneId) return false;
      if (DungeonEntryScenePointId != other.DungeonEntryScenePointId) return false;
      if (DungeonEntryConfigId != other.DungeonEntryConfigId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (DungeonEntryScenePointId != 0) hash ^= DungeonEntryScenePointId.GetHashCode();
      if (DungeonEntryConfigId != 0) hash ^= DungeonEntryConfigId.GetHashCode();
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
      if (DungeonEntryConfigId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DungeonEntryConfigId);
      }
      if (DungeonEntryScenePointId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DungeonEntryScenePointId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SceneId);
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
      if (DungeonEntryConfigId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DungeonEntryConfigId);
      }
      if (DungeonEntryScenePointId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DungeonEntryScenePointId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SceneId);
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
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (DungeonEntryScenePointId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonEntryScenePointId);
      }
      if (DungeonEntryConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonEntryConfigId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DungeonEntryToBeExploreNotify other) {
      if (other == null) {
        return;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.DungeonEntryScenePointId != 0) {
        DungeonEntryScenePointId = other.DungeonEntryScenePointId;
      }
      if (other.DungeonEntryConfigId != 0) {
        DungeonEntryConfigId = other.DungeonEntryConfigId;
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
            DungeonEntryConfigId = input.ReadUInt32();
            break;
          }
          case 24: {
            DungeonEntryScenePointId = input.ReadUInt32();
            break;
          }
          case 48: {
            SceneId = input.ReadUInt32();
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
            DungeonEntryConfigId = input.ReadUInt32();
            break;
          }
          case 24: {
            DungeonEntryScenePointId = input.ReadUInt32();
            break;
          }
          case 48: {
            SceneId = input.ReadUInt32();
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
