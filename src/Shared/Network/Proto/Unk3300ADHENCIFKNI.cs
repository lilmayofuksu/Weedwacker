// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk3300_ADHENCIFKNI.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk3300_ADHENCIFKNI.proto</summary>
  public static partial class Unk3300ADHENCIFKNIReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk3300_ADHENCIFKNI.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk3300ADHENCIFKNIReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmszMzAwX0FESEVOQ0lGS05JLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJl",
            "ZC5OZXR3b3JrLlByb3RvIlQKE1VuazMzMDBfQURIRU5DSUZLTkkSEgoKYmVn",
            "aW5fdGltZRgGIAEoBBISCgp0aW1lX3N0YW1wGA0gASgEEhUKDWNvbnRyb2xs",
            "ZXJfaWQYCiABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk3300_ADHENCIFKNI), global::Weedwacker.Shared.Network.Proto.Unk3300_ADHENCIFKNI.Parser, new[]{ "BeginTime", "TimeStamp", "ControllerId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk3300_ADHENCIFKNI : pb::IMessage<Unk3300_ADHENCIFKNI>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk3300_ADHENCIFKNI> _parser = new pb::MessageParser<Unk3300_ADHENCIFKNI>(() => new Unk3300_ADHENCIFKNI());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk3300_ADHENCIFKNI> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk3300ADHENCIFKNIReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3300_ADHENCIFKNI() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3300_ADHENCIFKNI(Unk3300_ADHENCIFKNI other) : this() {
      beginTime_ = other.beginTime_;
      timeStamp_ = other.timeStamp_;
      controllerId_ = other.controllerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk3300_ADHENCIFKNI Clone() {
      return new Unk3300_ADHENCIFKNI(this);
    }

    /// <summary>Field number for the "begin_time" field.</summary>
    public const int BeginTimeFieldNumber = 6;
    private ulong beginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong BeginTime {
      get { return beginTime_; }
      set {
        beginTime_ = value;
      }
    }

    /// <summary>Field number for the "time_stamp" field.</summary>
    public const int TimeStampFieldNumber = 13;
    private ulong timeStamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TimeStamp {
      get { return timeStamp_; }
      set {
        timeStamp_ = value;
      }
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 10;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk3300_ADHENCIFKNI);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk3300_ADHENCIFKNI other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BeginTime != other.BeginTime) return false;
      if (TimeStamp != other.TimeStamp) return false;
      if (ControllerId != other.ControllerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BeginTime != 0UL) hash ^= BeginTime.GetHashCode();
      if (TimeStamp != 0UL) hash ^= TimeStamp.GetHashCode();
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
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
      if (BeginTime != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(BeginTime);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ControllerId);
      }
      if (TimeStamp != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(TimeStamp);
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
      if (BeginTime != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(BeginTime);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ControllerId);
      }
      if (TimeStamp != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(TimeStamp);
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
      if (BeginTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(BeginTime);
      }
      if (TimeStamp != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TimeStamp);
      }
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk3300_ADHENCIFKNI other) {
      if (other == null) {
        return;
      }
      if (other.BeginTime != 0UL) {
        BeginTime = other.BeginTime;
      }
      if (other.TimeStamp != 0UL) {
        TimeStamp = other.TimeStamp;
      }
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
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
          case 48: {
            BeginTime = input.ReadUInt64();
            break;
          }
          case 80: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 104: {
            TimeStamp = input.ReadUInt64();
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
          case 48: {
            BeginTime = input.ReadUInt64();
            break;
          }
          case 80: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 104: {
            TimeStamp = input.ReadUInt64();
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
