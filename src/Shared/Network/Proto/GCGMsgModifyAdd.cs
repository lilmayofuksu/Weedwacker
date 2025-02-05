// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgModifyAdd.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGMsgModifyAdd.proto</summary>
  public static partial class GCGMsgModifyAddReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMsgModifyAdd.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMsgModifyAddReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVHQ0dNc2dNb2RpZnlBZGQucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG8aD0dDR1JlYXNvbi5wcm90byKiAQoPR0NHTXNnTW9kaWZ5",
            "QWRkEhcKD293bmVyX2NhcmRfZ3VpZBgLIAEoDRILCgNwb3MYCSABKA0SFgoO",
            "Y2FyZF9ndWlkX2xpc3QYAyADKA0SFQoNY29udHJvbGxlcl9pZBgMIAEoDRI6",
            "CgZyZWFzb24YDyABKA4yKi5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlBy",
            "b3RvLkdDR1JlYXNvbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGMsgModifyAdd), global::Weedwacker.Shared.Network.Proto.GCGMsgModifyAdd.Parser, new[]{ "OwnerCardGuid", "Pos", "CardGuidList", "ControllerId", "Reason" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMsgModifyAdd : pb::IMessage<GCGMsgModifyAdd>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMsgModifyAdd> _parser = new pb::MessageParser<GCGMsgModifyAdd>(() => new GCGMsgModifyAdd());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMsgModifyAdd> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGMsgModifyAddReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgModifyAdd() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgModifyAdd(GCGMsgModifyAdd other) : this() {
      ownerCardGuid_ = other.ownerCardGuid_;
      pos_ = other.pos_;
      cardGuidList_ = other.cardGuidList_.Clone();
      controllerId_ = other.controllerId_;
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgModifyAdd Clone() {
      return new GCGMsgModifyAdd(this);
    }

    /// <summary>Field number for the "owner_card_guid" field.</summary>
    public const int OwnerCardGuidFieldNumber = 11;
    private uint ownerCardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerCardGuid {
      get { return ownerCardGuid_; }
      set {
        ownerCardGuid_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 9;
    private uint pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "card_guid_list" field.</summary>
    public const int CardGuidListFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_cardGuidList_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> cardGuidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CardGuidList {
      get { return cardGuidList_; }
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 12;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 15;
    private global::Weedwacker.Shared.Network.Proto.GCGReason reason_ = global::Weedwacker.Shared.Network.Proto.GCGReason.Default;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.GCGReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMsgModifyAdd);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMsgModifyAdd other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OwnerCardGuid != other.OwnerCardGuid) return false;
      if (Pos != other.Pos) return false;
      if(!cardGuidList_.Equals(other.cardGuidList_)) return false;
      if (ControllerId != other.ControllerId) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OwnerCardGuid != 0) hash ^= OwnerCardGuid.GetHashCode();
      if (Pos != 0) hash ^= Pos.GetHashCode();
      hash ^= cardGuidList_.GetHashCode();
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) hash ^= Reason.GetHashCode();
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
      cardGuidList_.WriteTo(output, _repeated_cardGuidList_codec);
      if (Pos != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Pos);
      }
      if (OwnerCardGuid != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(OwnerCardGuid);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ControllerId);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Reason);
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
      cardGuidList_.WriteTo(ref output, _repeated_cardGuidList_codec);
      if (Pos != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Pos);
      }
      if (OwnerCardGuid != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(OwnerCardGuid);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ControllerId);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Reason);
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
      if (OwnerCardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerCardGuid);
      }
      if (Pos != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Pos);
      }
      size += cardGuidList_.CalculateSize(_repeated_cardGuidList_codec);
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      if (Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMsgModifyAdd other) {
      if (other == null) {
        return;
      }
      if (other.OwnerCardGuid != 0) {
        OwnerCardGuid = other.OwnerCardGuid;
      }
      if (other.Pos != 0) {
        Pos = other.Pos;
      }
      cardGuidList_.Add(other.cardGuidList_);
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
      }
      if (other.Reason != global::Weedwacker.Shared.Network.Proto.GCGReason.Default) {
        Reason = other.Reason;
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
          case 26:
          case 24: {
            cardGuidList_.AddEntriesFrom(input, _repeated_cardGuidList_codec);
            break;
          }
          case 72: {
            Pos = input.ReadUInt32();
            break;
          }
          case 88: {
            OwnerCardGuid = input.ReadUInt32();
            break;
          }
          case 96: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 120: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GCGReason) input.ReadEnum();
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
          case 26:
          case 24: {
            cardGuidList_.AddEntriesFrom(ref input, _repeated_cardGuidList_codec);
            break;
          }
          case 72: {
            Pos = input.ReadUInt32();
            break;
          }
          case 88: {
            OwnerCardGuid = input.ReadUInt32();
            break;
          }
          case 96: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 120: {
            Reason = (global::Weedwacker.Shared.Network.Proto.GCGReason) input.ReadEnum();
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
