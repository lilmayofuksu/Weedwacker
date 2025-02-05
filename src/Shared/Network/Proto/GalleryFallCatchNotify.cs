// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GalleryFallCatchNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GalleryFallCatchNotify.proto</summary>
  public static partial class GalleryFallCatchNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GalleryFallCatchNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GalleryFallCatchNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHYWxsZXJ5RmFsbENhdGNoTm90aWZ5LnByb3RvEh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvIqACChZHYWxsZXJ5RmFsbENhdGNoTm90aWZ5",
            "EhEKCWFkZF9zY29yZRgBIAEoDRISCgpnYWxsZXJ5X2lkGAcgASgNEhEKCWN1",
            "cl9zY29yZRgLIAEoDRIRCgl0aW1lX2Nvc3QYDyABKA0SEQoJaXNfZ3JvdW5k",
            "GAggASgIEmwKFGJhbGxfY2F0Y2hfY291bnRfbWFwGA4gAygLMk4uV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5HYWxsZXJ5RmFsbENhdGNoTm90",
            "aWZ5LkJhbGxDYXRjaENvdW50TWFwRW50cnkaOAoWQmFsbENhdGNoQ291bnRN",
            "YXBFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKA06AjgBYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GalleryFallCatchNotify), global::Weedwacker.Shared.Network.Proto.GalleryFallCatchNotify.Parser, new[]{ "AddScore", "GalleryId", "CurScore", "TimeCost", "IsGround", "BallCatchCountMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 5600;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class GalleryFallCatchNotify : pb::IMessage<GalleryFallCatchNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GalleryFallCatchNotify> _parser = new pb::MessageParser<GalleryFallCatchNotify>(() => new GalleryFallCatchNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GalleryFallCatchNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GalleryFallCatchNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryFallCatchNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryFallCatchNotify(GalleryFallCatchNotify other) : this() {
      addScore_ = other.addScore_;
      galleryId_ = other.galleryId_;
      curScore_ = other.curScore_;
      timeCost_ = other.timeCost_;
      isGround_ = other.isGround_;
      ballCatchCountMap_ = other.ballCatchCountMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryFallCatchNotify Clone() {
      return new GalleryFallCatchNotify(this);
    }

    /// <summary>Field number for the "add_score" field.</summary>
    public const int AddScoreFieldNumber = 1;
    private uint addScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AddScore {
      get { return addScore_; }
      set {
        addScore_ = value;
      }
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 7;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "cur_score" field.</summary>
    public const int CurScoreFieldNumber = 11;
    private uint curScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurScore {
      get { return curScore_; }
      set {
        curScore_ = value;
      }
    }

    /// <summary>Field number for the "time_cost" field.</summary>
    public const int TimeCostFieldNumber = 15;
    private uint timeCost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TimeCost {
      get { return timeCost_; }
      set {
        timeCost_ = value;
      }
    }

    /// <summary>Field number for the "is_ground" field.</summary>
    public const int IsGroundFieldNumber = 8;
    private bool isGround_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsGround {
      get { return isGround_; }
      set {
        isGround_ = value;
      }
    }

    /// <summary>Field number for the "ball_catch_count_map" field.</summary>
    public const int BallCatchCountMapFieldNumber = 14;
    private static readonly pbc::MapField<uint, uint>.Codec _map_ballCatchCountMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 114);
    private readonly pbc::MapField<uint, uint> ballCatchCountMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> BallCatchCountMap {
      get { return ballCatchCountMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GalleryFallCatchNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GalleryFallCatchNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AddScore != other.AddScore) return false;
      if (GalleryId != other.GalleryId) return false;
      if (CurScore != other.CurScore) return false;
      if (TimeCost != other.TimeCost) return false;
      if (IsGround != other.IsGround) return false;
      if (!BallCatchCountMap.Equals(other.BallCatchCountMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AddScore != 0) hash ^= AddScore.GetHashCode();
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (CurScore != 0) hash ^= CurScore.GetHashCode();
      if (TimeCost != 0) hash ^= TimeCost.GetHashCode();
      if (IsGround != false) hash ^= IsGround.GetHashCode();
      hash ^= BallCatchCountMap.GetHashCode();
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
      if (AddScore != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AddScore);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GalleryId);
      }
      if (IsGround != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsGround);
      }
      if (CurScore != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurScore);
      }
      ballCatchCountMap_.WriteTo(output, _map_ballCatchCountMap_codec);
      if (TimeCost != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TimeCost);
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
      if (AddScore != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AddScore);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GalleryId);
      }
      if (IsGround != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsGround);
      }
      if (CurScore != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CurScore);
      }
      ballCatchCountMap_.WriteTo(ref output, _map_ballCatchCountMap_codec);
      if (TimeCost != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TimeCost);
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
      if (AddScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AddScore);
      }
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (CurScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurScore);
      }
      if (TimeCost != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TimeCost);
      }
      if (IsGround != false) {
        size += 1 + 1;
      }
      size += ballCatchCountMap_.CalculateSize(_map_ballCatchCountMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GalleryFallCatchNotify other) {
      if (other == null) {
        return;
      }
      if (other.AddScore != 0) {
        AddScore = other.AddScore;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.CurScore != 0) {
        CurScore = other.CurScore;
      }
      if (other.TimeCost != 0) {
        TimeCost = other.TimeCost;
      }
      if (other.IsGround != false) {
        IsGround = other.IsGround;
      }
      ballCatchCountMap_.Add(other.ballCatchCountMap_);
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
            AddScore = input.ReadUInt32();
            break;
          }
          case 56: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 64: {
            IsGround = input.ReadBool();
            break;
          }
          case 88: {
            CurScore = input.ReadUInt32();
            break;
          }
          case 114: {
            ballCatchCountMap_.AddEntriesFrom(input, _map_ballCatchCountMap_codec);
            break;
          }
          case 120: {
            TimeCost = input.ReadUInt32();
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
            AddScore = input.ReadUInt32();
            break;
          }
          case 56: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 64: {
            IsGround = input.ReadBool();
            break;
          }
          case 88: {
            CurScore = input.ReadUInt32();
            break;
          }
          case 114: {
            ballCatchCountMap_.AddEntriesFrom(ref input, _map_ballCatchCountMap_codec);
            break;
          }
          case 120: {
            TimeCost = input.ReadUInt32();
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
