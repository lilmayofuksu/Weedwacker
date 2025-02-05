// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtRushMoveInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EvtRushMoveInfo.proto</summary>
  public static partial class EvtRushMoveInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtRushMoveInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtRushMoveInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVFdnRSdXNoTW92ZUluZm8ucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5l",
            "dHdvcmsuUHJvdG8aDFZlY3Rvci5wcm90byLqAgoPRXZ0UnVzaE1vdmVJbmZv",
            "EjkKCHZlbG9jaXR5GAggASgLMicuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29y",
            "ay5Qcm90by5WZWN0b3ISFwoPc3RhdGVfbmFtZV9oYXNoGAQgASgFEhEKCWVu",
            "dGl0eV9pZBgMIAEoDRI0CgNwb3MYByABKAsyJy5XZWVkd2Fja2VyLlNoYXJl",
            "ZC5OZXR3b3JrLlByb3RvLlZlY3RvchIaChJmYWNlX2FuZ2xlX2NvbXBhY3QY",
            "ASABKAUSEgoKdGltZV9yYW5nZRgNIAEoAhJEChNVbmszMzAwX05FQk1EREdQ",
            "Qk9OGA8gASgLMicuV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5W",
            "ZWN0b3ISRAoTVW5rMzMwMF9GR0FQQkpJUEpGRxgFIAEoCzInLldlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uVmVjdG9yYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EvtRushMoveInfo), global::Weedwacker.Shared.Network.Proto.EvtRushMoveInfo.Parser, new[]{ "Velocity", "StateNameHash", "EntityId", "Pos", "FaceAngleCompact", "TimeRange", "Unk3300NEBMDDGPBON", "Unk3300FGAPBJIPJFG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtRushMoveInfo : pb::IMessage<EvtRushMoveInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtRushMoveInfo> _parser = new pb::MessageParser<EvtRushMoveInfo>(() => new EvtRushMoveInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtRushMoveInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EvtRushMoveInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtRushMoveInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtRushMoveInfo(EvtRushMoveInfo other) : this() {
      velocity_ = other.velocity_ != null ? other.velocity_.Clone() : null;
      stateNameHash_ = other.stateNameHash_;
      entityId_ = other.entityId_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      faceAngleCompact_ = other.faceAngleCompact_;
      timeRange_ = other.timeRange_;
      unk3300NEBMDDGPBON_ = other.unk3300NEBMDDGPBON_ != null ? other.unk3300NEBMDDGPBON_.Clone() : null;
      unk3300FGAPBJIPJFG_ = other.unk3300FGAPBJIPJFG_ != null ? other.unk3300FGAPBJIPJFG_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtRushMoveInfo Clone() {
      return new EvtRushMoveInfo(this);
    }

    /// <summary>Field number for the "velocity" field.</summary>
    public const int VelocityFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.Vector velocity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Velocity {
      get { return velocity_; }
      set {
        velocity_ = value;
      }
    }

    /// <summary>Field number for the "state_name_hash" field.</summary>
    public const int StateNameHashFieldNumber = 4;
    private int stateNameHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int StateNameHash {
      get { return stateNameHash_; }
      set {
        stateNameHash_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 12;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "face_angle_compact" field.</summary>
    public const int FaceAngleCompactFieldNumber = 1;
    private int faceAngleCompact_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int FaceAngleCompact {
      get { return faceAngleCompact_; }
      set {
        faceAngleCompact_ = value;
      }
    }

    /// <summary>Field number for the "time_range" field.</summary>
    public const int TimeRangeFieldNumber = 13;
    private float timeRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float TimeRange {
      get { return timeRange_; }
      set {
        timeRange_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_NEBMDDGPBON" field.</summary>
    public const int Unk3300NEBMDDGPBONFieldNumber = 15;
    private global::Weedwacker.Shared.Network.Proto.Vector unk3300NEBMDDGPBON_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Unk3300NEBMDDGPBON {
      get { return unk3300NEBMDDGPBON_; }
      set {
        unk3300NEBMDDGPBON_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_FGAPBJIPJFG" field.</summary>
    public const int Unk3300FGAPBJIPJFGFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.Vector unk3300FGAPBJIPJFG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Unk3300FGAPBJIPJFG {
      get { return unk3300FGAPBJIPJFG_; }
      set {
        unk3300FGAPBJIPJFG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtRushMoveInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtRushMoveInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Velocity, other.Velocity)) return false;
      if (StateNameHash != other.StateNameHash) return false;
      if (EntityId != other.EntityId) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (FaceAngleCompact != other.FaceAngleCompact) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TimeRange, other.TimeRange)) return false;
      if (!object.Equals(Unk3300NEBMDDGPBON, other.Unk3300NEBMDDGPBON)) return false;
      if (!object.Equals(Unk3300FGAPBJIPJFG, other.Unk3300FGAPBJIPJFG)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (velocity_ != null) hash ^= Velocity.GetHashCode();
      if (StateNameHash != 0) hash ^= StateNameHash.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (FaceAngleCompact != 0) hash ^= FaceAngleCompact.GetHashCode();
      if (TimeRange != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TimeRange);
      if (unk3300NEBMDDGPBON_ != null) hash ^= Unk3300NEBMDDGPBON.GetHashCode();
      if (unk3300FGAPBJIPJFG_ != null) hash ^= Unk3300FGAPBJIPJFG.GetHashCode();
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
      if (FaceAngleCompact != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(FaceAngleCompact);
      }
      if (StateNameHash != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(StateNameHash);
      }
      if (unk3300FGAPBJIPJFG_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Unk3300FGAPBJIPJFG);
      }
      if (pos_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Pos);
      }
      if (velocity_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Velocity);
      }
      if (EntityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(EntityId);
      }
      if (TimeRange != 0F) {
        output.WriteRawTag(109);
        output.WriteFloat(TimeRange);
      }
      if (unk3300NEBMDDGPBON_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Unk3300NEBMDDGPBON);
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
      if (FaceAngleCompact != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(FaceAngleCompact);
      }
      if (StateNameHash != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(StateNameHash);
      }
      if (unk3300FGAPBJIPJFG_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Unk3300FGAPBJIPJFG);
      }
      if (pos_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Pos);
      }
      if (velocity_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Velocity);
      }
      if (EntityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(EntityId);
      }
      if (TimeRange != 0F) {
        output.WriteRawTag(109);
        output.WriteFloat(TimeRange);
      }
      if (unk3300NEBMDDGPBON_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Unk3300NEBMDDGPBON);
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
      if (velocity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Velocity);
      }
      if (StateNameHash != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StateNameHash);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (FaceAngleCompact != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FaceAngleCompact);
      }
      if (TimeRange != 0F) {
        size += 1 + 4;
      }
      if (unk3300NEBMDDGPBON_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk3300NEBMDDGPBON);
      }
      if (unk3300FGAPBJIPJFG_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk3300FGAPBJIPJFG);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtRushMoveInfo other) {
      if (other == null) {
        return;
      }
      if (other.velocity_ != null) {
        if (velocity_ == null) {
          Velocity = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Velocity.MergeFrom(other.Velocity);
      }
      if (other.StateNameHash != 0) {
        StateNameHash = other.StateNameHash;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.FaceAngleCompact != 0) {
        FaceAngleCompact = other.FaceAngleCompact;
      }
      if (other.TimeRange != 0F) {
        TimeRange = other.TimeRange;
      }
      if (other.unk3300NEBMDDGPBON_ != null) {
        if (unk3300NEBMDDGPBON_ == null) {
          Unk3300NEBMDDGPBON = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Unk3300NEBMDDGPBON.MergeFrom(other.Unk3300NEBMDDGPBON);
      }
      if (other.unk3300FGAPBJIPJFG_ != null) {
        if (unk3300FGAPBJIPJFG_ == null) {
          Unk3300FGAPBJIPJFG = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Unk3300FGAPBJIPJFG.MergeFrom(other.Unk3300FGAPBJIPJFG);
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
            FaceAngleCompact = input.ReadInt32();
            break;
          }
          case 32: {
            StateNameHash = input.ReadInt32();
            break;
          }
          case 42: {
            if (unk3300FGAPBJIPJFG_ == null) {
              Unk3300FGAPBJIPJFG = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Unk3300FGAPBJIPJFG);
            break;
          }
          case 58: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 66: {
            if (velocity_ == null) {
              Velocity = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Velocity);
            break;
          }
          case 96: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 109: {
            TimeRange = input.ReadFloat();
            break;
          }
          case 122: {
            if (unk3300NEBMDDGPBON_ == null) {
              Unk3300NEBMDDGPBON = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Unk3300NEBMDDGPBON);
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
            FaceAngleCompact = input.ReadInt32();
            break;
          }
          case 32: {
            StateNameHash = input.ReadInt32();
            break;
          }
          case 42: {
            if (unk3300FGAPBJIPJFG_ == null) {
              Unk3300FGAPBJIPJFG = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Unk3300FGAPBJIPJFG);
            break;
          }
          case 58: {
            if (pos_ == null) {
              Pos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 66: {
            if (velocity_ == null) {
              Velocity = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Velocity);
            break;
          }
          case 96: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 109: {
            TimeRange = input.ReadFloat();
            break;
          }
          case 122: {
            if (unk3300NEBMDDGPBON_ == null) {
              Unk3300NEBMDDGPBON = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Unk3300NEBMDDGPBON);
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
