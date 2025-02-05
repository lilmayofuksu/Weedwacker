// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HuntingRevealFinalNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HuntingRevealFinalNotify.proto</summary>
  public static partial class HuntingRevealFinalNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for HuntingRevealFinalNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HuntingRevealFinalNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5IdW50aW5nUmV2ZWFsRmluYWxOb3RpZnkucHJvdG8SH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG8aEUh1bnRpbmdQYWlyLnByb3RvGgxWZWN0",
            "b3IucHJvdG8iugEKGEh1bnRpbmdSZXZlYWxGaW5hbE5vdGlmeRI/Cg5maW5h",
            "bF9wb3NpdGlvbhgDIAEoCzInLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsu",
            "UHJvdG8uVmVjdG9yEkIKDGh1bnRpbmdfcGFpchgJIAEoCzIsLldlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uSHVudGluZ1BhaXISGQoRZmluaXNo",
            "ZWRfZ3JvdXBfaWQYDiABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.HuntingPairReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HuntingRevealFinalNotify), global::Weedwacker.Shared.Network.Proto.HuntingRevealFinalNotify.Parser, new[]{ "FinalPosition", "HuntingPair", "FinishedGroupId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4312;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class HuntingRevealFinalNotify : pb::IMessage<HuntingRevealFinalNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HuntingRevealFinalNotify> _parser = new pb::MessageParser<HuntingRevealFinalNotify>(() => new HuntingRevealFinalNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HuntingRevealFinalNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HuntingRevealFinalNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HuntingRevealFinalNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HuntingRevealFinalNotify(HuntingRevealFinalNotify other) : this() {
      finalPosition_ = other.finalPosition_ != null ? other.finalPosition_.Clone() : null;
      huntingPair_ = other.huntingPair_ != null ? other.huntingPair_.Clone() : null;
      finishedGroupId_ = other.finishedGroupId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HuntingRevealFinalNotify Clone() {
      return new HuntingRevealFinalNotify(this);
    }

    /// <summary>Field number for the "final_position" field.</summary>
    public const int FinalPositionFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.Vector finalPosition_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector FinalPosition {
      get { return finalPosition_; }
      set {
        finalPosition_ = value;
      }
    }

    /// <summary>Field number for the "hunting_pair" field.</summary>
    public const int HuntingPairFieldNumber = 9;
    private global::Weedwacker.Shared.Network.Proto.HuntingPair huntingPair_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.HuntingPair HuntingPair {
      get { return huntingPair_; }
      set {
        huntingPair_ = value;
      }
    }

    /// <summary>Field number for the "finished_group_id" field.</summary>
    public const int FinishedGroupIdFieldNumber = 14;
    private uint finishedGroupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinishedGroupId {
      get { return finishedGroupId_; }
      set {
        finishedGroupId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HuntingRevealFinalNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HuntingRevealFinalNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FinalPosition, other.FinalPosition)) return false;
      if (!object.Equals(HuntingPair, other.HuntingPair)) return false;
      if (FinishedGroupId != other.FinishedGroupId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (finalPosition_ != null) hash ^= FinalPosition.GetHashCode();
      if (huntingPair_ != null) hash ^= HuntingPair.GetHashCode();
      if (FinishedGroupId != 0) hash ^= FinishedGroupId.GetHashCode();
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
      if (finalPosition_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(FinalPosition);
      }
      if (huntingPair_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(HuntingPair);
      }
      if (FinishedGroupId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FinishedGroupId);
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
      if (finalPosition_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(FinalPosition);
      }
      if (huntingPair_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(HuntingPair);
      }
      if (FinishedGroupId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FinishedGroupId);
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
      if (finalPosition_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FinalPosition);
      }
      if (huntingPair_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HuntingPair);
      }
      if (FinishedGroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishedGroupId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HuntingRevealFinalNotify other) {
      if (other == null) {
        return;
      }
      if (other.finalPosition_ != null) {
        if (finalPosition_ == null) {
          FinalPosition = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        FinalPosition.MergeFrom(other.FinalPosition);
      }
      if (other.huntingPair_ != null) {
        if (huntingPair_ == null) {
          HuntingPair = new global::Weedwacker.Shared.Network.Proto.HuntingPair();
        }
        HuntingPair.MergeFrom(other.HuntingPair);
      }
      if (other.FinishedGroupId != 0) {
        FinishedGroupId = other.FinishedGroupId;
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
            if (finalPosition_ == null) {
              FinalPosition = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(FinalPosition);
            break;
          }
          case 74: {
            if (huntingPair_ == null) {
              HuntingPair = new global::Weedwacker.Shared.Network.Proto.HuntingPair();
            }
            input.ReadMessage(HuntingPair);
            break;
          }
          case 112: {
            FinishedGroupId = input.ReadUInt32();
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
            if (finalPosition_ == null) {
              FinalPosition = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(FinalPosition);
            break;
          }
          case 74: {
            if (huntingPair_ == null) {
              HuntingPair = new global::Weedwacker.Shared.Network.Proto.HuntingPair();
            }
            input.ReadMessage(HuntingPair);
            break;
          }
          case 112: {
            FinishedGroupId = input.ReadUInt32();
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
