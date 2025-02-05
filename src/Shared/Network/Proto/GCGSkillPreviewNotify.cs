// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGSkillPreviewNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGSkillPreviewNotify.proto</summary>
  public static partial class GCGSkillPreviewNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGSkillPreviewNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGSkillPreviewNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtHQ0dTa2lsbFByZXZpZXdOb3RpZnkucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8aGkdDR0NoYW5nZU9uc3RhZ2VJbmZvLnByb3Rv",
            "GhlHQ0dTa2lsbFByZXZpZXdJbmZvLnByb3RvGiFHQ0dTa2lsbFByZXZpZXdQ",
            "bGF5Q2FyZEluZm8ucHJvdG8izQIKFUdDR1NraWxsUHJldmlld05vdGlmeRIV",
            "Cg1jb250cm9sbGVyX2lkGA0gASgNElAKEnNraWxsX3ByZXZpZXdfbGlzdBgP",
            "IAMoCzI0LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uR0NHU2tp",
            "bGxQcmV2aWV3SW5mbxJaChtjaGFuZ2Vfb25zdGFnZV9wcmV2aWV3X2xpc3QY",
            "AyADKAsyNS5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkdDR0No",
            "YW5nZU9uc3RhZ2VJbmZvElQKDnBsYXlfY2FyZF9saXN0GAsgAygLMjwuV2Vl",
            "ZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5HQ0dTa2lsbFByZXZpZXdQ",
            "bGF5Q2FyZEluZm8SGQoRb25zdGFnZV9jYXJkX2d1aWQYBiABKA1iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGChangeOnstageInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewPlayCardInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewNotify), global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewNotify.Parser, new[]{ "ControllerId", "SkillPreviewList", "ChangeOnstagePreviewList", "PlayCardList", "OnstageCardGuid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 7659;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GCGSkillPreviewNotify : pb::IMessage<GCGSkillPreviewNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGSkillPreviewNotify> _parser = new pb::MessageParser<GCGSkillPreviewNotify>(() => new GCGSkillPreviewNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGSkillPreviewNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewNotify(GCGSkillPreviewNotify other) : this() {
      controllerId_ = other.controllerId_;
      skillPreviewList_ = other.skillPreviewList_.Clone();
      changeOnstagePreviewList_ = other.changeOnstagePreviewList_.Clone();
      playCardList_ = other.playCardList_.Clone();
      onstageCardGuid_ = other.onstageCardGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGSkillPreviewNotify Clone() {
      return new GCGSkillPreviewNotify(this);
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 13;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    /// <summary>Field number for the "skill_preview_list" field.</summary>
    public const int SkillPreviewListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfo> _repeated_skillPreviewList_codec
        = pb::FieldCodec.ForMessage(122, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfo> skillPreviewList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewInfo> SkillPreviewList {
      get { return skillPreviewList_; }
    }

    /// <summary>Field number for the "change_onstage_preview_list" field.</summary>
    public const int ChangeOnstagePreviewListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGChangeOnstageInfo> _repeated_changeOnstagePreviewList_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Shared.Network.Proto.GCGChangeOnstageInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGChangeOnstageInfo> changeOnstagePreviewList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGChangeOnstageInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGChangeOnstageInfo> ChangeOnstagePreviewList {
      get { return changeOnstagePreviewList_; }
    }

    /// <summary>Field number for the "play_card_list" field.</summary>
    public const int PlayCardListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewPlayCardInfo> _repeated_playCardList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewPlayCardInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewPlayCardInfo> playCardList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewPlayCardInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSkillPreviewPlayCardInfo> PlayCardList {
      get { return playCardList_; }
    }

    /// <summary>Field number for the "onstage_card_guid" field.</summary>
    public const int OnstageCardGuidFieldNumber = 6;
    private uint onstageCardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OnstageCardGuid {
      get { return onstageCardGuid_; }
      set {
        onstageCardGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGSkillPreviewNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGSkillPreviewNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ControllerId != other.ControllerId) return false;
      if(!skillPreviewList_.Equals(other.skillPreviewList_)) return false;
      if(!changeOnstagePreviewList_.Equals(other.changeOnstagePreviewList_)) return false;
      if(!playCardList_.Equals(other.playCardList_)) return false;
      if (OnstageCardGuid != other.OnstageCardGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
      hash ^= skillPreviewList_.GetHashCode();
      hash ^= changeOnstagePreviewList_.GetHashCode();
      hash ^= playCardList_.GetHashCode();
      if (OnstageCardGuid != 0) hash ^= OnstageCardGuid.GetHashCode();
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
      changeOnstagePreviewList_.WriteTo(output, _repeated_changeOnstagePreviewList_codec);
      if (OnstageCardGuid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(OnstageCardGuid);
      }
      playCardList_.WriteTo(output, _repeated_playCardList_codec);
      if (ControllerId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ControllerId);
      }
      skillPreviewList_.WriteTo(output, _repeated_skillPreviewList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      changeOnstagePreviewList_.WriteTo(ref output, _repeated_changeOnstagePreviewList_codec);
      if (OnstageCardGuid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(OnstageCardGuid);
      }
      playCardList_.WriteTo(ref output, _repeated_playCardList_codec);
      if (ControllerId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ControllerId);
      }
      skillPreviewList_.WriteTo(ref output, _repeated_skillPreviewList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      size += skillPreviewList_.CalculateSize(_repeated_skillPreviewList_codec);
      size += changeOnstagePreviewList_.CalculateSize(_repeated_changeOnstagePreviewList_codec);
      size += playCardList_.CalculateSize(_repeated_playCardList_codec);
      if (OnstageCardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OnstageCardGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGSkillPreviewNotify other) {
      if (other == null) {
        return;
      }
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
      }
      skillPreviewList_.Add(other.skillPreviewList_);
      changeOnstagePreviewList_.Add(other.changeOnstagePreviewList_);
      playCardList_.Add(other.playCardList_);
      if (other.OnstageCardGuid != 0) {
        OnstageCardGuid = other.OnstageCardGuid;
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
          case 26: {
            changeOnstagePreviewList_.AddEntriesFrom(input, _repeated_changeOnstagePreviewList_codec);
            break;
          }
          case 48: {
            OnstageCardGuid = input.ReadUInt32();
            break;
          }
          case 90: {
            playCardList_.AddEntriesFrom(input, _repeated_playCardList_codec);
            break;
          }
          case 104: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 122: {
            skillPreviewList_.AddEntriesFrom(input, _repeated_skillPreviewList_codec);
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
          case 26: {
            changeOnstagePreviewList_.AddEntriesFrom(ref input, _repeated_changeOnstagePreviewList_codec);
            break;
          }
          case 48: {
            OnstageCardGuid = input.ReadUInt32();
            break;
          }
          case 90: {
            playCardList_.AddEntriesFrom(ref input, _repeated_playCardList_codec);
            break;
          }
          case 104: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 122: {
            skillPreviewList_.AddEntriesFrom(ref input, _repeated_skillPreviewList_codec);
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
