// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDiaryDungeonSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from RogueDiaryDungeonSettleNotify.proto</summary>
  public static partial class RogueDiaryDungeonSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDiaryDungeonSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDiaryDungeonSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNSb2d1ZURpYXJ5RHVuZ2VvblNldHRsZU5vdGlmeS5wcm90bxIfV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90byJbCh1Sb2d1ZURpYXJ5RHVuZ2Vv",
            "blNldHRsZU5vdGlmeRIRCglpc19maW5pc2gYDiABKAgSEQoJY3VyX3JvdW5k",
            "GAsgASgNEhQKDGV4cGxvcmVfdGltZRgEIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.RogueDiaryDungeonSettleNotify), global::Weedwacker.Shared.Network.Proto.RogueDiaryDungeonSettleNotify.Parser, new[]{ "IsFinish", "CurRound", "ExploreTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8726;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class RogueDiaryDungeonSettleNotify : pb::IMessage<RogueDiaryDungeonSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueDiaryDungeonSettleNotify> _parser = new pb::MessageParser<RogueDiaryDungeonSettleNotify>(() => new RogueDiaryDungeonSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueDiaryDungeonSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.RogueDiaryDungeonSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryDungeonSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryDungeonSettleNotify(RogueDiaryDungeonSettleNotify other) : this() {
      isFinish_ = other.isFinish_;
      curRound_ = other.curRound_;
      exploreTime_ = other.exploreTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryDungeonSettleNotify Clone() {
      return new RogueDiaryDungeonSettleNotify(this);
    }

    /// <summary>Field number for the "is_finish" field.</summary>
    public const int IsFinishFieldNumber = 14;
    private bool isFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinish {
      get { return isFinish_; }
      set {
        isFinish_ = value;
      }
    }

    /// <summary>Field number for the "cur_round" field.</summary>
    public const int CurRoundFieldNumber = 11;
    private uint curRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurRound {
      get { return curRound_; }
      set {
        curRound_ = value;
      }
    }

    /// <summary>Field number for the "explore_time" field.</summary>
    public const int ExploreTimeFieldNumber = 4;
    private uint exploreTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExploreTime {
      get { return exploreTime_; }
      set {
        exploreTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueDiaryDungeonSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueDiaryDungeonSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsFinish != other.IsFinish) return false;
      if (CurRound != other.CurRound) return false;
      if (ExploreTime != other.ExploreTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsFinish != false) hash ^= IsFinish.GetHashCode();
      if (CurRound != 0) hash ^= CurRound.GetHashCode();
      if (ExploreTime != 0) hash ^= ExploreTime.GetHashCode();
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
      if (ExploreTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ExploreTime);
      }
      if (CurRound != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurRound);
      }
      if (IsFinish != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFinish);
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
      if (ExploreTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ExploreTime);
      }
      if (CurRound != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurRound);
      }
      if (IsFinish != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFinish);
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
      if (IsFinish != false) {
        size += 1 + 1;
      }
      if (CurRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurRound);
      }
      if (ExploreTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExploreTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueDiaryDungeonSettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsFinish != false) {
        IsFinish = other.IsFinish;
      }
      if (other.CurRound != 0) {
        CurRound = other.CurRound;
      }
      if (other.ExploreTime != 0) {
        ExploreTime = other.ExploreTime;
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
          case 32: {
            ExploreTime = input.ReadUInt32();
            break;
          }
          case 88: {
            CurRound = input.ReadUInt32();
            break;
          }
          case 112: {
            IsFinish = input.ReadBool();
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
          case 32: {
            ExploreTime = input.ReadUInt32();
            break;
          }
          case 88: {
            CurRound = input.ReadUInt32();
            break;
          }
          case 112: {
            IsFinish = input.ReadBool();
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
