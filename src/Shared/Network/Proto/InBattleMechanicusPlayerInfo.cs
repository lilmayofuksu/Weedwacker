// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InBattleMechanicusPlayerInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from InBattleMechanicusPlayerInfo.proto</summary>
  public static partial class InBattleMechanicusPlayerInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for InBattleMechanicusPlayerInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InBattleMechanicusPlayerInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJJbkJhdHRsZU1lY2hhbmljdXNQbGF5ZXJJbmZvLnByb3RvEh9XZWVkd2Fj",
            "a2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvGiRJbkJhdHRsZU1lY2hhbmljdXNC",
            "dWlsZGluZ0luZm8ucHJvdG8izQEKHEluQmF0dGxlTWVjaGFuaWN1c1BsYXll",
            "ckluZm8SCwoDdWlkGA0gASgNEhkKEWlzX2NhcmRfY29uZmlybWVkGAwgASgI",
            "EhcKD2J1aWxkaW5nX3BvaW50cxgCIAEoDRJWCg1idWlsZGluZ19saXN0GAUg",
            "AygLMj8uV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5JbkJhdHRs",
            "ZU1lY2hhbmljdXNCdWlsZGluZ0luZm8SFAoMcGlja19jYXJkX2lkGA8gASgN",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.InBattleMechanicusBuildingInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.InBattleMechanicusPlayerInfo), global::Weedwacker.Shared.Network.Proto.InBattleMechanicusPlayerInfo.Parser, new[]{ "Uid", "IsCardConfirmed", "BuildingPoints", "BuildingList", "PickCardId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InBattleMechanicusPlayerInfo : pb::IMessage<InBattleMechanicusPlayerInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<InBattleMechanicusPlayerInfo> _parser = new pb::MessageParser<InBattleMechanicusPlayerInfo>(() => new InBattleMechanicusPlayerInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<InBattleMechanicusPlayerInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.InBattleMechanicusPlayerInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusPlayerInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusPlayerInfo(InBattleMechanicusPlayerInfo other) : this() {
      uid_ = other.uid_;
      isCardConfirmed_ = other.isCardConfirmed_;
      buildingPoints_ = other.buildingPoints_;
      buildingList_ = other.buildingList_.Clone();
      pickCardId_ = other.pickCardId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public InBattleMechanicusPlayerInfo Clone() {
      return new InBattleMechanicusPlayerInfo(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 13;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "is_card_confirmed" field.</summary>
    public const int IsCardConfirmedFieldNumber = 12;
    private bool isCardConfirmed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCardConfirmed {
      get { return isCardConfirmed_; }
      set {
        isCardConfirmed_ = value;
      }
    }

    /// <summary>Field number for the "building_points" field.</summary>
    public const int BuildingPointsFieldNumber = 2;
    private uint buildingPoints_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuildingPoints {
      get { return buildingPoints_; }
      set {
        buildingPoints_ = value;
      }
    }

    /// <summary>Field number for the "building_list" field.</summary>
    public const int BuildingListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.InBattleMechanicusBuildingInfo> _repeated_buildingList_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Shared.Network.Proto.InBattleMechanicusBuildingInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.InBattleMechanicusBuildingInfo> buildingList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.InBattleMechanicusBuildingInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.InBattleMechanicusBuildingInfo> BuildingList {
      get { return buildingList_; }
    }

    /// <summary>Field number for the "pick_card_id" field.</summary>
    public const int PickCardIdFieldNumber = 15;
    private uint pickCardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PickCardId {
      get { return pickCardId_; }
      set {
        pickCardId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as InBattleMechanicusPlayerInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(InBattleMechanicusPlayerInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (IsCardConfirmed != other.IsCardConfirmed) return false;
      if (BuildingPoints != other.BuildingPoints) return false;
      if(!buildingList_.Equals(other.buildingList_)) return false;
      if (PickCardId != other.PickCardId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (IsCardConfirmed != false) hash ^= IsCardConfirmed.GetHashCode();
      if (BuildingPoints != 0) hash ^= BuildingPoints.GetHashCode();
      hash ^= buildingList_.GetHashCode();
      if (PickCardId != 0) hash ^= PickCardId.GetHashCode();
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
      if (BuildingPoints != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BuildingPoints);
      }
      buildingList_.WriteTo(output, _repeated_buildingList_codec);
      if (IsCardConfirmed != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsCardConfirmed);
      }
      if (Uid != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Uid);
      }
      if (PickCardId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(PickCardId);
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
      if (BuildingPoints != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(BuildingPoints);
      }
      buildingList_.WriteTo(ref output, _repeated_buildingList_codec);
      if (IsCardConfirmed != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsCardConfirmed);
      }
      if (Uid != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Uid);
      }
      if (PickCardId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(PickCardId);
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
      if (IsCardConfirmed != false) {
        size += 1 + 1;
      }
      if (BuildingPoints != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuildingPoints);
      }
      size += buildingList_.CalculateSize(_repeated_buildingList_codec);
      if (PickCardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PickCardId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(InBattleMechanicusPlayerInfo other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.IsCardConfirmed != false) {
        IsCardConfirmed = other.IsCardConfirmed;
      }
      if (other.BuildingPoints != 0) {
        BuildingPoints = other.BuildingPoints;
      }
      buildingList_.Add(other.buildingList_);
      if (other.PickCardId != 0) {
        PickCardId = other.PickCardId;
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
            BuildingPoints = input.ReadUInt32();
            break;
          }
          case 42: {
            buildingList_.AddEntriesFrom(input, _repeated_buildingList_codec);
            break;
          }
          case 96: {
            IsCardConfirmed = input.ReadBool();
            break;
          }
          case 104: {
            Uid = input.ReadUInt32();
            break;
          }
          case 120: {
            PickCardId = input.ReadUInt32();
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
            BuildingPoints = input.ReadUInt32();
            break;
          }
          case 42: {
            buildingList_.AddEntriesFrom(ref input, _repeated_buildingList_codec);
            break;
          }
          case 96: {
            IsCardConfirmed = input.ReadBool();
            break;
          }
          case 104: {
            Uid = input.ReadUInt32();
            break;
          }
          case 120: {
            PickCardId = input.ReadUInt32();
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
