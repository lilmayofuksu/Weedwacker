// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LanternRiteEndFireworksReformRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from LanternRiteEndFireworksReformRsp.proto</summary>
  public static partial class LanternRiteEndFireworksReformRspReflection {

    #region Descriptor
    /// <summary>File descriptor for LanternRiteEndFireworksReformRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LanternRiteEndFireworksReformRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZMYW50ZXJuUml0ZUVuZEZpcmV3b3Jrc1JlZm9ybVJzcC5wcm90bxIfV2Vl",
            "ZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90byL1AQogTGFudGVyblJpdGVF",
            "bmRGaXJld29ya3NSZWZvcm1Sc3ASGwoTVW5rMzMwMF9DR0pOQkdBS0ZBRBgL",
            "IAEoCBIbChNVbmszMzAwX0ZQRUZJQURGQk5JGAEgASgIEg8KB3JldGNvZGUY",
            "CSABKAUSEAoIc3RhZ2VfaWQYDSABKA0SEwoLZmluYWxfc2NvcmUYDyABKA0S",
            "GwoTVW5rMzMwMF9BTE1ORUdDSUlMQRgGIAEoCBIVCg1pc19uZXdfcmVjb3Jk",
            "GAogASgIEhQKDGNoYWxsZW5nZV9pZBgEIAEoDRIVCg1pc19mdWxsX3Njb3Jl",
            "GAcgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.LanternRiteEndFireworksReformRsp), global::Weedwacker.Shared.Network.Proto.LanternRiteEndFireworksReformRsp.Parser, new[]{ "Unk3300CGJNBGAKFAD", "Unk3300FPEFIADFBNI", "Retcode", "StageId", "FinalScore", "Unk3300ALMNEGCIILA", "IsNewRecord", "ChallengeId", "IsFullScore" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8414;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class LanternRiteEndFireworksReformRsp : pb::IMessage<LanternRiteEndFireworksReformRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LanternRiteEndFireworksReformRsp> _parser = new pb::MessageParser<LanternRiteEndFireworksReformRsp>(() => new LanternRiteEndFireworksReformRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LanternRiteEndFireworksReformRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.LanternRiteEndFireworksReformRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteEndFireworksReformRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteEndFireworksReformRsp(LanternRiteEndFireworksReformRsp other) : this() {
      unk3300CGJNBGAKFAD_ = other.unk3300CGJNBGAKFAD_;
      unk3300FPEFIADFBNI_ = other.unk3300FPEFIADFBNI_;
      retcode_ = other.retcode_;
      stageId_ = other.stageId_;
      finalScore_ = other.finalScore_;
      unk3300ALMNEGCIILA_ = other.unk3300ALMNEGCIILA_;
      isNewRecord_ = other.isNewRecord_;
      challengeId_ = other.challengeId_;
      isFullScore_ = other.isFullScore_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteEndFireworksReformRsp Clone() {
      return new LanternRiteEndFireworksReformRsp(this);
    }

    /// <summary>Field number for the "Unk3300_CGJNBGAKFAD" field.</summary>
    public const int Unk3300CGJNBGAKFADFieldNumber = 11;
    private bool unk3300CGJNBGAKFAD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300CGJNBGAKFAD {
      get { return unk3300CGJNBGAKFAD_; }
      set {
        unk3300CGJNBGAKFAD_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_FPEFIADFBNI" field.</summary>
    public const int Unk3300FPEFIADFBNIFieldNumber = 1;
    private bool unk3300FPEFIADFBNI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300FPEFIADFBNI {
      get { return unk3300FPEFIADFBNI_; }
      set {
        unk3300FPEFIADFBNI_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 9;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 13;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "final_score" field.</summary>
    public const int FinalScoreFieldNumber = 15;
    private uint finalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinalScore {
      get { return finalScore_; }
      set {
        finalScore_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_ALMNEGCIILA" field.</summary>
    public const int Unk3300ALMNEGCIILAFieldNumber = 6;
    private bool unk3300ALMNEGCIILA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300ALMNEGCIILA {
      get { return unk3300ALMNEGCIILA_; }
      set {
        unk3300ALMNEGCIILA_ = value;
      }
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 10;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 4;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "is_full_score" field.</summary>
    public const int IsFullScoreFieldNumber = 7;
    private bool isFullScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFullScore {
      get { return isFullScore_; }
      set {
        isFullScore_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LanternRiteEndFireworksReformRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LanternRiteEndFireworksReformRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300CGJNBGAKFAD != other.Unk3300CGJNBGAKFAD) return false;
      if (Unk3300FPEFIADFBNI != other.Unk3300FPEFIADFBNI) return false;
      if (Retcode != other.Retcode) return false;
      if (StageId != other.StageId) return false;
      if (FinalScore != other.FinalScore) return false;
      if (Unk3300ALMNEGCIILA != other.Unk3300ALMNEGCIILA) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      if (ChallengeId != other.ChallengeId) return false;
      if (IsFullScore != other.IsFullScore) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300CGJNBGAKFAD != false) hash ^= Unk3300CGJNBGAKFAD.GetHashCode();
      if (Unk3300FPEFIADFBNI != false) hash ^= Unk3300FPEFIADFBNI.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (FinalScore != 0) hash ^= FinalScore.GetHashCode();
      if (Unk3300ALMNEGCIILA != false) hash ^= Unk3300ALMNEGCIILA.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      if (IsFullScore != false) hash ^= IsFullScore.GetHashCode();
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
      if (Unk3300FPEFIADFBNI != false) {
        output.WriteRawTag(8);
        output.WriteBool(Unk3300FPEFIADFBNI);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ChallengeId);
      }
      if (Unk3300ALMNEGCIILA != false) {
        output.WriteRawTag(48);
        output.WriteBool(Unk3300ALMNEGCIILA);
      }
      if (IsFullScore != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFullScore);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Retcode);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsNewRecord);
      }
      if (Unk3300CGJNBGAKFAD != false) {
        output.WriteRawTag(88);
        output.WriteBool(Unk3300CGJNBGAKFAD);
      }
      if (StageId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StageId);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FinalScore);
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
      if (Unk3300FPEFIADFBNI != false) {
        output.WriteRawTag(8);
        output.WriteBool(Unk3300FPEFIADFBNI);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ChallengeId);
      }
      if (Unk3300ALMNEGCIILA != false) {
        output.WriteRawTag(48);
        output.WriteBool(Unk3300ALMNEGCIILA);
      }
      if (IsFullScore != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFullScore);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Retcode);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsNewRecord);
      }
      if (Unk3300CGJNBGAKFAD != false) {
        output.WriteRawTag(88);
        output.WriteBool(Unk3300CGJNBGAKFAD);
      }
      if (StageId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StageId);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FinalScore);
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
      if (Unk3300CGJNBGAKFAD != false) {
        size += 1 + 1;
      }
      if (Unk3300FPEFIADFBNI != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (FinalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinalScore);
      }
      if (Unk3300ALMNEGCIILA != false) {
        size += 1 + 1;
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (IsFullScore != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LanternRiteEndFireworksReformRsp other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300CGJNBGAKFAD != false) {
        Unk3300CGJNBGAKFAD = other.Unk3300CGJNBGAKFAD;
      }
      if (other.Unk3300FPEFIADFBNI != false) {
        Unk3300FPEFIADFBNI = other.Unk3300FPEFIADFBNI;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.FinalScore != 0) {
        FinalScore = other.FinalScore;
      }
      if (other.Unk3300ALMNEGCIILA != false) {
        Unk3300ALMNEGCIILA = other.Unk3300ALMNEGCIILA;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      if (other.IsFullScore != false) {
        IsFullScore = other.IsFullScore;
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
            Unk3300FPEFIADFBNI = input.ReadBool();
            break;
          }
          case 32: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300ALMNEGCIILA = input.ReadBool();
            break;
          }
          case 56: {
            IsFullScore = input.ReadBool();
            break;
          }
          case 72: {
            Retcode = input.ReadInt32();
            break;
          }
          case 80: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 88: {
            Unk3300CGJNBGAKFAD = input.ReadBool();
            break;
          }
          case 104: {
            StageId = input.ReadUInt32();
            break;
          }
          case 120: {
            FinalScore = input.ReadUInt32();
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
            Unk3300FPEFIADFBNI = input.ReadBool();
            break;
          }
          case 32: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300ALMNEGCIILA = input.ReadBool();
            break;
          }
          case 56: {
            IsFullScore = input.ReadBool();
            break;
          }
          case 72: {
            Retcode = input.ReadInt32();
            break;
          }
          case 80: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 88: {
            Unk3300CGJNBGAKFAD = input.ReadBool();
            break;
          }
          case 104: {
            StageId = input.ReadUInt32();
            break;
          }
          case 120: {
            FinalScore = input.ReadUInt32();
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
