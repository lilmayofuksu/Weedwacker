// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryBalloonInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SceneGalleryBalloonInfo.proto</summary>
  public static partial class SceneGalleryBalloonInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGalleryBalloonInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGalleryBalloonInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1TY2VuZUdhbGxlcnlCYWxsb29uSW5mby5wcm90bxIfV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90bxoXQmFsbG9vblBsYXllckluZm8ucHJvdG8i",
            "oQIKF1NjZW5lR2FsbGVyeUJhbGxvb25JbmZvEn4KHXNjZW5lX3BsYXllcl9i",
            "YWxsb29uX2luZm9fbWFwGA0gAygLMlcuV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90by5TY2VuZUdhbGxlcnlCYWxsb29uSW5mby5TY2VuZVBsYXll",
            "ckJhbGxvb25JbmZvTWFwRW50cnkSEAoIZW5kX3RpbWUYCSABKA0adAoeU2Nl",
            "bmVQbGF5ZXJCYWxsb29uSW5mb01hcEVudHJ5EgsKA2tleRgBIAEoDRJBCgV2",
            "YWx1ZRgCIAEoCzIyLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8u",
            "QmFsbG9vblBsYXllckluZm86AjgBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.BalloonPlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.SceneGalleryBalloonInfo), global::Weedwacker.Shared.Network.Proto.SceneGalleryBalloonInfo.Parser, new[]{ "ScenePlayerBalloonInfoMap", "EndTime" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneGalleryBalloonInfo : pb::IMessage<SceneGalleryBalloonInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGalleryBalloonInfo> _parser = new pb::MessageParser<SceneGalleryBalloonInfo>(() => new SceneGalleryBalloonInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGalleryBalloonInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.SceneGalleryBalloonInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryBalloonInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryBalloonInfo(SceneGalleryBalloonInfo other) : this() {
      scenePlayerBalloonInfoMap_ = other.scenePlayerBalloonInfoMap_.Clone();
      endTime_ = other.endTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryBalloonInfo Clone() {
      return new SceneGalleryBalloonInfo(this);
    }

    /// <summary>Field number for the "scene_player_balloon_info_map" field.</summary>
    public const int ScenePlayerBalloonInfoMapFieldNumber = 13;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.BalloonPlayerInfo>.Codec _map_scenePlayerBalloonInfoMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.BalloonPlayerInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.BalloonPlayerInfo.Parser), 106);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.BalloonPlayerInfo> scenePlayerBalloonInfoMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.BalloonPlayerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.BalloonPlayerInfo> ScenePlayerBalloonInfoMap {
      get { return scenePlayerBalloonInfoMap_; }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 9;
    private uint endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneGalleryBalloonInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGalleryBalloonInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!ScenePlayerBalloonInfoMap.Equals(other.ScenePlayerBalloonInfoMap)) return false;
      if (EndTime != other.EndTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= ScenePlayerBalloonInfoMap.GetHashCode();
      if (EndTime != 0) hash ^= EndTime.GetHashCode();
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
      if (EndTime != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EndTime);
      }
      scenePlayerBalloonInfoMap_.WriteTo(output, _map_scenePlayerBalloonInfoMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EndTime != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EndTime);
      }
      scenePlayerBalloonInfoMap_.WriteTo(ref output, _map_scenePlayerBalloonInfoMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += scenePlayerBalloonInfoMap_.CalculateSize(_map_scenePlayerBalloonInfoMap_codec);
      if (EndTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EndTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneGalleryBalloonInfo other) {
      if (other == null) {
        return;
      }
      scenePlayerBalloonInfoMap_.Add(other.scenePlayerBalloonInfoMap_);
      if (other.EndTime != 0) {
        EndTime = other.EndTime;
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
          case 72: {
            EndTime = input.ReadUInt32();
            break;
          }
          case 106: {
            scenePlayerBalloonInfoMap_.AddEntriesFrom(input, _map_scenePlayerBalloonInfoMap_codec);
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
          case 72: {
            EndTime = input.ReadUInt32();
            break;
          }
          case 106: {
            scenePlayerBalloonInfoMap_.AddEntriesFrom(ref input, _map_scenePlayerBalloonInfoMap_codec);
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
