// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WinterCampStageInfoChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WinterCampStageInfoChangeNotify.proto</summary>
  public static partial class WinterCampStageInfoChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for WinterCampStageInfoChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WinterCampStageInfoChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVXaW50ZXJDYW1wU3RhZ2VJbmZvQ2hhbmdlTm90aWZ5LnByb3RvEh9XZWVk",
            "d2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvGhlXaW50ZXJDYW1wU3RhZ2VJ",
            "bmZvLnByb3RvIrgBCh9XaW50ZXJDYW1wU3RhZ2VJbmZvQ2hhbmdlTm90aWZ5",
            "EkoKDGV4cGxvcmVfaW5mbxgFIAEoCzI0LldlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG8uV2ludGVyQ2FtcFN0YWdlSW5mbxJJCgtiYXR0bGVfaW5m",
            "bxgPIAEoCzI0LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uV2lu",
            "dGVyQ2FtcFN0YWdlSW5mb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.WinterCampStageInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WinterCampStageInfoChangeNotify), global::Weedwacker.Shared.Network.Proto.WinterCampStageInfoChangeNotify.Parser, new[]{ "ExploreInfo", "BattleInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8878;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class WinterCampStageInfoChangeNotify : pb::IMessage<WinterCampStageInfoChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WinterCampStageInfoChangeNotify> _parser = new pb::MessageParser<WinterCampStageInfoChangeNotify>(() => new WinterCampStageInfoChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WinterCampStageInfoChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WinterCampStageInfoChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampStageInfoChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampStageInfoChangeNotify(WinterCampStageInfoChangeNotify other) : this() {
      exploreInfo_ = other.exploreInfo_ != null ? other.exploreInfo_.Clone() : null;
      battleInfo_ = other.battleInfo_ != null ? other.battleInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampStageInfoChangeNotify Clone() {
      return new WinterCampStageInfoChangeNotify(this);
    }

    /// <summary>Field number for the "explore_info" field.</summary>
    public const int ExploreInfoFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.WinterCampStageInfo exploreInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.WinterCampStageInfo ExploreInfo {
      get { return exploreInfo_; }
      set {
        exploreInfo_ = value;
      }
    }

    /// <summary>Field number for the "battle_info" field.</summary>
    public const int BattleInfoFieldNumber = 15;
    private global::Weedwacker.Shared.Network.Proto.WinterCampStageInfo battleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.WinterCampStageInfo BattleInfo {
      get { return battleInfo_; }
      set {
        battleInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WinterCampStageInfoChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WinterCampStageInfoChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ExploreInfo, other.ExploreInfo)) return false;
      if (!object.Equals(BattleInfo, other.BattleInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (exploreInfo_ != null) hash ^= ExploreInfo.GetHashCode();
      if (battleInfo_ != null) hash ^= BattleInfo.GetHashCode();
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
      if (exploreInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ExploreInfo);
      }
      if (battleInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(BattleInfo);
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
      if (exploreInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ExploreInfo);
      }
      if (battleInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(BattleInfo);
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
      if (exploreInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExploreInfo);
      }
      if (battleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WinterCampStageInfoChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.exploreInfo_ != null) {
        if (exploreInfo_ == null) {
          ExploreInfo = new global::Weedwacker.Shared.Network.Proto.WinterCampStageInfo();
        }
        ExploreInfo.MergeFrom(other.ExploreInfo);
      }
      if (other.battleInfo_ != null) {
        if (battleInfo_ == null) {
          BattleInfo = new global::Weedwacker.Shared.Network.Proto.WinterCampStageInfo();
        }
        BattleInfo.MergeFrom(other.BattleInfo);
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
          case 42: {
            if (exploreInfo_ == null) {
              ExploreInfo = new global::Weedwacker.Shared.Network.Proto.WinterCampStageInfo();
            }
            input.ReadMessage(ExploreInfo);
            break;
          }
          case 122: {
            if (battleInfo_ == null) {
              BattleInfo = new global::Weedwacker.Shared.Network.Proto.WinterCampStageInfo();
            }
            input.ReadMessage(BattleInfo);
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
          case 42: {
            if (exploreInfo_ == null) {
              ExploreInfo = new global::Weedwacker.Shared.Network.Proto.WinterCampStageInfo();
            }
            input.ReadMessage(ExploreInfo);
            break;
          }
          case 122: {
            if (battleInfo_ == null) {
              BattleInfo = new global::Weedwacker.Shared.Network.Proto.WinterCampStageInfo();
            }
            input.ReadMessage(BattleInfo);
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
