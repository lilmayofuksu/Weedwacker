// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonBanType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CustomDungeonBanType.proto</summary>
  public static partial class CustomDungeonBanTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for CustomDungeonBanType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomDungeonBanTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpDdXN0b21EdW5nZW9uQmFuVHlwZS5wcm90bxIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90bypcChRDdXN0b21EdW5nZW9uQmFuVHlwZRIgChxD",
            "VVNUT01fRFVOR0VPTl9CQU5fVFlQRV9OT05FEAASIgoeQ1VTVE9NX0RVTkdF",
            "T05fQkFOX1RZUEVfTEFZT1VUEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.CustomDungeonBanType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum CustomDungeonBanType {
    [pbr::OriginalName("CUSTOM_DUNGEON_BAN_TYPE_NONE")] None = 0,
    [pbr::OriginalName("CUSTOM_DUNGEON_BAN_TYPE_LAYOUT")] Layout = 1,
  }

  #endregion

}

#endregion Designer generated code
