// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeLimitedShopGoods.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from HomeLimitedShopGoods.proto</summary>
  public static partial class HomeLimitedShopGoodsReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeLimitedShopGoods.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeLimitedShopGoodsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpIb21lTGltaXRlZFNob3BHb29kcy5wcm90bxIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90bxoPSXRlbVBhcmFtLnByb3RvIoUCChRIb21lTGlt",
            "aXRlZFNob3BHb29kcxIbChNVbmszMzAwX0VIS0ZJQ0JBQ0tDGAggASgNEhsK",
            "E1VuazMzMDBfT09EQ0NPQUlHSEkYCiABKA0SGwoTVW5rMzMwMF9EQkpDTU1C",
            "SEJOSRgMIAEoDRISCgpib3VnaHRfbnVtGAUgASgNEj4KCmdvb2RzX2l0ZW0Y",
            "AiABKAsyKi5XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvLkl0ZW1Q",
            "YXJhbRJCCg5jb3N0X2l0ZW1fbGlzdBgEIAMoCzIqLldlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG8uSXRlbVBhcmFtYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.HomeLimitedShopGoods), global::Weedwacker.Shared.Network.Proto.HomeLimitedShopGoods.Parser, new[]{ "Unk3300EHKFICBACKC", "Unk3300OODCCOAIGHI", "Unk3300DBJCMMBHBNI", "BoughtNum", "GoodsItem", "CostItemList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeLimitedShopGoods : pb::IMessage<HomeLimitedShopGoods>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeLimitedShopGoods> _parser = new pb::MessageParser<HomeLimitedShopGoods>(() => new HomeLimitedShopGoods());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeLimitedShopGoods> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.HomeLimitedShopGoodsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopGoods() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopGoods(HomeLimitedShopGoods other) : this() {
      unk3300EHKFICBACKC_ = other.unk3300EHKFICBACKC_;
      unk3300OODCCOAIGHI_ = other.unk3300OODCCOAIGHI_;
      unk3300DBJCMMBHBNI_ = other.unk3300DBJCMMBHBNI_;
      boughtNum_ = other.boughtNum_;
      goodsItem_ = other.goodsItem_ != null ? other.goodsItem_.Clone() : null;
      costItemList_ = other.costItemList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopGoods Clone() {
      return new HomeLimitedShopGoods(this);
    }

    /// <summary>Field number for the "Unk3300_EHKFICBACKC" field.</summary>
    public const int Unk3300EHKFICBACKCFieldNumber = 8;
    private uint unk3300EHKFICBACKC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300EHKFICBACKC {
      get { return unk3300EHKFICBACKC_; }
      set {
        unk3300EHKFICBACKC_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_OODCCOAIGHI" field.</summary>
    public const int Unk3300OODCCOAIGHIFieldNumber = 10;
    private uint unk3300OODCCOAIGHI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300OODCCOAIGHI {
      get { return unk3300OODCCOAIGHI_; }
      set {
        unk3300OODCCOAIGHI_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_DBJCMMBHBNI" field.</summary>
    public const int Unk3300DBJCMMBHBNIFieldNumber = 12;
    private uint unk3300DBJCMMBHBNI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300DBJCMMBHBNI {
      get { return unk3300DBJCMMBHBNI_; }
      set {
        unk3300DBJCMMBHBNI_ = value;
      }
    }

    /// <summary>Field number for the "bought_num" field.</summary>
    public const int BoughtNumFieldNumber = 5;
    private uint boughtNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BoughtNum {
      get { return boughtNum_; }
      set {
        boughtNum_ = value;
      }
    }

    /// <summary>Field number for the "goods_item" field.</summary>
    public const int GoodsItemFieldNumber = 2;
    private global::Weedwacker.Shared.Network.Proto.ItemParam goodsItem_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ItemParam GoodsItem {
      get { return goodsItem_; }
      set {
        goodsItem_ = value;
      }
    }

    /// <summary>Field number for the "cost_item_list" field.</summary>
    public const int CostItemListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.ItemParam> _repeated_costItemList_codec
        = pb::FieldCodec.ForMessage(34, global::Weedwacker.Shared.Network.Proto.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> costItemList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.ItemParam> CostItemList {
      get { return costItemList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeLimitedShopGoods);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeLimitedShopGoods other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300EHKFICBACKC != other.Unk3300EHKFICBACKC) return false;
      if (Unk3300OODCCOAIGHI != other.Unk3300OODCCOAIGHI) return false;
      if (Unk3300DBJCMMBHBNI != other.Unk3300DBJCMMBHBNI) return false;
      if (BoughtNum != other.BoughtNum) return false;
      if (!object.Equals(GoodsItem, other.GoodsItem)) return false;
      if(!costItemList_.Equals(other.costItemList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300EHKFICBACKC != 0) hash ^= Unk3300EHKFICBACKC.GetHashCode();
      if (Unk3300OODCCOAIGHI != 0) hash ^= Unk3300OODCCOAIGHI.GetHashCode();
      if (Unk3300DBJCMMBHBNI != 0) hash ^= Unk3300DBJCMMBHBNI.GetHashCode();
      if (BoughtNum != 0) hash ^= BoughtNum.GetHashCode();
      if (goodsItem_ != null) hash ^= GoodsItem.GetHashCode();
      hash ^= costItemList_.GetHashCode();
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
      if (goodsItem_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GoodsItem);
      }
      costItemList_.WriteTo(output, _repeated_costItemList_codec);
      if (BoughtNum != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BoughtNum);
      }
      if (Unk3300EHKFICBACKC != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3300EHKFICBACKC);
      }
      if (Unk3300OODCCOAIGHI != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300OODCCOAIGHI);
      }
      if (Unk3300DBJCMMBHBNI != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk3300DBJCMMBHBNI);
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
      if (goodsItem_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GoodsItem);
      }
      costItemList_.WriteTo(ref output, _repeated_costItemList_codec);
      if (BoughtNum != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BoughtNum);
      }
      if (Unk3300EHKFICBACKC != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3300EHKFICBACKC);
      }
      if (Unk3300OODCCOAIGHI != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300OODCCOAIGHI);
      }
      if (Unk3300DBJCMMBHBNI != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk3300DBJCMMBHBNI);
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
      if (Unk3300EHKFICBACKC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300EHKFICBACKC);
      }
      if (Unk3300OODCCOAIGHI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300OODCCOAIGHI);
      }
      if (Unk3300DBJCMMBHBNI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300DBJCMMBHBNI);
      }
      if (BoughtNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BoughtNum);
      }
      if (goodsItem_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GoodsItem);
      }
      size += costItemList_.CalculateSize(_repeated_costItemList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeLimitedShopGoods other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300EHKFICBACKC != 0) {
        Unk3300EHKFICBACKC = other.Unk3300EHKFICBACKC;
      }
      if (other.Unk3300OODCCOAIGHI != 0) {
        Unk3300OODCCOAIGHI = other.Unk3300OODCCOAIGHI;
      }
      if (other.Unk3300DBJCMMBHBNI != 0) {
        Unk3300DBJCMMBHBNI = other.Unk3300DBJCMMBHBNI;
      }
      if (other.BoughtNum != 0) {
        BoughtNum = other.BoughtNum;
      }
      if (other.goodsItem_ != null) {
        if (goodsItem_ == null) {
          GoodsItem = new global::Weedwacker.Shared.Network.Proto.ItemParam();
        }
        GoodsItem.MergeFrom(other.GoodsItem);
      }
      costItemList_.Add(other.costItemList_);
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
          case 18: {
            if (goodsItem_ == null) {
              GoodsItem = new global::Weedwacker.Shared.Network.Proto.ItemParam();
            }
            input.ReadMessage(GoodsItem);
            break;
          }
          case 34: {
            costItemList_.AddEntriesFrom(input, _repeated_costItemList_codec);
            break;
          }
          case 40: {
            BoughtNum = input.ReadUInt32();
            break;
          }
          case 64: {
            Unk3300EHKFICBACKC = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300OODCCOAIGHI = input.ReadUInt32();
            break;
          }
          case 96: {
            Unk3300DBJCMMBHBNI = input.ReadUInt32();
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
          case 18: {
            if (goodsItem_ == null) {
              GoodsItem = new global::Weedwacker.Shared.Network.Proto.ItemParam();
            }
            input.ReadMessage(GoodsItem);
            break;
          }
          case 34: {
            costItemList_.AddEntriesFrom(ref input, _repeated_costItemList_codec);
            break;
          }
          case 40: {
            BoughtNum = input.ReadUInt32();
            break;
          }
          case 64: {
            Unk3300EHKFICBACKC = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300OODCCOAIGHI = input.ReadUInt32();
            break;
          }
          case 96: {
            Unk3300DBJCMMBHBNI = input.ReadUInt32();
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
