// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilitySyncStateInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AbilitySyncStateInfo.proto</summary>
  public static partial class AbilitySyncStateInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilitySyncStateInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilitySyncStateInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpBYmlsaXR5U3luY1N0YXRlSW5mby5wcm90bxIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90bxobQWJpbGl0eUFwcGxpZWRBYmlsaXR5LnByb3Rv",
            "GhxBYmlsaXR5QXBwbGllZE1vZGlmaWVyLnByb3RvGh1BYmlsaXR5TWl4aW5S",
            "ZWNvdmVySW5mby5wcm90bxodQWJpbGl0eVNjYWxhclZhbHVlRW50cnkucHJv",
            "dG8i1QMKFEFiaWxpdHlTeW5jU3RhdGVJbmZvEhEKCWlzX2luaXRlZBgBIAEo",
            "CBJTChFkeW5hbWljX3ZhbHVlX21hcBgCIAMoCzI4LldlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8uQWJpbGl0eVNjYWxhclZhbHVlRW50cnkSUQoR",
            "YXBwbGllZF9hYmlsaXRpZXMYAyADKAsyNi5XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvLkFiaWxpdHlBcHBsaWVkQWJpbGl0eRJSChFhcHBsaWVk",
            "X21vZGlmaWVycxgEIAMoCzI3LldlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsu",
            "UHJvdG8uQWJpbGl0eUFwcGxpZWRNb2RpZmllchJVChNtaXhpbl9yZWNvdmVy",
            "X2luZm9zGAUgAygLMjguV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90",
            "by5BYmlsaXR5TWl4aW5SZWNvdmVySW5mbxJXChVzZ3ZfZHluYW1pY192YWx1",
            "ZV9tYXAYBiADKAsyOC5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3Rv",
            "LkFiaWxpdHlTY2FsYXJWYWx1ZUVudHJ5YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.AbilityAppliedAbilityReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.AbilityAppliedModifierReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.AbilityMixinRecoverInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.AbilityScalarValueEntryReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AbilitySyncStateInfo), global::Weedwacker.Shared.Network.Proto.AbilitySyncStateInfo.Parser, new[]{ "IsInited", "DynamicValueMap", "AppliedAbilities", "AppliedModifiers", "MixinRecoverInfos", "SgvDynamicValueMap" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilitySyncStateInfo : pb::IMessage<AbilitySyncStateInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilitySyncStateInfo> _parser = new pb::MessageParser<AbilitySyncStateInfo>(() => new AbilitySyncStateInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilitySyncStateInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AbilitySyncStateInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilitySyncStateInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilitySyncStateInfo(AbilitySyncStateInfo other) : this() {
      isInited_ = other.isInited_;
      dynamicValueMap_ = other.dynamicValueMap_.Clone();
      appliedAbilities_ = other.appliedAbilities_.Clone();
      appliedModifiers_ = other.appliedModifiers_.Clone();
      mixinRecoverInfos_ = other.mixinRecoverInfos_.Clone();
      sgvDynamicValueMap_ = other.sgvDynamicValueMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilitySyncStateInfo Clone() {
      return new AbilitySyncStateInfo(this);
    }

    /// <summary>Field number for the "is_inited" field.</summary>
    public const int IsInitedFieldNumber = 1;
    private bool isInited_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsInited {
      get { return isInited_; }
      set {
        isInited_ = value;
      }
    }

    /// <summary>Field number for the "dynamic_value_map" field.</summary>
    public const int DynamicValueMapFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.AbilityScalarValueEntry> _repeated_dynamicValueMap_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.AbilityScalarValueEntry.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityScalarValueEntry> dynamicValueMap_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityScalarValueEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityScalarValueEntry> DynamicValueMap {
      get { return dynamicValueMap_; }
    }

    /// <summary>Field number for the "applied_abilities" field.</summary>
    public const int AppliedAbilitiesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.AbilityAppliedAbility> _repeated_appliedAbilities_codec
        = pb::FieldCodec.ForMessage(26, global::Weedwacker.Shared.Network.Proto.AbilityAppliedAbility.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityAppliedAbility> appliedAbilities_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityAppliedAbility>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityAppliedAbility> AppliedAbilities {
      get { return appliedAbilities_; }
    }

    /// <summary>Field number for the "applied_modifiers" field.</summary>
    public const int AppliedModifiersFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.AbilityAppliedModifier> _repeated_appliedModifiers_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Shared.Network.Proto.AbilityAppliedModifier.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityAppliedModifier> appliedModifiers_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityAppliedModifier>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityAppliedModifier> AppliedModifiers {
      get { return appliedModifiers_; }
    }

    /// <summary>Field number for the "mixin_recover_infos" field.</summary>
    public const int MixinRecoverInfosFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.AbilityMixinRecoverInfo> _repeated_mixinRecoverInfos_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Shared.Network.Proto.AbilityMixinRecoverInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityMixinRecoverInfo> mixinRecoverInfos_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityMixinRecoverInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityMixinRecoverInfo> MixinRecoverInfos {
      get { return mixinRecoverInfos_; }
    }

    /// <summary>Field number for the "sgv_dynamic_value_map" field.</summary>
    public const int SgvDynamicValueMapFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.AbilityScalarValueEntry> _repeated_sgvDynamicValueMap_codec
        = pb::FieldCodec.ForMessage(50, global::Weedwacker.Shared.Network.Proto.AbilityScalarValueEntry.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityScalarValueEntry> sgvDynamicValueMap_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityScalarValueEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.AbilityScalarValueEntry> SgvDynamicValueMap {
      get { return sgvDynamicValueMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilitySyncStateInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilitySyncStateInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsInited != other.IsInited) return false;
      if(!dynamicValueMap_.Equals(other.dynamicValueMap_)) return false;
      if(!appliedAbilities_.Equals(other.appliedAbilities_)) return false;
      if(!appliedModifiers_.Equals(other.appliedModifiers_)) return false;
      if(!mixinRecoverInfos_.Equals(other.mixinRecoverInfos_)) return false;
      if(!sgvDynamicValueMap_.Equals(other.sgvDynamicValueMap_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsInited != false) hash ^= IsInited.GetHashCode();
      hash ^= dynamicValueMap_.GetHashCode();
      hash ^= appliedAbilities_.GetHashCode();
      hash ^= appliedModifiers_.GetHashCode();
      hash ^= mixinRecoverInfos_.GetHashCode();
      hash ^= sgvDynamicValueMap_.GetHashCode();
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
      if (IsInited != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsInited);
      }
      dynamicValueMap_.WriteTo(output, _repeated_dynamicValueMap_codec);
      appliedAbilities_.WriteTo(output, _repeated_appliedAbilities_codec);
      appliedModifiers_.WriteTo(output, _repeated_appliedModifiers_codec);
      mixinRecoverInfos_.WriteTo(output, _repeated_mixinRecoverInfos_codec);
      sgvDynamicValueMap_.WriteTo(output, _repeated_sgvDynamicValueMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IsInited != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsInited);
      }
      dynamicValueMap_.WriteTo(ref output, _repeated_dynamicValueMap_codec);
      appliedAbilities_.WriteTo(ref output, _repeated_appliedAbilities_codec);
      appliedModifiers_.WriteTo(ref output, _repeated_appliedModifiers_codec);
      mixinRecoverInfos_.WriteTo(ref output, _repeated_mixinRecoverInfos_codec);
      sgvDynamicValueMap_.WriteTo(ref output, _repeated_sgvDynamicValueMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IsInited != false) {
        size += 1 + 1;
      }
      size += dynamicValueMap_.CalculateSize(_repeated_dynamicValueMap_codec);
      size += appliedAbilities_.CalculateSize(_repeated_appliedAbilities_codec);
      size += appliedModifiers_.CalculateSize(_repeated_appliedModifiers_codec);
      size += mixinRecoverInfos_.CalculateSize(_repeated_mixinRecoverInfos_codec);
      size += sgvDynamicValueMap_.CalculateSize(_repeated_sgvDynamicValueMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilitySyncStateInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsInited != false) {
        IsInited = other.IsInited;
      }
      dynamicValueMap_.Add(other.dynamicValueMap_);
      appliedAbilities_.Add(other.appliedAbilities_);
      appliedModifiers_.Add(other.appliedModifiers_);
      mixinRecoverInfos_.Add(other.mixinRecoverInfos_);
      sgvDynamicValueMap_.Add(other.sgvDynamicValueMap_);
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
            IsInited = input.ReadBool();
            break;
          }
          case 18: {
            dynamicValueMap_.AddEntriesFrom(input, _repeated_dynamicValueMap_codec);
            break;
          }
          case 26: {
            appliedAbilities_.AddEntriesFrom(input, _repeated_appliedAbilities_codec);
            break;
          }
          case 34: {
            appliedModifiers_.AddEntriesFrom(input, _repeated_appliedModifiers_codec);
            break;
          }
          case 42: {
            mixinRecoverInfos_.AddEntriesFrom(input, _repeated_mixinRecoverInfos_codec);
            break;
          }
          case 50: {
            sgvDynamicValueMap_.AddEntriesFrom(input, _repeated_sgvDynamicValueMap_codec);
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
            IsInited = input.ReadBool();
            break;
          }
          case 18: {
            dynamicValueMap_.AddEntriesFrom(ref input, _repeated_dynamicValueMap_codec);
            break;
          }
          case 26: {
            appliedAbilities_.AddEntriesFrom(ref input, _repeated_appliedAbilities_codec);
            break;
          }
          case 34: {
            appliedModifiers_.AddEntriesFrom(ref input, _repeated_appliedModifiers_codec);
            break;
          }
          case 42: {
            mixinRecoverInfos_.AddEntriesFrom(ref input, _repeated_mixinRecoverInfos_codec);
            break;
          }
          case 50: {
            sgvDynamicValueMap_.AddEntriesFrom(ref input, _repeated_sgvDynamicValueMap_codec);
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
