// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WidgetDoBagReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WidgetDoBagReq.proto</summary>
  public static partial class WidgetDoBagReqReflection {

    #region Descriptor
    /// <summary>File descriptor for WidgetDoBagReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WidgetDoBagReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRXaWRnZXREb0JhZ1JlcS5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90bxoeV2lkZ2V0Q3JlYXRlTG9jYXRpb25JbmZvLnByb3RvGhdX",
            "aWRnZXRDcmVhdG9ySW5mby5wcm90byLZAQoOV2lkZ2V0RG9CYWdSZXESEwoL",
            "bWF0ZXJpYWxfaWQYCyABKA0SUwoNbG9jYXRpb25faW5mbxiyAyABKAsyOS5X",
            "ZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLldpZGdldENyZWF0ZUxv",
            "Y2F0aW9uSW5mb0gAElIKE3dpZGdldF9jcmVhdG9yX2luZm8YugogASgLMjIu",
            "V2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90by5XaWRnZXRDcmVhdG9y",
            "SW5mb0gAQgkKB29wX2luZm9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.WidgetCreateLocationInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.WidgetCreatorInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WidgetDoBagReq), global::Weedwacker.Shared.Network.Proto.WidgetDoBagReq.Parser, new[]{ "MaterialId", "LocationInfo", "WidgetCreatorInfo" }, new[]{ "OpInfo" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4269;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class WidgetDoBagReq : pb::IMessage<WidgetDoBagReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WidgetDoBagReq> _parser = new pb::MessageParser<WidgetDoBagReq>(() => new WidgetDoBagReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WidgetDoBagReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WidgetDoBagReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetDoBagReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetDoBagReq(WidgetDoBagReq other) : this() {
      materialId_ = other.materialId_;
      switch (other.OpInfoCase) {
        case OpInfoOneofCase.LocationInfo:
          LocationInfo = other.LocationInfo.Clone();
          break;
        case OpInfoOneofCase.WidgetCreatorInfo:
          WidgetCreatorInfo = other.WidgetCreatorInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetDoBagReq Clone() {
      return new WidgetDoBagReq(this);
    }

    /// <summary>Field number for the "material_id" field.</summary>
    public const int MaterialIdFieldNumber = 11;
    private uint materialId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaterialId {
      get { return materialId_; }
      set {
        materialId_ = value;
      }
    }

    /// <summary>Field number for the "location_info" field.</summary>
    public const int LocationInfoFieldNumber = 434;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.WidgetCreateLocationInfo LocationInfo {
      get { return opInfoCase_ == OpInfoOneofCase.LocationInfo ? (global::Weedwacker.Shared.Network.Proto.WidgetCreateLocationInfo) opInfo_ : null; }
      set {
        opInfo_ = value;
        opInfoCase_ = value == null ? OpInfoOneofCase.None : OpInfoOneofCase.LocationInfo;
      }
    }

    /// <summary>Field number for the "widget_creator_info" field.</summary>
    public const int WidgetCreatorInfoFieldNumber = 1338;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.WidgetCreatorInfo WidgetCreatorInfo {
      get { return opInfoCase_ == OpInfoOneofCase.WidgetCreatorInfo ? (global::Weedwacker.Shared.Network.Proto.WidgetCreatorInfo) opInfo_ : null; }
      set {
        opInfo_ = value;
        opInfoCase_ = value == null ? OpInfoOneofCase.None : OpInfoOneofCase.WidgetCreatorInfo;
      }
    }

    private object opInfo_;
    /// <summary>Enum of possible cases for the "op_info" oneof.</summary>
    public enum OpInfoOneofCase {
      None = 0,
      LocationInfo = 434,
      WidgetCreatorInfo = 1338,
    }
    private OpInfoOneofCase opInfoCase_ = OpInfoOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpInfoOneofCase OpInfoCase {
      get { return opInfoCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearOpInfo() {
      opInfoCase_ = OpInfoOneofCase.None;
      opInfo_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WidgetDoBagReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WidgetDoBagReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MaterialId != other.MaterialId) return false;
      if (!object.Equals(LocationInfo, other.LocationInfo)) return false;
      if (!object.Equals(WidgetCreatorInfo, other.WidgetCreatorInfo)) return false;
      if (OpInfoCase != other.OpInfoCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MaterialId != 0) hash ^= MaterialId.GetHashCode();
      if (opInfoCase_ == OpInfoOneofCase.LocationInfo) hash ^= LocationInfo.GetHashCode();
      if (opInfoCase_ == OpInfoOneofCase.WidgetCreatorInfo) hash ^= WidgetCreatorInfo.GetHashCode();
      hash ^= (int) opInfoCase_;
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
      if (MaterialId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MaterialId);
      }
      if (opInfoCase_ == OpInfoOneofCase.LocationInfo) {
        output.WriteRawTag(146, 27);
        output.WriteMessage(LocationInfo);
      }
      if (opInfoCase_ == OpInfoOneofCase.WidgetCreatorInfo) {
        output.WriteRawTag(210, 83);
        output.WriteMessage(WidgetCreatorInfo);
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
      if (MaterialId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MaterialId);
      }
      if (opInfoCase_ == OpInfoOneofCase.LocationInfo) {
        output.WriteRawTag(146, 27);
        output.WriteMessage(LocationInfo);
      }
      if (opInfoCase_ == OpInfoOneofCase.WidgetCreatorInfo) {
        output.WriteRawTag(210, 83);
        output.WriteMessage(WidgetCreatorInfo);
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
      if (MaterialId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaterialId);
      }
      if (opInfoCase_ == OpInfoOneofCase.LocationInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(LocationInfo);
      }
      if (opInfoCase_ == OpInfoOneofCase.WidgetCreatorInfo) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(WidgetCreatorInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WidgetDoBagReq other) {
      if (other == null) {
        return;
      }
      if (other.MaterialId != 0) {
        MaterialId = other.MaterialId;
      }
      switch (other.OpInfoCase) {
        case OpInfoOneofCase.LocationInfo:
          if (LocationInfo == null) {
            LocationInfo = new global::Weedwacker.Shared.Network.Proto.WidgetCreateLocationInfo();
          }
          LocationInfo.MergeFrom(other.LocationInfo);
          break;
        case OpInfoOneofCase.WidgetCreatorInfo:
          if (WidgetCreatorInfo == null) {
            WidgetCreatorInfo = new global::Weedwacker.Shared.Network.Proto.WidgetCreatorInfo();
          }
          WidgetCreatorInfo.MergeFrom(other.WidgetCreatorInfo);
          break;
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
          case 88: {
            MaterialId = input.ReadUInt32();
            break;
          }
          case 3474: {
            global::Weedwacker.Shared.Network.Proto.WidgetCreateLocationInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.WidgetCreateLocationInfo();
            if (opInfoCase_ == OpInfoOneofCase.LocationInfo) {
              subBuilder.MergeFrom(LocationInfo);
            }
            input.ReadMessage(subBuilder);
            LocationInfo = subBuilder;
            break;
          }
          case 10706: {
            global::Weedwacker.Shared.Network.Proto.WidgetCreatorInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.WidgetCreatorInfo();
            if (opInfoCase_ == OpInfoOneofCase.WidgetCreatorInfo) {
              subBuilder.MergeFrom(WidgetCreatorInfo);
            }
            input.ReadMessage(subBuilder);
            WidgetCreatorInfo = subBuilder;
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
          case 88: {
            MaterialId = input.ReadUInt32();
            break;
          }
          case 3474: {
            global::Weedwacker.Shared.Network.Proto.WidgetCreateLocationInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.WidgetCreateLocationInfo();
            if (opInfoCase_ == OpInfoOneofCase.LocationInfo) {
              subBuilder.MergeFrom(LocationInfo);
            }
            input.ReadMessage(subBuilder);
            LocationInfo = subBuilder;
            break;
          }
          case 10706: {
            global::Weedwacker.Shared.Network.Proto.WidgetCreatorInfo subBuilder = new global::Weedwacker.Shared.Network.Proto.WidgetCreatorInfo();
            if (opInfoCase_ == OpInfoOneofCase.WidgetCreatorInfo) {
              subBuilder.MergeFrom(WidgetCreatorInfo);
            }
            input.ReadMessage(subBuilder);
            WidgetCreatorInfo = subBuilder;
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
