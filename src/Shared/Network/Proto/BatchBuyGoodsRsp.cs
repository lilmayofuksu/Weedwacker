// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BatchBuyGoodsRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BatchBuyGoodsRsp.proto</summary>
  public static partial class BatchBuyGoodsRspReflection {

    #region Descriptor
    /// <summary>File descriptor for BatchBuyGoodsRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BatchBuyGoodsRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZCYXRjaEJ1eUdvb2RzUnNwLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvGhNCdXlHb29kc1BhcmFtLnByb3RvGg9TaG9wR29vZHMu",
            "cHJvdG8ivgEKEEJhdGNoQnV5R29vZHNSc3ASEQoJc2hvcF90eXBlGAYgASgN",
            "Ej4KCmdvb2RzX2xpc3QYDyADKAsyKi5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3",
            "b3JrLlByb3RvLlNob3BHb29kcxIPCgdyZXRjb2RlGA0gASgFEkYKDmJ1eV9n",
            "b29kc19saXN0GAggAygLMi4uV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Q",
            "cm90by5CdXlHb29kc1BhcmFtYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.BuyGoodsParamReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.ShopGoodsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BatchBuyGoodsRsp), global::Weedwacker.Shared.Network.Proto.BatchBuyGoodsRsp.Parser, new[]{ "ShopType", "GoodsList", "Retcode", "BuyGoodsList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 757;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class BatchBuyGoodsRsp : pb::IMessage<BatchBuyGoodsRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BatchBuyGoodsRsp> _parser = new pb::MessageParser<BatchBuyGoodsRsp>(() => new BatchBuyGoodsRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BatchBuyGoodsRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BatchBuyGoodsRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BatchBuyGoodsRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BatchBuyGoodsRsp(BatchBuyGoodsRsp other) : this() {
      shopType_ = other.shopType_;
      goodsList_ = other.goodsList_.Clone();
      retcode_ = other.retcode_;
      buyGoodsList_ = other.buyGoodsList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BatchBuyGoodsRsp Clone() {
      return new BatchBuyGoodsRsp(this);
    }

    /// <summary>Field number for the "shop_type" field.</summary>
    public const int ShopTypeFieldNumber = 6;
    private uint shopType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShopType {
      get { return shopType_; }
      set {
        shopType_ = value;
      }
    }

    /// <summary>Field number for the "goods_list" field.</summary>
    public const int GoodsListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ShopGoods> _repeated_goodsList_codec
        = pb::FieldCodec.ForMessage(122, global::Weedwacker.Shared.Network.Proto.ShopGoods.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopGoods> goodsList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopGoods>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ShopGoods> GoodsList {
      get { return goodsList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "buy_goods_list" field.</summary>
    public const int BuyGoodsListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.BuyGoodsParam> _repeated_buyGoodsList_codec
        = pb::FieldCodec.ForMessage(66, global::Weedwacker.Shared.Network.Proto.BuyGoodsParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.BuyGoodsParam> buyGoodsList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.BuyGoodsParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.BuyGoodsParam> BuyGoodsList {
      get { return buyGoodsList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BatchBuyGoodsRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BatchBuyGoodsRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ShopType != other.ShopType) return false;
      if(!goodsList_.Equals(other.goodsList_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!buyGoodsList_.Equals(other.buyGoodsList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ShopType != 0) hash ^= ShopType.GetHashCode();
      hash ^= goodsList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= buyGoodsList_.GetHashCode();
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
      if (ShopType != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ShopType);
      }
      buyGoodsList_.WriteTo(output, _repeated_buyGoodsList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Retcode);
      }
      goodsList_.WriteTo(output, _repeated_goodsList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ShopType != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ShopType);
      }
      buyGoodsList_.WriteTo(ref output, _repeated_buyGoodsList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(Retcode);
      }
      goodsList_.WriteTo(ref output, _repeated_goodsList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ShopType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShopType);
      }
      size += goodsList_.CalculateSize(_repeated_goodsList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += buyGoodsList_.CalculateSize(_repeated_buyGoodsList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BatchBuyGoodsRsp other) {
      if (other == null) {
        return;
      }
      if (other.ShopType != 0) {
        ShopType = other.ShopType;
      }
      goodsList_.Add(other.goodsList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      buyGoodsList_.Add(other.buyGoodsList_);
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
            ShopType = input.ReadUInt32();
            break;
          }
          case 66: {
            buyGoodsList_.AddEntriesFrom(input, _repeated_buyGoodsList_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadInt32();
            break;
          }
          case 122: {
            goodsList_.AddEntriesFrom(input, _repeated_goodsList_codec);
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
            ShopType = input.ReadUInt32();
            break;
          }
          case 66: {
            buyGoodsList_.AddEntriesFrom(ref input, _repeated_buyGoodsList_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadInt32();
            break;
          }
          case 122: {
            goodsList_.AddEntriesFrom(ref input, _repeated_goodsList_codec);
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
