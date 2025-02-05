// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ObstacleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ObstacleInfo.proto</summary>
  public static partial class ObstacleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ObstacleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ObstacleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJPYnN0YWNsZUluZm8ucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdv",
            "cmsuUHJvdG8aFE1hdGhRdWF0ZXJuaW9uLnByb3RvGgxWZWN0b3IucHJvdG8a",
            "EFZlY3RvcjNJbnQucHJvdG8i/AIKDE9ic3RhY2xlSW5mbxJBCghyb3RhdGlv",
            "bhgLIAEoCzIvLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8uTWF0",
            "aFF1YXRlcm5pb24SRgoFc2hhcGUYAiABKA4yNy5XZWVkd2Fja2VyLlNoYXJl",
            "ZC5OZXR3b3JrLlByb3RvLk9ic3RhY2xlSW5mby5TaGFwZVR5cGUSPAoHZXh0",
            "ZW50cxgEIAEoCzIrLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8u",
            "VmVjdG9yM0ludBI3CgZjZW50ZXIYByABKAsyJy5XZWVkd2Fja2VyLlNoYXJl",
            "ZC5OZXR3b3JrLlByb3RvLlZlY3RvchITCgtvYnN0YWNsZV9pZBgKIAEoBSJV",
            "CglTaGFwZVR5cGUSJQohU0hBUEVfVFlQRV9PQlNUQUNMRV9TSEFQRV9DQVBT",
            "VUxFEAASIQodU0hBUEVfVFlQRV9PQlNUQUNMRV9TSEFQRV9CT1gQAWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MathQuaternionReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.Vector3IntReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ObstacleInfo), global::Weedwacker.Shared.Network.Proto.ObstacleInfo.Parser, new[]{ "Rotation", "Shape", "Extents", "Center", "ObstacleId" }, null, new[]{ typeof(global::Weedwacker.Shared.Network.Proto.ObstacleInfo.Types.ShapeType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ObstacleInfo : pb::IMessage<ObstacleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ObstacleInfo> _parser = new pb::MessageParser<ObstacleInfo>(() => new ObstacleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ObstacleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ObstacleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ObstacleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ObstacleInfo(ObstacleInfo other) : this() {
      rotation_ = other.rotation_ != null ? other.rotation_.Clone() : null;
      shape_ = other.shape_;
      extents_ = other.extents_ != null ? other.extents_.Clone() : null;
      center_ = other.center_ != null ? other.center_.Clone() : null;
      obstacleId_ = other.obstacleId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ObstacleInfo Clone() {
      return new ObstacleInfo(this);
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 11;
    private global::Weedwacker.Shared.Network.Proto.MathQuaternion rotation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.MathQuaternion Rotation {
      get { return rotation_; }
      set {
        rotation_ = value;
      }
    }

    /// <summary>Field number for the "shape" field.</summary>
    public const int ShapeFieldNumber = 2;
    private global::Weedwacker.Shared.Network.Proto.ObstacleInfo.Types.ShapeType shape_ = global::Weedwacker.Shared.Network.Proto.ObstacleInfo.Types.ShapeType.ObstacleShapeCapsule;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ObstacleInfo.Types.ShapeType Shape {
      get { return shape_; }
      set {
        shape_ = value;
      }
    }

    /// <summary>Field number for the "extents" field.</summary>
    public const int ExtentsFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.Vector3Int extents_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector3Int Extents {
      get { return extents_; }
      set {
        extents_ = value;
      }
    }

    /// <summary>Field number for the "center" field.</summary>
    public const int CenterFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.Vector center_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector Center {
      get { return center_; }
      set {
        center_ = value;
      }
    }

    /// <summary>Field number for the "obstacle_id" field.</summary>
    public const int ObstacleIdFieldNumber = 10;
    private int obstacleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ObstacleId {
      get { return obstacleId_; }
      set {
        obstacleId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ObstacleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ObstacleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Rotation, other.Rotation)) return false;
      if (Shape != other.Shape) return false;
      if (!object.Equals(Extents, other.Extents)) return false;
      if (!object.Equals(Center, other.Center)) return false;
      if (ObstacleId != other.ObstacleId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rotation_ != null) hash ^= Rotation.GetHashCode();
      if (Shape != global::Weedwacker.Shared.Network.Proto.ObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) hash ^= Shape.GetHashCode();
      if (extents_ != null) hash ^= Extents.GetHashCode();
      if (center_ != null) hash ^= Center.GetHashCode();
      if (ObstacleId != 0) hash ^= ObstacleId.GetHashCode();
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
      if (Shape != global::Weedwacker.Shared.Network.Proto.ObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Shape);
      }
      if (extents_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Extents);
      }
      if (center_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Center);
      }
      if (ObstacleId != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(ObstacleId);
      }
      if (rotation_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Rotation);
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
      if (Shape != global::Weedwacker.Shared.Network.Proto.ObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Shape);
      }
      if (extents_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Extents);
      }
      if (center_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Center);
      }
      if (ObstacleId != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(ObstacleId);
      }
      if (rotation_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Rotation);
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
      if (rotation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rotation);
      }
      if (Shape != global::Weedwacker.Shared.Network.Proto.ObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Shape);
      }
      if (extents_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Extents);
      }
      if (center_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Center);
      }
      if (ObstacleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ObstacleId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ObstacleInfo other) {
      if (other == null) {
        return;
      }
      if (other.rotation_ != null) {
        if (rotation_ == null) {
          Rotation = new global::Weedwacker.Shared.Network.Proto.MathQuaternion();
        }
        Rotation.MergeFrom(other.Rotation);
      }
      if (other.Shape != global::Weedwacker.Shared.Network.Proto.ObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) {
        Shape = other.Shape;
      }
      if (other.extents_ != null) {
        if (extents_ == null) {
          Extents = new global::Weedwacker.Shared.Network.Proto.Vector3Int();
        }
        Extents.MergeFrom(other.Extents);
      }
      if (other.center_ != null) {
        if (center_ == null) {
          Center = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        Center.MergeFrom(other.Center);
      }
      if (other.ObstacleId != 0) {
        ObstacleId = other.ObstacleId;
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
            Shape = (global::Weedwacker.Shared.Network.Proto.ObstacleInfo.Types.ShapeType) input.ReadEnum();
            break;
          }
          case 34: {
            if (extents_ == null) {
              Extents = new global::Weedwacker.Shared.Network.Proto.Vector3Int();
            }
            input.ReadMessage(Extents);
            break;
          }
          case 58: {
            if (center_ == null) {
              Center = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Center);
            break;
          }
          case 80: {
            ObstacleId = input.ReadInt32();
            break;
          }
          case 90: {
            if (rotation_ == null) {
              Rotation = new global::Weedwacker.Shared.Network.Proto.MathQuaternion();
            }
            input.ReadMessage(Rotation);
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
            Shape = (global::Weedwacker.Shared.Network.Proto.ObstacleInfo.Types.ShapeType) input.ReadEnum();
            break;
          }
          case 34: {
            if (extents_ == null) {
              Extents = new global::Weedwacker.Shared.Network.Proto.Vector3Int();
            }
            input.ReadMessage(Extents);
            break;
          }
          case 58: {
            if (center_ == null) {
              Center = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(Center);
            break;
          }
          case 80: {
            ObstacleId = input.ReadInt32();
            break;
          }
          case 90: {
            if (rotation_ == null) {
              Rotation = new global::Weedwacker.Shared.Network.Proto.MathQuaternion();
            }
            input.ReadMessage(Rotation);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ObstacleInfo message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum ShapeType {
        [pbr::OriginalName("SHAPE_TYPE_OBSTACLE_SHAPE_CAPSULE")] ObstacleShapeCapsule = 0,
        [pbr::OriginalName("SHAPE_TYPE_OBSTACLE_SHAPE_BOX")] ObstacleShapeBox = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
