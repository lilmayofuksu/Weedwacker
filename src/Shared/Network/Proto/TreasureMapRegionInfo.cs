// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TreasureMapRegionInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from TreasureMapRegionInfo.proto</summary>
  public static partial class TreasureMapRegionInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TreasureMapRegionInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TreasureMapRegionInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtUcmVhc3VyZU1hcFJlZ2lvbkluZm8ucHJvdG8SH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8aDFZlY3Rvci5wcm90byKfAgoVVHJlYXN1cmVN",
            "YXBSZWdpb25JbmZvEhUKDXJlZ2lvbl9yYWRpdXMYDSABKA0SEQoJcmVnaW9u",
            "X2lkGAogASgNEkIKEXJlZ2lvbl9jZW50ZXJfcG9zGAUgASgLMicuV2VlZHdh",
            "Y2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5WZWN0b3ISGwoTVW5rMzMwMF9I",
            "SEJITFBITEhJTBgGIAEoCBISCgpzdGFydF90aW1lGAggASgNEhsKE1VuazMz",
            "MDBfTEtFTUVEUE1JR00YAyABKA0SGwoTVW5rMzMwMF9OSUJKT0FKTENKSRgB",
            "IAEoCBIQCghzY2VuZV9pZBgMIAEoDRIbChNVbmszMzAwX01ORUtKSUxGSE9B",
            "GAIgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.TreasureMapRegionInfo), global::Weedwacker.Shared.Network.Proto.TreasureMapRegionInfo.Parser, new[]{ "RegionRadius", "RegionId", "RegionCenterPos", "Unk3300HHBHLPHLHIL", "StartTime", "Unk3300LKEMEDPMIGM", "Unk3300NIBJOAJLCJI", "SceneId", "Unk3300MNEKJILFHOA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TreasureMapRegionInfo : pb::IMessage<TreasureMapRegionInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TreasureMapRegionInfo> _parser = new pb::MessageParser<TreasureMapRegionInfo>(() => new TreasureMapRegionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TreasureMapRegionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.TreasureMapRegionInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapRegionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapRegionInfo(TreasureMapRegionInfo other) : this() {
      regionRadius_ = other.regionRadius_;
      regionId_ = other.regionId_;
      regionCenterPos_ = other.regionCenterPos_ != null ? other.regionCenterPos_.Clone() : null;
      unk3300HHBHLPHLHIL_ = other.unk3300HHBHLPHLHIL_;
      startTime_ = other.startTime_;
      unk3300LKEMEDPMIGM_ = other.unk3300LKEMEDPMIGM_;
      unk3300NIBJOAJLCJI_ = other.unk3300NIBJOAJLCJI_;
      sceneId_ = other.sceneId_;
      unk3300MNEKJILFHOA_ = other.unk3300MNEKJILFHOA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapRegionInfo Clone() {
      return new TreasureMapRegionInfo(this);
    }

    /// <summary>Field number for the "region_radius" field.</summary>
    public const int RegionRadiusFieldNumber = 13;
    private uint regionRadius_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RegionRadius {
      get { return regionRadius_; }
      set {
        regionRadius_ = value;
      }
    }

    /// <summary>Field number for the "region_id" field.</summary>
    public const int RegionIdFieldNumber = 10;
    private uint regionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RegionId {
      get { return regionId_; }
      set {
        regionId_ = value;
      }
    }

    /// <summary>Field number for the "region_center_pos" field.</summary>
    public const int RegionCenterPosFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.Vector regionCenterPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector RegionCenterPos {
      get { return regionCenterPos_; }
      set {
        regionCenterPos_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HHBHLPHLHIL" field.</summary>
    public const int Unk3300HHBHLPHLHILFieldNumber = 6;
    private bool unk3300HHBHLPHLHIL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300HHBHLPHLHIL {
      get { return unk3300HHBHLPHLHIL_; }
      set {
        unk3300HHBHLPHLHIL_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 8;
    private uint startTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_LKEMEDPMIGM" field.</summary>
    public const int Unk3300LKEMEDPMIGMFieldNumber = 3;
    private uint unk3300LKEMEDPMIGM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300LKEMEDPMIGM {
      get { return unk3300LKEMEDPMIGM_; }
      set {
        unk3300LKEMEDPMIGM_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_NIBJOAJLCJI" field.</summary>
    public const int Unk3300NIBJOAJLCJIFieldNumber = 1;
    private bool unk3300NIBJOAJLCJI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300NIBJOAJLCJI {
      get { return unk3300NIBJOAJLCJI_; }
      set {
        unk3300NIBJOAJLCJI_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 12;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_MNEKJILFHOA" field.</summary>
    public const int Unk3300MNEKJILFHOAFieldNumber = 2;
    private uint unk3300MNEKJILFHOA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300MNEKJILFHOA {
      get { return unk3300MNEKJILFHOA_; }
      set {
        unk3300MNEKJILFHOA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TreasureMapRegionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TreasureMapRegionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RegionRadius != other.RegionRadius) return false;
      if (RegionId != other.RegionId) return false;
      if (!object.Equals(RegionCenterPos, other.RegionCenterPos)) return false;
      if (Unk3300HHBHLPHLHIL != other.Unk3300HHBHLPHLHIL) return false;
      if (StartTime != other.StartTime) return false;
      if (Unk3300LKEMEDPMIGM != other.Unk3300LKEMEDPMIGM) return false;
      if (Unk3300NIBJOAJLCJI != other.Unk3300NIBJOAJLCJI) return false;
      if (SceneId != other.SceneId) return false;
      if (Unk3300MNEKJILFHOA != other.Unk3300MNEKJILFHOA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RegionRadius != 0) hash ^= RegionRadius.GetHashCode();
      if (RegionId != 0) hash ^= RegionId.GetHashCode();
      if (regionCenterPos_ != null) hash ^= RegionCenterPos.GetHashCode();
      if (Unk3300HHBHLPHLHIL != false) hash ^= Unk3300HHBHLPHLHIL.GetHashCode();
      if (StartTime != 0) hash ^= StartTime.GetHashCode();
      if (Unk3300LKEMEDPMIGM != 0) hash ^= Unk3300LKEMEDPMIGM.GetHashCode();
      if (Unk3300NIBJOAJLCJI != false) hash ^= Unk3300NIBJOAJLCJI.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (Unk3300MNEKJILFHOA != 0) hash ^= Unk3300MNEKJILFHOA.GetHashCode();
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
      if (Unk3300NIBJOAJLCJI != false) {
        output.WriteRawTag(8);
        output.WriteBool(Unk3300NIBJOAJLCJI);
      }
      if (Unk3300MNEKJILFHOA != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300MNEKJILFHOA);
      }
      if (Unk3300LKEMEDPMIGM != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3300LKEMEDPMIGM);
      }
      if (regionCenterPos_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RegionCenterPos);
      }
      if (Unk3300HHBHLPHLHIL != false) {
        output.WriteRawTag(48);
        output.WriteBool(Unk3300HHBHLPHLHIL);
      }
      if (StartTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(StartTime);
      }
      if (RegionId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RegionId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SceneId);
      }
      if (RegionRadius != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RegionRadius);
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
      if (Unk3300NIBJOAJLCJI != false) {
        output.WriteRawTag(8);
        output.WriteBool(Unk3300NIBJOAJLCJI);
      }
      if (Unk3300MNEKJILFHOA != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300MNEKJILFHOA);
      }
      if (Unk3300LKEMEDPMIGM != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Unk3300LKEMEDPMIGM);
      }
      if (regionCenterPos_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RegionCenterPos);
      }
      if (Unk3300HHBHLPHLHIL != false) {
        output.WriteRawTag(48);
        output.WriteBool(Unk3300HHBHLPHLHIL);
      }
      if (StartTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(StartTime);
      }
      if (RegionId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RegionId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SceneId);
      }
      if (RegionRadius != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RegionRadius);
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
      if (RegionRadius != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RegionRadius);
      }
      if (RegionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RegionId);
      }
      if (regionCenterPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RegionCenterPos);
      }
      if (Unk3300HHBHLPHLHIL != false) {
        size += 1 + 1;
      }
      if (StartTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartTime);
      }
      if (Unk3300LKEMEDPMIGM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LKEMEDPMIGM);
      }
      if (Unk3300NIBJOAJLCJI != false) {
        size += 1 + 1;
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (Unk3300MNEKJILFHOA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300MNEKJILFHOA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TreasureMapRegionInfo other) {
      if (other == null) {
        return;
      }
      if (other.RegionRadius != 0) {
        RegionRadius = other.RegionRadius;
      }
      if (other.RegionId != 0) {
        RegionId = other.RegionId;
      }
      if (other.regionCenterPos_ != null) {
        if (regionCenterPos_ == null) {
          RegionCenterPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        RegionCenterPos.MergeFrom(other.RegionCenterPos);
      }
      if (other.Unk3300HHBHLPHLHIL != false) {
        Unk3300HHBHLPHLHIL = other.Unk3300HHBHLPHLHIL;
      }
      if (other.StartTime != 0) {
        StartTime = other.StartTime;
      }
      if (other.Unk3300LKEMEDPMIGM != 0) {
        Unk3300LKEMEDPMIGM = other.Unk3300LKEMEDPMIGM;
      }
      if (other.Unk3300NIBJOAJLCJI != false) {
        Unk3300NIBJOAJLCJI = other.Unk3300NIBJOAJLCJI;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.Unk3300MNEKJILFHOA != 0) {
        Unk3300MNEKJILFHOA = other.Unk3300MNEKJILFHOA;
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
            Unk3300NIBJOAJLCJI = input.ReadBool();
            break;
          }
          case 16: {
            Unk3300MNEKJILFHOA = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk3300LKEMEDPMIGM = input.ReadUInt32();
            break;
          }
          case 42: {
            if (regionCenterPos_ == null) {
              RegionCenterPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(RegionCenterPos);
            break;
          }
          case 48: {
            Unk3300HHBHLPHLHIL = input.ReadBool();
            break;
          }
          case 64: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 80: {
            RegionId = input.ReadUInt32();
            break;
          }
          case 96: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 104: {
            RegionRadius = input.ReadUInt32();
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
            Unk3300NIBJOAJLCJI = input.ReadBool();
            break;
          }
          case 16: {
            Unk3300MNEKJILFHOA = input.ReadUInt32();
            break;
          }
          case 24: {
            Unk3300LKEMEDPMIGM = input.ReadUInt32();
            break;
          }
          case 42: {
            if (regionCenterPos_ == null) {
              RegionCenterPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(RegionCenterPos);
            break;
          }
          case 48: {
            Unk3300HHBHLPHLHIL = input.ReadBool();
            break;
          }
          case 64: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 80: {
            RegionId = input.ReadUInt32();
            break;
          }
          case 96: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 104: {
            RegionRadius = input.ReadUInt32();
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
