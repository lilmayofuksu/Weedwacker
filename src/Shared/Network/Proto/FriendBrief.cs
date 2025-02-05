// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FriendBrief.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FriendBrief.proto</summary>
  public static partial class FriendBriefReflection {

    #region Descriptor
    /// <summary>File descriptor for FriendBrief.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FriendBriefReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFGcmllbmRCcmllZi5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90bxobRnJpZW5kRW50ZXJIb21lT3B0aW9uLnByb3RvGhdGcmllbmRP",
            "bmxpbmVTdGF0ZS5wcm90bxoSUGxhdGZvcm1UeXBlLnByb3RvGhRQcm9maWxl",
            "UGljdHVyZS5wcm90bxoaU29jaWFsU2hvd0F2YXRhckluZm8ucHJvdG8i/gUK",
            "C0ZyaWVuZEJyaWVmEgsKA3VpZBgBIAEoDRIQCghuaWNrbmFtZRgCIAEoCRIN",
            "CgVsZXZlbBgDIAEoDRIRCglhdmF0YXJfaWQYBCABKA0SEwoLd29ybGRfbGV2",
            "ZWwYBSABKA0SEQoJc2lnbmF0dXJlGAYgASgJEkgKDG9ubGluZV9zdGF0ZRgH",
            "IAEoDjIyLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uRnJpZW5k",
            "T25saW5lU3RhdGUSDQoFcGFyYW0YCCABKA0SHAoUaXNfbXBfbW9kZV9hdmFp",
            "bGFibGUYCiABKAgSEQoJb25saW5lX2lkGAsgASgJEhgKEGxhc3RfYWN0aXZl",
            "X3RpbWUYDCABKA0SFAoMbmFtZV9jYXJkX2lkGA0gASgNEhUKDW1wX3BsYXll",
            "cl9udW0YDiABKA0SGgoSaXNfY2hhdF9ub19kaXN0dXJiGA8gASgIEhUKDWNo",
            "YXRfc2VxdWVuY2UYECABKA0SEwoLcmVtYXJrX25hbWUYESABKAkSVAoVc2hv",
            "d19hdmF0YXJfaW5mb19saXN0GBYgAygLMjUuV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90by5Tb2NpYWxTaG93QXZhdGFySW5mbxJYChhmcmllbmRf",
            "ZW50ZXJfaG9tZV9vcHRpb24YFyABKA4yNi5XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvLkZyaWVuZEVudGVySG9tZU9wdGlvbhJICg9wcm9maWxl",
            "X3BpY3R1cmUYGCABKAsyLy5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlBy",
            "b3RvLlByb2ZpbGVQaWN0dXJlEhYKDmlzX2dhbWVfc291cmNlGBkgASgIEhUK",
            "DWlzX3Bzbl9zb3VyY2UYGiABKAgSRAoNcGxhdGZvcm1fdHlwZRgbIAEoDjIt",
            "LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uUGxhdGZvcm1UeXBl",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOptionReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.FriendOnlineStateReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.PlatformTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ProfilePictureReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.SocialShowAvatarInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FriendBrief), global::Weedwacker.Shared.Network.Proto.FriendBrief.Parser, new[]{ "Uid", "Nickname", "Level", "AvatarId", "WorldLevel", "Signature", "OnlineState", "Param", "IsMpModeAvailable", "OnlineId", "LastActiveTime", "NameCardId", "MpPlayerNum", "IsChatNoDisturb", "ChatSequence", "RemarkName", "ShowAvatarInfoList", "FriendEnterHomeOption", "ProfilePicture", "IsGameSource", "IsPsnSource", "PlatformType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FriendBrief : pb::IMessage<FriendBrief>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FriendBrief> _parser = new pb::MessageParser<FriendBrief>(() => new FriendBrief());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FriendBrief> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FriendBriefReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FriendBrief() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FriendBrief(FriendBrief other) : this() {
      uid_ = other.uid_;
      nickname_ = other.nickname_;
      level_ = other.level_;
      avatarId_ = other.avatarId_;
      worldLevel_ = other.worldLevel_;
      signature_ = other.signature_;
      onlineState_ = other.onlineState_;
      param_ = other.param_;
      isMpModeAvailable_ = other.isMpModeAvailable_;
      onlineId_ = other.onlineId_;
      lastActiveTime_ = other.lastActiveTime_;
      nameCardId_ = other.nameCardId_;
      mpPlayerNum_ = other.mpPlayerNum_;
      isChatNoDisturb_ = other.isChatNoDisturb_;
      chatSequence_ = other.chatSequence_;
      remarkName_ = other.remarkName_;
      showAvatarInfoList_ = other.showAvatarInfoList_.Clone();
      friendEnterHomeOption_ = other.friendEnterHomeOption_;
      profilePicture_ = other.profilePicture_ != null ? other.profilePicture_.Clone() : null;
      isGameSource_ = other.isGameSource_;
      isPsnSource_ = other.isPsnSource_;
      platformType_ = other.platformType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FriendBrief Clone() {
      return new FriendBrief(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 1;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 2;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 3;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 4;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 5;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 6;
    private string signature_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "online_state" field.</summary>
    public const int OnlineStateFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.FriendOnlineState onlineState_ = global::Weedwacker.Shared.Network.Proto.FriendOnlineState.Disconnect;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.FriendOnlineState OnlineState {
      get { return onlineState_; }
      set {
        onlineState_ = value;
      }
    }

    /// <summary>Field number for the "param" field.</summary>
    public const int ParamFieldNumber = 8;
    private uint param_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Param {
      get { return param_; }
      set {
        param_ = value;
      }
    }

    /// <summary>Field number for the "is_mp_mode_available" field.</summary>
    public const int IsMpModeAvailableFieldNumber = 10;
    private bool isMpModeAvailable_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsMpModeAvailable {
      get { return isMpModeAvailable_; }
      set {
        isMpModeAvailable_ = value;
      }
    }

    /// <summary>Field number for the "online_id" field.</summary>
    public const int OnlineIdFieldNumber = 11;
    private string onlineId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OnlineId {
      get { return onlineId_; }
      set {
        onlineId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_active_time" field.</summary>
    public const int LastActiveTimeFieldNumber = 12;
    private uint lastActiveTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastActiveTime {
      get { return lastActiveTime_; }
      set {
        lastActiveTime_ = value;
      }
    }

    /// <summary>Field number for the "name_card_id" field.</summary>
    public const int NameCardIdFieldNumber = 13;
    private uint nameCardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NameCardId {
      get { return nameCardId_; }
      set {
        nameCardId_ = value;
      }
    }

    /// <summary>Field number for the "mp_player_num" field.</summary>
    public const int MpPlayerNumFieldNumber = 14;
    private uint mpPlayerNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MpPlayerNum {
      get { return mpPlayerNum_; }
      set {
        mpPlayerNum_ = value;
      }
    }

    /// <summary>Field number for the "is_chat_no_disturb" field.</summary>
    public const int IsChatNoDisturbFieldNumber = 15;
    private bool isChatNoDisturb_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsChatNoDisturb {
      get { return isChatNoDisturb_; }
      set {
        isChatNoDisturb_ = value;
      }
    }

    /// <summary>Field number for the "chat_sequence" field.</summary>
    public const int ChatSequenceFieldNumber = 16;
    private uint chatSequence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChatSequence {
      get { return chatSequence_; }
      set {
        chatSequence_ = value;
      }
    }

    /// <summary>Field number for the "remark_name" field.</summary>
    public const int RemarkNameFieldNumber = 17;
    private string remarkName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RemarkName {
      get { return remarkName_; }
      set {
        remarkName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "show_avatar_info_list" field.</summary>
    public const int ShowAvatarInfoListFieldNumber = 22;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.SocialShowAvatarInfo> _repeated_showAvatarInfoList_codec
        = pb::FieldCodec.ForMessage(178, global::Weedwacker.Shared.Network.Proto.SocialShowAvatarInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SocialShowAvatarInfo> showAvatarInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SocialShowAvatarInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SocialShowAvatarInfo> ShowAvatarInfoList {
      get { return showAvatarInfoList_; }
    }

    /// <summary>Field number for the "friend_enter_home_option" field.</summary>
    public const int FriendEnterHomeOptionFieldNumber = 23;
    private global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption friendEnterHomeOption_ = global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption.NeedConfirm;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption FriendEnterHomeOption {
      get { return friendEnterHomeOption_; }
      set {
        friendEnterHomeOption_ = value;
      }
    }

    /// <summary>Field number for the "profile_picture" field.</summary>
    public const int ProfilePictureFieldNumber = 24;
    private global::Weedwacker.Shared.Network.Proto.ProfilePicture profilePicture_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ProfilePicture ProfilePicture {
      get { return profilePicture_; }
      set {
        profilePicture_ = value;
      }
    }

    /// <summary>Field number for the "is_game_source" field.</summary>
    public const int IsGameSourceFieldNumber = 25;
    private bool isGameSource_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsGameSource {
      get { return isGameSource_; }
      set {
        isGameSource_ = value;
      }
    }

    /// <summary>Field number for the "is_psn_source" field.</summary>
    public const int IsPsnSourceFieldNumber = 26;
    private bool isPsnSource_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPsnSource {
      get { return isPsnSource_; }
      set {
        isPsnSource_ = value;
      }
    }

    /// <summary>Field number for the "platform_type" field.</summary>
    public const int PlatformTypeFieldNumber = 27;
    private global::Weedwacker.Shared.Network.Proto.PlatformType platformType_ = global::Weedwacker.Shared.Network.Proto.PlatformType.Editor;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.PlatformType PlatformType {
      get { return platformType_; }
      set {
        platformType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FriendBrief);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FriendBrief other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (Nickname != other.Nickname) return false;
      if (Level != other.Level) return false;
      if (AvatarId != other.AvatarId) return false;
      if (WorldLevel != other.WorldLevel) return false;
      if (Signature != other.Signature) return false;
      if (OnlineState != other.OnlineState) return false;
      if (Param != other.Param) return false;
      if (IsMpModeAvailable != other.IsMpModeAvailable) return false;
      if (OnlineId != other.OnlineId) return false;
      if (LastActiveTime != other.LastActiveTime) return false;
      if (NameCardId != other.NameCardId) return false;
      if (MpPlayerNum != other.MpPlayerNum) return false;
      if (IsChatNoDisturb != other.IsChatNoDisturb) return false;
      if (ChatSequence != other.ChatSequence) return false;
      if (RemarkName != other.RemarkName) return false;
      if(!showAvatarInfoList_.Equals(other.showAvatarInfoList_)) return false;
      if (FriendEnterHomeOption != other.FriendEnterHomeOption) return false;
      if (!object.Equals(ProfilePicture, other.ProfilePicture)) return false;
      if (IsGameSource != other.IsGameSource) return false;
      if (IsPsnSource != other.IsPsnSource) return false;
      if (PlatformType != other.PlatformType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      if (OnlineState != global::Weedwacker.Shared.Network.Proto.FriendOnlineState.Disconnect) hash ^= OnlineState.GetHashCode();
      if (Param != 0) hash ^= Param.GetHashCode();
      if (IsMpModeAvailable != false) hash ^= IsMpModeAvailable.GetHashCode();
      if (OnlineId.Length != 0) hash ^= OnlineId.GetHashCode();
      if (LastActiveTime != 0) hash ^= LastActiveTime.GetHashCode();
      if (NameCardId != 0) hash ^= NameCardId.GetHashCode();
      if (MpPlayerNum != 0) hash ^= MpPlayerNum.GetHashCode();
      if (IsChatNoDisturb != false) hash ^= IsChatNoDisturb.GetHashCode();
      if (ChatSequence != 0) hash ^= ChatSequence.GetHashCode();
      if (RemarkName.Length != 0) hash ^= RemarkName.GetHashCode();
      hash ^= showAvatarInfoList_.GetHashCode();
      if (FriendEnterHomeOption != global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption.NeedConfirm) hash ^= FriendEnterHomeOption.GetHashCode();
      if (profilePicture_ != null) hash ^= ProfilePicture.GetHashCode();
      if (IsGameSource != false) hash ^= IsGameSource.GetHashCode();
      if (IsPsnSource != false) hash ^= IsPsnSource.GetHashCode();
      if (PlatformType != global::Weedwacker.Shared.Network.Proto.PlatformType.Editor) hash ^= PlatformType.GetHashCode();
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
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Nickname);
      }
      if (Level != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Level);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AvatarId);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(WorldLevel);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Signature);
      }
      if (OnlineState != global::Weedwacker.Shared.Network.Proto.FriendOnlineState.Disconnect) {
        output.WriteRawTag(56);
        output.WriteEnum((int) OnlineState);
      }
      if (Param != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Param);
      }
      if (IsMpModeAvailable != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsMpModeAvailable);
      }
      if (OnlineId.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(OnlineId);
      }
      if (LastActiveTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LastActiveTime);
      }
      if (NameCardId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(NameCardId);
      }
      if (MpPlayerNum != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MpPlayerNum);
      }
      if (IsChatNoDisturb != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsChatNoDisturb);
      }
      if (ChatSequence != 0) {
        output.WriteRawTag(128, 1);
        output.WriteUInt32(ChatSequence);
      }
      if (RemarkName.Length != 0) {
        output.WriteRawTag(138, 1);
        output.WriteString(RemarkName);
      }
      showAvatarInfoList_.WriteTo(output, _repeated_showAvatarInfoList_codec);
      if (FriendEnterHomeOption != global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption.NeedConfirm) {
        output.WriteRawTag(184, 1);
        output.WriteEnum((int) FriendEnterHomeOption);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(194, 1);
        output.WriteMessage(ProfilePicture);
      }
      if (IsGameSource != false) {
        output.WriteRawTag(200, 1);
        output.WriteBool(IsGameSource);
      }
      if (IsPsnSource != false) {
        output.WriteRawTag(208, 1);
        output.WriteBool(IsPsnSource);
      }
      if (PlatformType != global::Weedwacker.Shared.Network.Proto.PlatformType.Editor) {
        output.WriteRawTag(216, 1);
        output.WriteEnum((int) PlatformType);
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
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Nickname);
      }
      if (Level != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Level);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AvatarId);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(WorldLevel);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Signature);
      }
      if (OnlineState != global::Weedwacker.Shared.Network.Proto.FriendOnlineState.Disconnect) {
        output.WriteRawTag(56);
        output.WriteEnum((int) OnlineState);
      }
      if (Param != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Param);
      }
      if (IsMpModeAvailable != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsMpModeAvailable);
      }
      if (OnlineId.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(OnlineId);
      }
      if (LastActiveTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LastActiveTime);
      }
      if (NameCardId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(NameCardId);
      }
      if (MpPlayerNum != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MpPlayerNum);
      }
      if (IsChatNoDisturb != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsChatNoDisturb);
      }
      if (ChatSequence != 0) {
        output.WriteRawTag(128, 1);
        output.WriteUInt32(ChatSequence);
      }
      if (RemarkName.Length != 0) {
        output.WriteRawTag(138, 1);
        output.WriteString(RemarkName);
      }
      showAvatarInfoList_.WriteTo(ref output, _repeated_showAvatarInfoList_codec);
      if (FriendEnterHomeOption != global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption.NeedConfirm) {
        output.WriteRawTag(184, 1);
        output.WriteEnum((int) FriendEnterHomeOption);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(194, 1);
        output.WriteMessage(ProfilePicture);
      }
      if (IsGameSource != false) {
        output.WriteRawTag(200, 1);
        output.WriteBool(IsGameSource);
      }
      if (IsPsnSource != false) {
        output.WriteRawTag(208, 1);
        output.WriteBool(IsPsnSource);
      }
      if (PlatformType != global::Weedwacker.Shared.Network.Proto.PlatformType.Editor) {
        output.WriteRawTag(216, 1);
        output.WriteEnum((int) PlatformType);
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
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Signature);
      }
      if (OnlineState != global::Weedwacker.Shared.Network.Proto.FriendOnlineState.Disconnect) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OnlineState);
      }
      if (Param != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Param);
      }
      if (IsMpModeAvailable != false) {
        size += 1 + 1;
      }
      if (OnlineId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OnlineId);
      }
      if (LastActiveTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastActiveTime);
      }
      if (NameCardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NameCardId);
      }
      if (MpPlayerNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MpPlayerNum);
      }
      if (IsChatNoDisturb != false) {
        size += 1 + 1;
      }
      if (ChatSequence != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(ChatSequence);
      }
      if (RemarkName.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(RemarkName);
      }
      size += showAvatarInfoList_.CalculateSize(_repeated_showAvatarInfoList_codec);
      if (FriendEnterHomeOption != global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption.NeedConfirm) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) FriendEnterHomeOption);
      }
      if (profilePicture_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(ProfilePicture);
      }
      if (IsGameSource != false) {
        size += 2 + 1;
      }
      if (IsPsnSource != false) {
        size += 2 + 1;
      }
      if (PlatformType != global::Weedwacker.Shared.Network.Proto.PlatformType.Editor) {
        size += 2 + pb::CodedOutputStream.ComputeEnumSize((int) PlatformType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FriendBrief other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      if (other.OnlineState != global::Weedwacker.Shared.Network.Proto.FriendOnlineState.Disconnect) {
        OnlineState = other.OnlineState;
      }
      if (other.Param != 0) {
        Param = other.Param;
      }
      if (other.IsMpModeAvailable != false) {
        IsMpModeAvailable = other.IsMpModeAvailable;
      }
      if (other.OnlineId.Length != 0) {
        OnlineId = other.OnlineId;
      }
      if (other.LastActiveTime != 0) {
        LastActiveTime = other.LastActiveTime;
      }
      if (other.NameCardId != 0) {
        NameCardId = other.NameCardId;
      }
      if (other.MpPlayerNum != 0) {
        MpPlayerNum = other.MpPlayerNum;
      }
      if (other.IsChatNoDisturb != false) {
        IsChatNoDisturb = other.IsChatNoDisturb;
      }
      if (other.ChatSequence != 0) {
        ChatSequence = other.ChatSequence;
      }
      if (other.RemarkName.Length != 0) {
        RemarkName = other.RemarkName;
      }
      showAvatarInfoList_.Add(other.showAvatarInfoList_);
      if (other.FriendEnterHomeOption != global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption.NeedConfirm) {
        FriendEnterHomeOption = other.FriendEnterHomeOption;
      }
      if (other.profilePicture_ != null) {
        if (profilePicture_ == null) {
          ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
        }
        ProfilePicture.MergeFrom(other.ProfilePicture);
      }
      if (other.IsGameSource != false) {
        IsGameSource = other.IsGameSource;
      }
      if (other.IsPsnSource != false) {
        IsPsnSource = other.IsPsnSource;
      }
      if (other.PlatformType != global::Weedwacker.Shared.Network.Proto.PlatformType.Editor) {
        PlatformType = other.PlatformType;
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
            Uid = input.ReadUInt32();
            break;
          }
          case 18: {
            Nickname = input.ReadString();
            break;
          }
          case 24: {
            Level = input.ReadUInt32();
            break;
          }
          case 32: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 40: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 50: {
            Signature = input.ReadString();
            break;
          }
          case 56: {
            OnlineState = (global::Weedwacker.Shared.Network.Proto.FriendOnlineState) input.ReadEnum();
            break;
          }
          case 64: {
            Param = input.ReadUInt32();
            break;
          }
          case 80: {
            IsMpModeAvailable = input.ReadBool();
            break;
          }
          case 90: {
            OnlineId = input.ReadString();
            break;
          }
          case 96: {
            LastActiveTime = input.ReadUInt32();
            break;
          }
          case 104: {
            NameCardId = input.ReadUInt32();
            break;
          }
          case 112: {
            MpPlayerNum = input.ReadUInt32();
            break;
          }
          case 120: {
            IsChatNoDisturb = input.ReadBool();
            break;
          }
          case 128: {
            ChatSequence = input.ReadUInt32();
            break;
          }
          case 138: {
            RemarkName = input.ReadString();
            break;
          }
          case 178: {
            showAvatarInfoList_.AddEntriesFrom(input, _repeated_showAvatarInfoList_codec);
            break;
          }
          case 184: {
            FriendEnterHomeOption = (global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption) input.ReadEnum();
            break;
          }
          case 194: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 200: {
            IsGameSource = input.ReadBool();
            break;
          }
          case 208: {
            IsPsnSource = input.ReadBool();
            break;
          }
          case 216: {
            PlatformType = (global::Weedwacker.Shared.Network.Proto.PlatformType) input.ReadEnum();
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
            Uid = input.ReadUInt32();
            break;
          }
          case 18: {
            Nickname = input.ReadString();
            break;
          }
          case 24: {
            Level = input.ReadUInt32();
            break;
          }
          case 32: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 40: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 50: {
            Signature = input.ReadString();
            break;
          }
          case 56: {
            OnlineState = (global::Weedwacker.Shared.Network.Proto.FriendOnlineState) input.ReadEnum();
            break;
          }
          case 64: {
            Param = input.ReadUInt32();
            break;
          }
          case 80: {
            IsMpModeAvailable = input.ReadBool();
            break;
          }
          case 90: {
            OnlineId = input.ReadString();
            break;
          }
          case 96: {
            LastActiveTime = input.ReadUInt32();
            break;
          }
          case 104: {
            NameCardId = input.ReadUInt32();
            break;
          }
          case 112: {
            MpPlayerNum = input.ReadUInt32();
            break;
          }
          case 120: {
            IsChatNoDisturb = input.ReadBool();
            break;
          }
          case 128: {
            ChatSequence = input.ReadUInt32();
            break;
          }
          case 138: {
            RemarkName = input.ReadString();
            break;
          }
          case 178: {
            showAvatarInfoList_.AddEntriesFrom(ref input, _repeated_showAvatarInfoList_codec);
            break;
          }
          case 184: {
            FriendEnterHomeOption = (global::Weedwacker.Shared.Network.Proto.FriendEnterHomeOption) input.ReadEnum();
            break;
          }
          case 194: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::Weedwacker.Shared.Network.Proto.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 200: {
            IsGameSource = input.ReadBool();
            break;
          }
          case 208: {
            IsPsnSource = input.ReadBool();
            break;
          }
          case 216: {
            PlatformType = (global::Weedwacker.Shared.Network.Proto.PlatformType) input.ReadEnum();
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
