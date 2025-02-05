// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ParkourLevelInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ParkourLevelInfo.proto</summary>
  public static partial class ParkourLevelInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ParkourLevelInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ParkourLevelInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQYXJrb3VyTGV2ZWxJbmZvLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvGgxWZWN0b3IucHJvdG8igQEKEFBhcmtvdXJMZXZlbElu",
            "Zm8SNAoDcG9zGAIgASgLMicuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90by5WZWN0b3ISDwoHaXNfb3BlbhgHIAEoCBITCgtiZXN0X3JlY29yZBgO",
            "IAEoDRIRCglvcGVuX3RpbWUYBCABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ParkourLevelInfo), global::Weedwacker.Shared.Network.Proto.ParkourLevelInfo.Parser, new[]{ "Pos", "IsOpen", "BestRecord", "OpenTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ParkourLevelInfo : pb::IMessage<ParkourLevelInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ParkourLevelInfo> _parser = new pb::MessageParser<ParkourLevelInfo>(() => new ParkourLevelInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ParkourLevelInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ParkourLevelInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ParkourLevelInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ParkourLevelInfo(ParkourLevelInfo other) : this() {
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      isOpen_ = other.isOpen_;
      bestRecord_ = other.bestRecord_;
      openTime_ = other.openTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ParkourLevelInfo Clone() {
      return new ParkourLevelInfo(this);
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 2;
    private global::Weedwacker.Shared.Network.Proto.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 7;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "best_record" field.</summary>
    public const int BestRecordFieldNumber = 14;
    private uint bestRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BestRecord {
      get { return bestRecord_; }
      set {
        bestRecord_ = value;
      }
    }

    /// <summary>Field number for the "open_time" field.</summary>
    public const int OpenTimeFieldNumber = 4;
    private uint openTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OpenTime {
      get { return openTime_; }
      set {
        openTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ParkourLevelInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ParkourLevelInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Pos, other.Pos)) return false;
      if (IsOpen != other.IsOpen) return false;
      if (BestRecord != other.BestRecord) return false;
      if (OpenTime != other.OpenTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      if (BestRecord != 0) hash ^= BestRecord.GetHashCode();
      if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
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
      if (pos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pos);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OpenTime);
      }
      if (IsOpen != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsOpen);
      }
      if (BestRecord != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(BestRecord);
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
      if (pos_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Pos);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OpenTime);
      }
      if (IsOpen != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsOpen);
      }
      if (BestRecord != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(BestRecord);
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
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (BestRecord != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BestRecord);
      }
      if (OpenTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ParkourLevelInfo other) {
      if (other == null) {
        return;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      if (other.BestRecord != 0) {
        BestRecord = other.BestRecord;
      }
      if (other.OpenTime != 0) {
        OpenTime = other.OpenTime;
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
          case 18: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 32: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 56: {
            IsOpen = input.ReadBool();
            break;
          }
          case 112: {
            BestRecord = input.ReadUInt32();
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
          case 18: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 32: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 56: {
            IsOpen = input.ReadBool();
            break;
          }
          case 112: {
            BestRecord = input.ReadUInt32();
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
