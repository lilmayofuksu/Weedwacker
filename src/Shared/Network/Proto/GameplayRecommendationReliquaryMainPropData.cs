// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GameplayRecommendationReliquaryMainPropData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GameplayRecommendationReliquaryMainPropData.proto</summary>
  public static partial class GameplayRecommendationReliquaryMainPropDataReflection {

    #region Descriptor
    /// <summary>File descriptor for GameplayRecommendationReliquaryMainPropData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameplayRecommendationReliquaryMainPropDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFHYW1lcGxheVJlY29tbWVuZGF0aW9uUmVsaXF1YXJ5TWFpblByb3BEYXRh",
            "LnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvIlcKK0dh",
            "bWVwbGF5UmVjb21tZW5kYXRpb25SZWxpcXVhcnlNYWluUHJvcERhdGESEgoK",
            "cGVybWlsbGFnZRgFIAEoDRIUCgxtYWluX3Byb3BfaWQYCiABKA1iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropData), global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropData.Parser, new[]{ "Permillage", "MainPropId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GameplayRecommendationReliquaryMainPropData : pb::IMessage<GameplayRecommendationReliquaryMainPropData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GameplayRecommendationReliquaryMainPropData> _parser = new pb::MessageParser<GameplayRecommendationReliquaryMainPropData>(() => new GameplayRecommendationReliquaryMainPropData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GameplayRecommendationReliquaryMainPropData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GameplayRecommendationReliquaryMainPropDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameplayRecommendationReliquaryMainPropData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameplayRecommendationReliquaryMainPropData(GameplayRecommendationReliquaryMainPropData other) : this() {
      permillage_ = other.permillage_;
      mainPropId_ = other.mainPropId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GameplayRecommendationReliquaryMainPropData Clone() {
      return new GameplayRecommendationReliquaryMainPropData(this);
    }

    /// <summary>Field number for the "permillage" field.</summary>
    public const int PermillageFieldNumber = 5;
    private uint permillage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Permillage {
      get { return permillage_; }
      set {
        permillage_ = value;
      }
    }

    /// <summary>Field number for the "main_prop_id" field.</summary>
    public const int MainPropIdFieldNumber = 10;
    private uint mainPropId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MainPropId {
      get { return mainPropId_; }
      set {
        mainPropId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GameplayRecommendationReliquaryMainPropData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GameplayRecommendationReliquaryMainPropData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Permillage != other.Permillage) return false;
      if (MainPropId != other.MainPropId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Permillage != 0) hash ^= Permillage.GetHashCode();
      if (MainPropId != 0) hash ^= MainPropId.GetHashCode();
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
      if (Permillage != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Permillage);
      }
      if (MainPropId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MainPropId);
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
      if (Permillage != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Permillage);
      }
      if (MainPropId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MainPropId);
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
      if (Permillage != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Permillage);
      }
      if (MainPropId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MainPropId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GameplayRecommendationReliquaryMainPropData other) {
      if (other == null) {
        return;
      }
      if (other.Permillage != 0) {
        Permillage = other.Permillage;
      }
      if (other.MainPropId != 0) {
        MainPropId = other.MainPropId;
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
          case 40: {
            Permillage = input.ReadUInt32();
            break;
          }
          case 80: {
            MainPropId = input.ReadUInt32();
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
          case 40: {
            Permillage = input.ReadUInt32();
            break;
          }
          case 80: {
            MainPropId = input.ReadUInt32();
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
