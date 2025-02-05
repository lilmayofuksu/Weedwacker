// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityScheduleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ActivityScheduleInfo.proto</summary>
  public static partial class ActivityScheduleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ActivityScheduleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ActivityScheduleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpBY3Rpdml0eVNjaGVkdWxlSW5mby5wcm90bxIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90byJ3ChRBY3Rpdml0eVNjaGVkdWxlSW5mbxIQCghl",
            "bmRfdGltZRgDIAEoDRIPCgdpc19vcGVuGAwgASgIEhIKCmJlZ2luX3RpbWUY",
            "ASABKA0SEwoLc2NoZWR1bGVfaWQYCSABKA0SEwoLYWN0aXZpdHlfaWQYCyAB",
            "KA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ActivityScheduleInfo), global::Weedwacker.Shared.Network.Proto.ActivityScheduleInfo.Parser, new[]{ "EndTime", "IsOpen", "BeginTime", "ScheduleId", "ActivityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ActivityScheduleInfo : pb::IMessage<ActivityScheduleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ActivityScheduleInfo> _parser = new pb::MessageParser<ActivityScheduleInfo>(() => new ActivityScheduleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ActivityScheduleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ActivityScheduleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityScheduleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityScheduleInfo(ActivityScheduleInfo other) : this() {
      endTime_ = other.endTime_;
      isOpen_ = other.isOpen_;
      beginTime_ = other.beginTime_;
      scheduleId_ = other.scheduleId_;
      activityId_ = other.activityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityScheduleInfo Clone() {
      return new ActivityScheduleInfo(this);
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 3;
    private uint endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 12;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "begin_time" field.</summary>
    public const int BeginTimeFieldNumber = 1;
    private uint beginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BeginTime {
      get { return beginTime_; }
      set {
        beginTime_ = value;
      }
    }

    /// <summary>Field number for the "schedule_id" field.</summary>
    public const int ScheduleIdFieldNumber = 9;
    private uint scheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScheduleId {
      get { return scheduleId_; }
      set {
        scheduleId_ = value;
      }
    }

    /// <summary>Field number for the "activity_id" field.</summary>
    public const int ActivityIdFieldNumber = 11;
    private uint activityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ActivityId {
      get { return activityId_; }
      set {
        activityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ActivityScheduleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ActivityScheduleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EndTime != other.EndTime) return false;
      if (IsOpen != other.IsOpen) return false;
      if (BeginTime != other.BeginTime) return false;
      if (ScheduleId != other.ScheduleId) return false;
      if (ActivityId != other.ActivityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EndTime != 0) hash ^= EndTime.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      if (BeginTime != 0) hash ^= BeginTime.GetHashCode();
      if (ScheduleId != 0) hash ^= ScheduleId.GetHashCode();
      if (ActivityId != 0) hash ^= ActivityId.GetHashCode();
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
      if (BeginTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BeginTime);
      }
      if (EndTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EndTime);
      }
      if (ScheduleId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ScheduleId);
      }
      if (ActivityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ActivityId);
      }
      if (IsOpen != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsOpen);
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
      if (BeginTime != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BeginTime);
      }
      if (EndTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(EndTime);
      }
      if (ScheduleId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ScheduleId);
      }
      if (ActivityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ActivityId);
      }
      if (IsOpen != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsOpen);
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
      if (EndTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EndTime);
      }
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (BeginTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BeginTime);
      }
      if (ScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleId);
      }
      if (ActivityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActivityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ActivityScheduleInfo other) {
      if (other == null) {
        return;
      }
      if (other.EndTime != 0) {
        EndTime = other.EndTime;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      if (other.BeginTime != 0) {
        BeginTime = other.BeginTime;
      }
      if (other.ScheduleId != 0) {
        ScheduleId = other.ScheduleId;
      }
      if (other.ActivityId != 0) {
        ActivityId = other.ActivityId;
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
            BeginTime = input.ReadUInt32();
            break;
          }
          case 24: {
            EndTime = input.ReadUInt32();
            break;
          }
          case 72: {
            ScheduleId = input.ReadUInt32();
            break;
          }
          case 88: {
            ActivityId = input.ReadUInt32();
            break;
          }
          case 96: {
            IsOpen = input.ReadBool();
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
            BeginTime = input.ReadUInt32();
            break;
          }
          case 24: {
            EndTime = input.ReadUInt32();
            break;
          }
          case 72: {
            ScheduleId = input.ReadUInt32();
            break;
          }
          case 88: {
            ActivityId = input.ReadUInt32();
            break;
          }
          case 96: {
            IsOpen = input.ReadBool();
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
