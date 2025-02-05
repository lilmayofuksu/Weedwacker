// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LanternRiteActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from LanternRiteActivityDetailInfo.proto</summary>
  public static partial class LanternRiteActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for LanternRiteActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LanternRiteActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNMYW50ZXJuUml0ZUFjdGl2aXR5RGV0YWlsSW5mby5wcm90bxIfV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90bxobTGFudGVyblByb2plY3Rpb25J",
            "bmZvLnByb3RvGh5MYW50ZXJuUml0ZUZpcmV3b3Jrc0luZm8ucHJvdG8aFlNh",
            "bHZhZ2VTdGFnZUluZm8ucHJvdG8i5AIKHUxhbnRlcm5SaXRlQWN0aXZpdHlE",
            "ZXRhaWxJbmZvEkoKD3N0YWdlX2luZm9fbGlzdBgFIAMoCzIxLldlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uU2FsdmFnZVN0YWdlSW5mbxJRCg5m",
            "aXJld29ya3NfaW5mbxgPIAEoCzI5LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdv",
            "cmsuUHJvdG8uTGFudGVyblJpdGVGaXJld29ya3NJbmZvEhsKE1VuazMzMDBf",
            "UERGSk5DREdLR0gYCyABKAgSTwoPcHJvamVjdGlvbl9pbmZvGAMgASgLMjYu",
            "V2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5MYW50ZXJuUHJvamVj",
            "dGlvbkluZm8SGwoTVW5rMzMwMF9ES0JKTENJTUJBTBgIIAEoCBIZChFpc19j",
            "b250ZW50X2Nsb3NlZBgOIAEoCGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.LanternProjectionInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.LanternRiteFireworksInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.SalvageStageInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.LanternRiteActivityDetailInfo), global::Weedwacker.Shared.Network.Proto.LanternRiteActivityDetailInfo.Parser, new[]{ "StageInfoList", "FireworksInfo", "Unk3300PDFJNCDGKGH", "ProjectionInfo", "Unk3300DKBJLCIMBAL", "IsContentClosed" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LanternRiteActivityDetailInfo : pb::IMessage<LanternRiteActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LanternRiteActivityDetailInfo> _parser = new pb::MessageParser<LanternRiteActivityDetailInfo>(() => new LanternRiteActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LanternRiteActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.LanternRiteActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteActivityDetailInfo(LanternRiteActivityDetailInfo other) : this() {
      stageInfoList_ = other.stageInfoList_.Clone();
      fireworksInfo_ = other.fireworksInfo_ != null ? other.fireworksInfo_.Clone() : null;
      unk3300PDFJNCDGKGH_ = other.unk3300PDFJNCDGKGH_;
      projectionInfo_ = other.projectionInfo_ != null ? other.projectionInfo_.Clone() : null;
      unk3300DKBJLCIMBAL_ = other.unk3300DKBJLCIMBAL_;
      isContentClosed_ = other.isContentClosed_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteActivityDetailInfo Clone() {
      return new LanternRiteActivityDetailInfo(this);
    }

    /// <summary>Field number for the "stage_info_list" field.</summary>
    public const int StageInfoListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.SalvageStageInfo> _repeated_stageInfoList_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Shared.Network.Proto.SalvageStageInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SalvageStageInfo> stageInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SalvageStageInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.SalvageStageInfo> StageInfoList {
      get { return stageInfoList_; }
    }

    /// <summary>Field number for the "fireworks_info" field.</summary>
    public const int FireworksInfoFieldNumber = 15;
    private global::Weedwacker.Shared.Network.Proto.LanternRiteFireworksInfo fireworksInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.LanternRiteFireworksInfo FireworksInfo {
      get { return fireworksInfo_; }
      set {
        fireworksInfo_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_PDFJNCDGKGH" field.</summary>
    public const int Unk3300PDFJNCDGKGHFieldNumber = 11;
    private bool unk3300PDFJNCDGKGH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300PDFJNCDGKGH {
      get { return unk3300PDFJNCDGKGH_; }
      set {
        unk3300PDFJNCDGKGH_ = value;
      }
    }

    /// <summary>Field number for the "projection_info" field.</summary>
    public const int ProjectionInfoFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.LanternProjectionInfo projectionInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.LanternProjectionInfo ProjectionInfo {
      get { return projectionInfo_; }
      set {
        projectionInfo_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_DKBJLCIMBAL" field.</summary>
    public const int Unk3300DKBJLCIMBALFieldNumber = 8;
    private bool unk3300DKBJLCIMBAL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300DKBJLCIMBAL {
      get { return unk3300DKBJLCIMBAL_; }
      set {
        unk3300DKBJLCIMBAL_ = value;
      }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 14;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LanternRiteActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LanternRiteActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!stageInfoList_.Equals(other.stageInfoList_)) return false;
      if (!object.Equals(FireworksInfo, other.FireworksInfo)) return false;
      if (Unk3300PDFJNCDGKGH != other.Unk3300PDFJNCDGKGH) return false;
      if (!object.Equals(ProjectionInfo, other.ProjectionInfo)) return false;
      if (Unk3300DKBJLCIMBAL != other.Unk3300DKBJLCIMBAL) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= stageInfoList_.GetHashCode();
      if (fireworksInfo_ != null) hash ^= FireworksInfo.GetHashCode();
      if (Unk3300PDFJNCDGKGH != false) hash ^= Unk3300PDFJNCDGKGH.GetHashCode();
      if (projectionInfo_ != null) hash ^= ProjectionInfo.GetHashCode();
      if (Unk3300DKBJLCIMBAL != false) hash ^= Unk3300DKBJLCIMBAL.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
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
      if (projectionInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProjectionInfo);
      }
      stageInfoList_.WriteTo(output, _repeated_stageInfoList_codec);
      if (Unk3300DKBJLCIMBAL != false) {
        output.WriteRawTag(64);
        output.WriteBool(Unk3300DKBJLCIMBAL);
      }
      if (Unk3300PDFJNCDGKGH != false) {
        output.WriteRawTag(88);
        output.WriteBool(Unk3300PDFJNCDGKGH);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsContentClosed);
      }
      if (fireworksInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(FireworksInfo);
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
      if (projectionInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ProjectionInfo);
      }
      stageInfoList_.WriteTo(ref output, _repeated_stageInfoList_codec);
      if (Unk3300DKBJLCIMBAL != false) {
        output.WriteRawTag(64);
        output.WriteBool(Unk3300DKBJLCIMBAL);
      }
      if (Unk3300PDFJNCDGKGH != false) {
        output.WriteRawTag(88);
        output.WriteBool(Unk3300PDFJNCDGKGH);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsContentClosed);
      }
      if (fireworksInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(FireworksInfo);
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
      size += stageInfoList_.CalculateSize(_repeated_stageInfoList_codec);
      if (fireworksInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FireworksInfo);
      }
      if (Unk3300PDFJNCDGKGH != false) {
        size += 1 + 1;
      }
      if (projectionInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProjectionInfo);
      }
      if (Unk3300DKBJLCIMBAL != false) {
        size += 1 + 1;
      }
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LanternRiteActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      stageInfoList_.Add(other.stageInfoList_);
      if (other.fireworksInfo_ != null) {
        if (fireworksInfo_ == null) {
          FireworksInfo = new global::Weedwacker.Shared.Network.Proto.LanternRiteFireworksInfo();
        }
        FireworksInfo.MergeFrom(other.FireworksInfo);
      }
      if (other.Unk3300PDFJNCDGKGH != false) {
        Unk3300PDFJNCDGKGH = other.Unk3300PDFJNCDGKGH;
      }
      if (other.projectionInfo_ != null) {
        if (projectionInfo_ == null) {
          ProjectionInfo = new global::Weedwacker.Shared.Network.Proto.LanternProjectionInfo();
        }
        ProjectionInfo.MergeFrom(other.ProjectionInfo);
      }
      if (other.Unk3300DKBJLCIMBAL != false) {
        Unk3300DKBJLCIMBAL = other.Unk3300DKBJLCIMBAL;
      }
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
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
            if (projectionInfo_ == null) {
              ProjectionInfo = new global::Weedwacker.Shared.Network.Proto.LanternProjectionInfo();
            }
            input.ReadMessage(ProjectionInfo);
            break;
          }
          case 42: {
            stageInfoList_.AddEntriesFrom(input, _repeated_stageInfoList_codec);
            break;
          }
          case 64: {
            Unk3300DKBJLCIMBAL = input.ReadBool();
            break;
          }
          case 88: {
            Unk3300PDFJNCDGKGH = input.ReadBool();
            break;
          }
          case 112: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 122: {
            if (fireworksInfo_ == null) {
              FireworksInfo = new global::Weedwacker.Shared.Network.Proto.LanternRiteFireworksInfo();
            }
            input.ReadMessage(FireworksInfo);
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
            if (projectionInfo_ == null) {
              ProjectionInfo = new global::Weedwacker.Shared.Network.Proto.LanternProjectionInfo();
            }
            input.ReadMessage(ProjectionInfo);
            break;
          }
          case 42: {
            stageInfoList_.AddEntriesFrom(ref input, _repeated_stageInfoList_codec);
            break;
          }
          case 64: {
            Unk3300DKBJLCIMBAL = input.ReadBool();
            break;
          }
          case 88: {
            Unk3300PDFJNCDGKGH = input.ReadBool();
            break;
          }
          case 112: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 122: {
            if (fireworksInfo_ == null) {
              FireworksInfo = new global::Weedwacker.Shared.Network.Proto.LanternRiteFireworksInfo();
            }
            input.ReadMessage(FireworksInfo);
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
