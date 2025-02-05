// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayTeamEntityInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from PlayTeamEntityInfo.proto</summary>
  public static partial class PlayTeamEntityInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayTeamEntityInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayTeamEntityInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhQbGF5VGVhbUVudGl0eUluZm8ucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVk",
            "Lk5ldHdvcmsuUHJvdG8aGkFiaWxpdHlTeW5jU3RhdGVJbmZvLnByb3RvIr0B",
            "ChJQbGF5VGVhbUVudGl0eUluZm8SEQoJZW50aXR5X2lkGAEgASgNEhIKCnBs",
            "YXllcl91aWQYAiABKA0SGQoRYXV0aG9yaXR5X3BlZXJfaWQYAyABKA0SGAoQ",
            "Z2FkZ2V0X2NvbmZpZ19pZBgFIAEoDRJLCgxhYmlsaXR5X2luZm8YBiABKAsy",
            "NS5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkFiaWxpdHlTeW5j",
            "U3RhdGVJbmZvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.AbilitySyncStateInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.PlayTeamEntityInfo), global::Weedwacker.Shared.Network.Proto.PlayTeamEntityInfo.Parser, new[]{ "EntityId", "PlayerUid", "AuthorityPeerId", "GadgetConfigId", "AbilityInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayTeamEntityInfo : pb::IMessage<PlayTeamEntityInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayTeamEntityInfo> _parser = new pb::MessageParser<PlayTeamEntityInfo>(() => new PlayTeamEntityInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayTeamEntityInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.PlayTeamEntityInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayTeamEntityInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayTeamEntityInfo(PlayTeamEntityInfo other) : this() {
      entityId_ = other.entityId_;
      playerUid_ = other.playerUid_;
      authorityPeerId_ = other.authorityPeerId_;
      gadgetConfigId_ = other.gadgetConfigId_;
      abilityInfo_ = other.abilityInfo_ != null ? other.abilityInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayTeamEntityInfo Clone() {
      return new PlayTeamEntityInfo(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "player_uid" field.</summary>
    public const int PlayerUidFieldNumber = 2;
    private uint playerUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayerUid {
      get { return playerUid_; }
      set {
        playerUid_ = value;
      }
    }

    /// <summary>Field number for the "authority_peer_id" field.</summary>
    public const int AuthorityPeerIdFieldNumber = 3;
    private uint authorityPeerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AuthorityPeerId {
      get { return authorityPeerId_; }
      set {
        authorityPeerId_ = value;
      }
    }

    /// <summary>Field number for the "gadget_config_id" field.</summary>
    public const int GadgetConfigIdFieldNumber = 5;
    private uint gadgetConfigId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetConfigId {
      get { return gadgetConfigId_; }
      set {
        gadgetConfigId_ = value;
      }
    }

    /// <summary>Field number for the "ability_info" field.</summary>
    public const int AbilityInfoFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.AbilitySyncStateInfo abilityInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.AbilitySyncStateInfo AbilityInfo {
      get { return abilityInfo_; }
      set {
        abilityInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayTeamEntityInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayTeamEntityInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (PlayerUid != other.PlayerUid) return false;
      if (AuthorityPeerId != other.AuthorityPeerId) return false;
      if (GadgetConfigId != other.GadgetConfigId) return false;
      if (!object.Equals(AbilityInfo, other.AbilityInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (PlayerUid != 0) hash ^= PlayerUid.GetHashCode();
      if (AuthorityPeerId != 0) hash ^= AuthorityPeerId.GetHashCode();
      if (GadgetConfigId != 0) hash ^= GadgetConfigId.GetHashCode();
      if (abilityInfo_ != null) hash ^= AbilityInfo.GetHashCode();
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
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (PlayerUid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(PlayerUid);
      }
      if (AuthorityPeerId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(AuthorityPeerId);
      }
      if (GadgetConfigId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GadgetConfigId);
      }
      if (abilityInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(AbilityInfo);
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
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (PlayerUid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(PlayerUid);
      }
      if (AuthorityPeerId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(AuthorityPeerId);
      }
      if (GadgetConfigId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GadgetConfigId);
      }
      if (abilityInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(AbilityInfo);
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
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (PlayerUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayerUid);
      }
      if (AuthorityPeerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AuthorityPeerId);
      }
      if (GadgetConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetConfigId);
      }
      if (abilityInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AbilityInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayTeamEntityInfo other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.PlayerUid != 0) {
        PlayerUid = other.PlayerUid;
      }
      if (other.AuthorityPeerId != 0) {
        AuthorityPeerId = other.AuthorityPeerId;
      }
      if (other.GadgetConfigId != 0) {
        GadgetConfigId = other.GadgetConfigId;
      }
      if (other.abilityInfo_ != null) {
        if (abilityInfo_ == null) {
          AbilityInfo = new global::Weedwacker.Shared.Network.Proto.AbilitySyncStateInfo();
        }
        AbilityInfo.MergeFrom(other.AbilityInfo);
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
          case 8: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            PlayerUid = input.ReadUInt32();
            break;
          }
          case 24: {
            AuthorityPeerId = input.ReadUInt32();
            break;
          }
          case 40: {
            GadgetConfigId = input.ReadUInt32();
            break;
          }
          case 50: {
            if (abilityInfo_ == null) {
              AbilityInfo = new global::Weedwacker.Shared.Network.Proto.AbilitySyncStateInfo();
            }
            input.ReadMessage(AbilityInfo);
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            PlayerUid = input.ReadUInt32();
            break;
          }
          case 24: {
            AuthorityPeerId = input.ReadUInt32();
            break;
          }
          case 40: {
            GadgetConfigId = input.ReadUInt32();
            break;
          }
          case 50: {
            if (abilityInfo_ == null) {
              AbilityInfo = new global::Weedwacker.Shared.Network.Proto.AbilitySyncStateInfo();
            }
            input.ReadMessage(AbilityInfo);
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
