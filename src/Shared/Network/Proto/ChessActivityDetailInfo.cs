// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ChessActivityDetailInfo.proto</summary>
  public static partial class ChessActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1DaGVzc0FjdGl2aXR5RGV0YWlsSW5mby5wcm90bxIfV2VlZHdhY2tlci5T",
            "aGFyZWQuTmV0d29yay5Qcm90byKBAgoXQ2hlc3NBY3Rpdml0eURldGFpbElu",
            "Zm8SGAoQcHVuaXNoX292ZXJfdGltZRgJIAEoDRIbChNVbmszMzAwX0xQRERG",
            "R0dLR0JQGAQgASgNEg0KBWxldmVsGA4gASgNEgsKA2V4cBgGIAEoDRIbChNV",
            "bmszMzAwX0hCR0VHSVBJQU5HGA8gASgNEhoKEmNvbnRlbnRfY2xvc2VfdGlt",
            "ZRgBIAEoDRIhChlpc190ZWFjaF9kdW5nZW9uX2ZpbmlzaGVkGAsgASgIEhkK",
            "EWlzX2NvbnRlbnRfY2xvc2VkGAUgASgIEhwKFGZpbmlzaGVkX21hcF9pZF9s",
            "aXN0GA0gAygNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ChessActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.ChessActivityDetailInfo.Parser, new[]{ "PunishOverTime", "Unk3300LPDDFGGKGBP", "Level", "Exp", "Unk3300HBGEGIPIANG", "ContentCloseTime", "IsTeachDungeonFinished", "IsContentClosed", "FinishedMapIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChessActivityDetailInfo : pb::IMessage<ChessActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessActivityDetailInfo> _parser = new pb::MessageParser<ChessActivityDetailInfo>(() => new ChessActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ChessActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessActivityDetailInfo(ChessActivityDetailInfo other) : this() {
      punishOverTime_ = other.punishOverTime_;
      unk3300LPDDFGGKGBP_ = other.unk3300LPDDFGGKGBP_;
      level_ = other.level_;
      exp_ = other.exp_;
      unk3300HBGEGIPIANG_ = other.unk3300HBGEGIPIANG_;
      contentCloseTime_ = other.contentCloseTime_;
      isTeachDungeonFinished_ = other.isTeachDungeonFinished_;
      isContentClosed_ = other.isContentClosed_;
      finishedMapIdList_ = other.finishedMapIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessActivityDetailInfo Clone() {
      return new ChessActivityDetailInfo(this);
    }

    /// <summary>Field number for the "punish_over_time" field.</summary>
    public const int PunishOverTimeFieldNumber = 9;
    private uint punishOverTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PunishOverTime {
      get { return punishOverTime_; }
      set {
        punishOverTime_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_LPDDFGGKGBP" field.</summary>
    public const int Unk3300LPDDFGGKGBPFieldNumber = 4;
    private uint unk3300LPDDFGGKGBP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300LPDDFGGKGBP {
      get { return unk3300LPDDFGGKGBP_; }
      set {
        unk3300LPDDFGGKGBP_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 14;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 6;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HBGEGIPIANG" field.</summary>
    public const int Unk3300HBGEGIPIANGFieldNumber = 15;
    private uint unk3300HBGEGIPIANG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300HBGEGIPIANG {
      get { return unk3300HBGEGIPIANG_; }
      set {
        unk3300HBGEGIPIANG_ = value;
      }
    }

    /// <summary>Field number for the "content_close_time" field.</summary>
    public const int ContentCloseTimeFieldNumber = 1;
    private uint contentCloseTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContentCloseTime {
      get { return contentCloseTime_; }
      set {
        contentCloseTime_ = value;
      }
    }

    /// <summary>Field number for the "is_teach_dungeon_finished" field.</summary>
    public const int IsTeachDungeonFinishedFieldNumber = 11;
    private bool isTeachDungeonFinished_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTeachDungeonFinished {
      get { return isTeachDungeonFinished_; }
      set {
        isTeachDungeonFinished_ = value;
      }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 5;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    /// <summary>Field number for the "finished_map_id_list" field.</summary>
    public const int FinishedMapIdListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_finishedMapIdList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> finishedMapIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FinishedMapIdList {
      get { return finishedMapIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PunishOverTime != other.PunishOverTime) return false;
      if (Unk3300LPDDFGGKGBP != other.Unk3300LPDDFGGKGBP) return false;
      if (Level != other.Level) return false;
      if (Exp != other.Exp) return false;
      if (Unk3300HBGEGIPIANG != other.Unk3300HBGEGIPIANG) return false;
      if (ContentCloseTime != other.ContentCloseTime) return false;
      if (IsTeachDungeonFinished != other.IsTeachDungeonFinished) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      if(!finishedMapIdList_.Equals(other.finishedMapIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PunishOverTime != 0) hash ^= PunishOverTime.GetHashCode();
      if (Unk3300LPDDFGGKGBP != 0) hash ^= Unk3300LPDDFGGKGBP.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (Unk3300HBGEGIPIANG != 0) hash ^= Unk3300HBGEGIPIANG.GetHashCode();
      if (ContentCloseTime != 0) hash ^= ContentCloseTime.GetHashCode();
      if (IsTeachDungeonFinished != false) hash ^= IsTeachDungeonFinished.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
      hash ^= finishedMapIdList_.GetHashCode();
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
      if (ContentCloseTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ContentCloseTime);
      }
      if (Unk3300LPDDFGGKGBP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300LPDDFGGKGBP);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsContentClosed);
      }
      if (Exp != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Exp);
      }
      if (PunishOverTime != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PunishOverTime);
      }
      if (IsTeachDungeonFinished != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsTeachDungeonFinished);
      }
      finishedMapIdList_.WriteTo(output, _repeated_finishedMapIdList_codec);
      if (Level != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Level);
      }
      if (Unk3300HBGEGIPIANG != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300HBGEGIPIANG);
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
      if (ContentCloseTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ContentCloseTime);
      }
      if (Unk3300LPDDFGGKGBP != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300LPDDFGGKGBP);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsContentClosed);
      }
      if (Exp != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Exp);
      }
      if (PunishOverTime != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PunishOverTime);
      }
      if (IsTeachDungeonFinished != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsTeachDungeonFinished);
      }
      finishedMapIdList_.WriteTo(ref output, _repeated_finishedMapIdList_codec);
      if (Level != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Level);
      }
      if (Unk3300HBGEGIPIANG != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300HBGEGIPIANG);
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
      if (PunishOverTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PunishOverTime);
      }
      if (Unk3300LPDDFGGKGBP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LPDDFGGKGBP);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (Unk3300HBGEGIPIANG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300HBGEGIPIANG);
      }
      if (ContentCloseTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContentCloseTime);
      }
      if (IsTeachDungeonFinished != false) {
        size += 1 + 1;
      }
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      size += finishedMapIdList_.CalculateSize(_repeated_finishedMapIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.PunishOverTime != 0) {
        PunishOverTime = other.PunishOverTime;
      }
      if (other.Unk3300LPDDFGGKGBP != 0) {
        Unk3300LPDDFGGKGBP = other.Unk3300LPDDFGGKGBP;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.Unk3300HBGEGIPIANG != 0) {
        Unk3300HBGEGIPIANG = other.Unk3300HBGEGIPIANG;
      }
      if (other.ContentCloseTime != 0) {
        ContentCloseTime = other.ContentCloseTime;
      }
      if (other.IsTeachDungeonFinished != false) {
        IsTeachDungeonFinished = other.IsTeachDungeonFinished;
      }
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
      }
      finishedMapIdList_.Add(other.finishedMapIdList_);
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
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 32: {
            Unk3300LPDDFGGKGBP = input.ReadUInt32();
            break;
          }
          case 40: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 48: {
            Exp = input.ReadUInt32();
            break;
          }
          case 72: {
            PunishOverTime = input.ReadUInt32();
            break;
          }
          case 88: {
            IsTeachDungeonFinished = input.ReadBool();
            break;
          }
          case 106:
          case 104: {
            finishedMapIdList_.AddEntriesFrom(input, _repeated_finishedMapIdList_codec);
            break;
          }
          case 112: {
            Level = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk3300HBGEGIPIANG = input.ReadUInt32();
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
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 32: {
            Unk3300LPDDFGGKGBP = input.ReadUInt32();
            break;
          }
          case 40: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 48: {
            Exp = input.ReadUInt32();
            break;
          }
          case 72: {
            PunishOverTime = input.ReadUInt32();
            break;
          }
          case 88: {
            IsTeachDungeonFinished = input.ReadBool();
            break;
          }
          case 106:
          case 104: {
            finishedMapIdList_.AddEntriesFrom(ref input, _repeated_finishedMapIdList_codec);
            break;
          }
          case 112: {
            Level = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk3300HBGEGIPIANG = input.ReadUInt32();
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
