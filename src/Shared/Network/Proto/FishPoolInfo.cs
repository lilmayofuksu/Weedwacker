// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FishPoolInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FishPoolInfo.proto</summary>
  public static partial class FishPoolInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FishPoolInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FishPoolInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJGaXNoUG9vbEluZm8ucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdv",
            "cmsuUHJvdG8iTwoMRmlzaFBvb2xJbmZvEg8KB3Bvb2xfaWQYASABKA0SFgoO",
            "ZmlzaF9hcmVhX2xpc3QYAiADKA0SFgoOdG9kYXlfZmlzaF9udW0YAyABKA1i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FishPoolInfo), global::Weedwacker.Shared.Network.Proto.FishPoolInfo.Parser, new[]{ "PoolId", "FishAreaList", "TodayFishNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FishPoolInfo : pb::IMessage<FishPoolInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FishPoolInfo> _parser = new pb::MessageParser<FishPoolInfo>(() => new FishPoolInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FishPoolInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FishPoolInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishPoolInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishPoolInfo(FishPoolInfo other) : this() {
      poolId_ = other.poolId_;
      fishAreaList_ = other.fishAreaList_.Clone();
      todayFishNum_ = other.todayFishNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishPoolInfo Clone() {
      return new FishPoolInfo(this);
    }

    /// <summary>Field number for the "pool_id" field.</summary>
    public const int PoolIdFieldNumber = 1;
    private uint poolId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PoolId {
      get { return poolId_; }
      set {
        poolId_ = value;
      }
    }

    /// <summary>Field number for the "fish_area_list" field.</summary>
    public const int FishAreaListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_fishAreaList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> fishAreaList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FishAreaList {
      get { return fishAreaList_; }
    }

    /// <summary>Field number for the "today_fish_num" field.</summary>
    public const int TodayFishNumFieldNumber = 3;
    private uint todayFishNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TodayFishNum {
      get { return todayFishNum_; }
      set {
        todayFishNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FishPoolInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FishPoolInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PoolId != other.PoolId) return false;
      if(!fishAreaList_.Equals(other.fishAreaList_)) return false;
      if (TodayFishNum != other.TodayFishNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PoolId != 0) hash ^= PoolId.GetHashCode();
      hash ^= fishAreaList_.GetHashCode();
      if (TodayFishNum != 0) hash ^= TodayFishNum.GetHashCode();
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
      if (PoolId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PoolId);
      }
      fishAreaList_.WriteTo(output, _repeated_fishAreaList_codec);
      if (TodayFishNum != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TodayFishNum);
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
      if (PoolId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PoolId);
      }
      fishAreaList_.WriteTo(ref output, _repeated_fishAreaList_codec);
      if (TodayFishNum != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TodayFishNum);
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
      if (PoolId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PoolId);
      }
      size += fishAreaList_.CalculateSize(_repeated_fishAreaList_codec);
      if (TodayFishNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TodayFishNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FishPoolInfo other) {
      if (other == null) {
        return;
      }
      if (other.PoolId != 0) {
        PoolId = other.PoolId;
      }
      fishAreaList_.Add(other.fishAreaList_);
      if (other.TodayFishNum != 0) {
        TodayFishNum = other.TodayFishNum;
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
            PoolId = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            fishAreaList_.AddEntriesFrom(input, _repeated_fishAreaList_codec);
            break;
          }
          case 24: {
            TodayFishNum = input.ReadUInt32();
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
            PoolId = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            fishAreaList_.AddEntriesFrom(ref input, _repeated_fishAreaList_codec);
            break;
          }
          case 24: {
            TodayFishNum = input.ReadUInt32();
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
