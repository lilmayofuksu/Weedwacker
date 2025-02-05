// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FurnitureMakeBeHelpedNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FurnitureMakeBeHelpedNotify.proto</summary>
  public static partial class FurnitureMakeBeHelpedNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for FurnitureMakeBeHelpedNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FurnitureMakeBeHelpedNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFGdXJuaXR1cmVNYWtlQmVIZWxwZWROb3RpZnkucHJvdG8SH1dlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG8aH0Z1cm5pdHVyZU1ha2VCZUhlbHBl",
            "ZERhdGEucHJvdG8aF0Z1cm5pdHVyZU1ha2VTbG90LnByb3RvIs4BChtGdXJu",
            "aXR1cmVNYWtlQmVIZWxwZWROb3RpZnkSXgoaZnVybml0dXJlX21ha2VfaGVs",
            "cGVkX2RhdGEYDCABKAsyOi5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlBy",
            "b3RvLkZ1cm5pdHVyZU1ha2VCZUhlbHBlZERhdGESTwoTZnVybml0dXJlX21h",
            "a2Vfc2xvdBgDIAEoCzIyLldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJv",
            "dG8uRnVybml0dXJlTWFrZVNsb3RiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.FurnitureMakeBeHelpedDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.FurnitureMakeSlotReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FurnitureMakeBeHelpedNotify), global::Weedwacker.Shared.Network.Proto.FurnitureMakeBeHelpedNotify.Parser, new[]{ "FurnitureMakeHelpedData", "FurnitureMakeSlot" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4766;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class FurnitureMakeBeHelpedNotify : pb::IMessage<FurnitureMakeBeHelpedNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FurnitureMakeBeHelpedNotify> _parser = new pb::MessageParser<FurnitureMakeBeHelpedNotify>(() => new FurnitureMakeBeHelpedNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FurnitureMakeBeHelpedNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FurnitureMakeBeHelpedNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FurnitureMakeBeHelpedNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FurnitureMakeBeHelpedNotify(FurnitureMakeBeHelpedNotify other) : this() {
      furnitureMakeHelpedData_ = other.furnitureMakeHelpedData_ != null ? other.furnitureMakeHelpedData_.Clone() : null;
      furnitureMakeSlot_ = other.furnitureMakeSlot_ != null ? other.furnitureMakeSlot_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FurnitureMakeBeHelpedNotify Clone() {
      return new FurnitureMakeBeHelpedNotify(this);
    }

    /// <summary>Field number for the "furniture_make_helped_data" field.</summary>
    public const int FurnitureMakeHelpedDataFieldNumber = 12;
    private global::Weedwacker.Shared.Network.Proto.FurnitureMakeBeHelpedData furnitureMakeHelpedData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.FurnitureMakeBeHelpedData FurnitureMakeHelpedData {
      get { return furnitureMakeHelpedData_; }
      set {
        furnitureMakeHelpedData_ = value;
      }
    }

    /// <summary>Field number for the "furniture_make_slot" field.</summary>
    public const int FurnitureMakeSlotFieldNumber = 3;
    private global::Weedwacker.Shared.Network.Proto.FurnitureMakeSlot furnitureMakeSlot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.FurnitureMakeSlot FurnitureMakeSlot {
      get { return furnitureMakeSlot_; }
      set {
        furnitureMakeSlot_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FurnitureMakeBeHelpedNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FurnitureMakeBeHelpedNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FurnitureMakeHelpedData, other.FurnitureMakeHelpedData)) return false;
      if (!object.Equals(FurnitureMakeSlot, other.FurnitureMakeSlot)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (furnitureMakeHelpedData_ != null) hash ^= FurnitureMakeHelpedData.GetHashCode();
      if (furnitureMakeSlot_ != null) hash ^= FurnitureMakeSlot.GetHashCode();
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
      if (furnitureMakeSlot_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(FurnitureMakeSlot);
      }
      if (furnitureMakeHelpedData_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(FurnitureMakeHelpedData);
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
      if (furnitureMakeSlot_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(FurnitureMakeSlot);
      }
      if (furnitureMakeHelpedData_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(FurnitureMakeHelpedData);
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
      if (furnitureMakeHelpedData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FurnitureMakeHelpedData);
      }
      if (furnitureMakeSlot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FurnitureMakeSlot);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FurnitureMakeBeHelpedNotify other) {
      if (other == null) {
        return;
      }
      if (other.furnitureMakeHelpedData_ != null) {
        if (furnitureMakeHelpedData_ == null) {
          FurnitureMakeHelpedData = new global::Weedwacker.Shared.Network.Proto.FurnitureMakeBeHelpedData();
        }
        FurnitureMakeHelpedData.MergeFrom(other.FurnitureMakeHelpedData);
      }
      if (other.furnitureMakeSlot_ != null) {
        if (furnitureMakeSlot_ == null) {
          FurnitureMakeSlot = new global::Weedwacker.Shared.Network.Proto.FurnitureMakeSlot();
        }
        FurnitureMakeSlot.MergeFrom(other.FurnitureMakeSlot);
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
            if (furnitureMakeSlot_ == null) {
              FurnitureMakeSlot = new global::Weedwacker.Shared.Network.Proto.FurnitureMakeSlot();
            }
            input.ReadMessage(FurnitureMakeSlot);
            break;
          }
          case 98: {
            if (furnitureMakeHelpedData_ == null) {
              FurnitureMakeHelpedData = new global::Weedwacker.Shared.Network.Proto.FurnitureMakeBeHelpedData();
            }
            input.ReadMessage(FurnitureMakeHelpedData);
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
            if (furnitureMakeSlot_ == null) {
              FurnitureMakeSlot = new global::Weedwacker.Shared.Network.Proto.FurnitureMakeSlot();
            }
            input.ReadMessage(FurnitureMakeSlot);
            break;
          }
          case 98: {
            if (furnitureMakeHelpedData_ == null) {
              FurnitureMakeHelpedData = new global::Weedwacker.Shared.Network.Proto.FurnitureMakeBeHelpedData();
            }
            input.ReadMessage(FurnitureMakeHelpedData);
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
