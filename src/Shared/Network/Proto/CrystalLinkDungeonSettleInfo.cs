// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CrystalLinkDungeonSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CrystalLinkDungeonSettleInfo.proto</summary>
  public static partial class CrystalLinkDungeonSettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for CrystalLinkDungeonSettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CrystalLinkDungeonSettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJDcnlzdGFsTGlua0R1bmdlb25TZXR0bGVJbmZvLnByb3RvEh9XZWVkd2Fj",
            "a2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvIrQBChxDcnlzdGFsTGlua0R1bmdl",
            "b25TZXR0bGVJbmZvEhAKCGxldmVsX2lkGAkgASgNEhMKC2ZpbmFsX3Njb3Jl",
            "GAwgASgNEh8KF2tpbGxfbm9ybWFsX21vbnN0ZXJfbnVtGAggASgNEhUKDWRp",
            "ZmZpY3VsdHlfaWQYAyABKA0SHgoWa2lsbF9lbGl0ZV9tb25zdGVyX251bRgC",
            "IAEoDRIVCg1pc19uZXdfcmVjb3JkGAogASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CrystalLinkDungeonSettleInfo), global::Weedwacker.Shared.Network.Proto.CrystalLinkDungeonSettleInfo.Parser, new[]{ "LevelId", "FinalScore", "KillNormalMonsterNum", "DifficultyId", "KillEliteMonsterNum", "IsNewRecord" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CrystalLinkDungeonSettleInfo : pb::IMessage<CrystalLinkDungeonSettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CrystalLinkDungeonSettleInfo> _parser = new pb::MessageParser<CrystalLinkDungeonSettleInfo>(() => new CrystalLinkDungeonSettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CrystalLinkDungeonSettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CrystalLinkDungeonSettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrystalLinkDungeonSettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrystalLinkDungeonSettleInfo(CrystalLinkDungeonSettleInfo other) : this() {
      levelId_ = other.levelId_;
      finalScore_ = other.finalScore_;
      killNormalMonsterNum_ = other.killNormalMonsterNum_;
      difficultyId_ = other.difficultyId_;
      killEliteMonsterNum_ = other.killEliteMonsterNum_;
      isNewRecord_ = other.isNewRecord_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrystalLinkDungeonSettleInfo Clone() {
      return new CrystalLinkDungeonSettleInfo(this);
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 9;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "final_score" field.</summary>
    public const int FinalScoreFieldNumber = 12;
    private uint finalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinalScore {
      get { return finalScore_; }
      set {
        finalScore_ = value;
      }
    }

    /// <summary>Field number for the "kill_normal_monster_num" field.</summary>
    public const int KillNormalMonsterNumFieldNumber = 8;
    private uint killNormalMonsterNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KillNormalMonsterNum {
      get { return killNormalMonsterNum_; }
      set {
        killNormalMonsterNum_ = value;
      }
    }

    /// <summary>Field number for the "difficulty_id" field.</summary>
    public const int DifficultyIdFieldNumber = 3;
    private uint difficultyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyId {
      get { return difficultyId_; }
      set {
        difficultyId_ = value;
      }
    }

    /// <summary>Field number for the "kill_elite_monster_num" field.</summary>
    public const int KillEliteMonsterNumFieldNumber = 2;
    private uint killEliteMonsterNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KillEliteMonsterNum {
      get { return killEliteMonsterNum_; }
      set {
        killEliteMonsterNum_ = value;
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CrystalLinkDungeonSettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CrystalLinkDungeonSettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LevelId != other.LevelId) return false;
      if (FinalScore != other.FinalScore) return false;
      if (KillNormalMonsterNum != other.KillNormalMonsterNum) return false;
      if (DifficultyId != other.DifficultyId) return false;
      if (KillEliteMonsterNum != other.KillEliteMonsterNum) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (FinalScore != 0) hash ^= FinalScore.GetHashCode();
      if (KillNormalMonsterNum != 0) hash ^= KillNormalMonsterNum.GetHashCode();
      if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
      if (KillEliteMonsterNum != 0) hash ^= KillEliteMonsterNum.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
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
      if (KillEliteMonsterNum != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(KillEliteMonsterNum);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DifficultyId);
      }
      if (KillNormalMonsterNum != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(KillNormalMonsterNum);
      }
      if (LevelId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(LevelId);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsNewRecord);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(96);
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
      if (KillEliteMonsterNum != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(KillEliteMonsterNum);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DifficultyId);
      }
      if (KillNormalMonsterNum != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(KillNormalMonsterNum);
      }
      if (LevelId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(LevelId);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsNewRecord);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(96);
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
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (FinalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinalScore);
      }
      if (KillNormalMonsterNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KillNormalMonsterNum);
      }
      if (DifficultyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
      }
      if (KillEliteMonsterNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KillEliteMonsterNum);
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CrystalLinkDungeonSettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.FinalScore != 0) {
        FinalScore = other.FinalScore;
      }
      if (other.KillNormalMonsterNum != 0) {
        KillNormalMonsterNum = other.KillNormalMonsterNum;
      }
      if (other.DifficultyId != 0) {
        DifficultyId = other.DifficultyId;
      }
      if (other.KillEliteMonsterNum != 0) {
        KillEliteMonsterNum = other.KillEliteMonsterNum;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
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
            KillEliteMonsterNum = input.ReadUInt32();
            break;
          }
          case 24: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 64: {
            KillNormalMonsterNum = input.ReadUInt32();
            break;
          }
          case 72: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 80: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 96: {
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
          case 16: {
            KillEliteMonsterNum = input.ReadUInt32();
            break;
          }
          case 24: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 64: {
            KillNormalMonsterNum = input.ReadUInt32();
            break;
          }
          case 72: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 80: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 96: {
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
