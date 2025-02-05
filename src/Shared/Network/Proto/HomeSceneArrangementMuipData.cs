// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeSceneArrangementMuipData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeSceneArrangementMuipData.proto</summary>
  public static partial class HomeSceneArrangementMuipDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeSceneArrangementMuipData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeSceneArrangementMuipDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJIb21lU2NlbmVBcnJhbmdlbWVudE11aXBEYXRhLnByb3RvEh9XZWVkd2Fj",
            "a2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvGiJIb21lQmxvY2tBcnJhbmdlbWVu",
            "dE11aXBEYXRhLnByb3RvIqwBChxIb21lU2NlbmVBcnJhbmdlbWVudE11aXBE",
            "YXRhEhEKCW1vZHVsZV9pZBgBIAEoDRIQCghzY2VuZV9pZBgCIAEoDRIPCgdp",
            "c19yb29tGAMgASgIElYKD2Jsb2NrX2RhdGFfbGlzdBgEIAMoCzI9LldlZWR3",
            "YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uSG9tZUJsb2NrQXJyYW5nZW1l",
            "bnRNdWlwRGF0YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementMuipDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeSceneArrangementMuipData), global::Weedwacker.Shared.Network.Proto.HomeSceneArrangementMuipData.Parser, new[]{ "ModuleId", "SceneId", "IsRoom", "BlockDataList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeSceneArrangementMuipData : pb::IMessage<HomeSceneArrangementMuipData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeSceneArrangementMuipData> _parser = new pb::MessageParser<HomeSceneArrangementMuipData>(() => new HomeSceneArrangementMuipData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeSceneArrangementMuipData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeSceneArrangementMuipDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeSceneArrangementMuipData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeSceneArrangementMuipData(HomeSceneArrangementMuipData other) : this() {
      moduleId_ = other.moduleId_;
      sceneId_ = other.sceneId_;
      isRoom_ = other.isRoom_;
      blockDataList_ = other.blockDataList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeSceneArrangementMuipData Clone() {
      return new HomeSceneArrangementMuipData(this);
    }

    /// <summary>Field number for the "module_id" field.</summary>
    public const int ModuleIdFieldNumber = 1;
    private uint moduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ModuleId {
      get { return moduleId_; }
      set {
        moduleId_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 2;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "is_room" field.</summary>
    public const int IsRoomFieldNumber = 3;
    private bool isRoom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRoom {
      get { return isRoom_; }
      set {
        isRoom_ = value;
      }
    }

    /// <summary>Field number for the "block_data_list" field.</summary>
    public const int BlockDataListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementMuipData> _repeated_blockDataList_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementMuipData.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementMuipData> blockDataList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementMuipData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.HomeBlockArrangementMuipData> BlockDataList {
      get { return blockDataList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeSceneArrangementMuipData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeSceneArrangementMuipData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ModuleId != other.ModuleId) return false;
      if (SceneId != other.SceneId) return false;
      if (IsRoom != other.IsRoom) return false;
      if(!blockDataList_.Equals(other.blockDataList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ModuleId != 0) hash ^= ModuleId.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (IsRoom != false) hash ^= IsRoom.GetHashCode();
      hash ^= blockDataList_.GetHashCode();
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
      if (ModuleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ModuleId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SceneId);
      }
      if (IsRoom != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsRoom);
      }
      blockDataList_.WriteTo(output, _repeated_blockDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ModuleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ModuleId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SceneId);
      }
      if (IsRoom != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsRoom);
      }
      blockDataList_.WriteTo(ref output, _repeated_blockDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ModuleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ModuleId);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (IsRoom != false) {
        size += 1 + 1;
      }
      size += blockDataList_.CalculateSize(_repeated_blockDataList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeSceneArrangementMuipData other) {
      if (other == null) {
        return;
      }
      if (other.ModuleId != 0) {
        ModuleId = other.ModuleId;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.IsRoom != false) {
        IsRoom = other.IsRoom;
      }
      blockDataList_.Add(other.blockDataList_);
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
            ModuleId = input.ReadUInt32();
            break;
          }
          case 16: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 24: {
            IsRoom = input.ReadBool();
            break;
          }
          case 34: {
            blockDataList_.AddEntriesFrom(input, _repeated_blockDataList_codec);
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
            ModuleId = input.ReadUInt32();
            break;
          }
          case 16: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 24: {
            IsRoom = input.ReadBool();
            break;
          }
          case 34: {
            blockDataList_.AddEntriesFrom(ref input, _repeated_blockDataList_codec);
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
