// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IslandPartySailStage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from IslandPartySailStage.proto</summary>
  public static partial class IslandPartySailStageReflection {

    #region Descriptor
    /// <summary>File descriptor for IslandPartySailStage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IslandPartySailStageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpJc2xhbmRQYXJ0eVNhaWxTdGFnZS5wcm90bxIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90byp+ChRJc2xhbmRQYXJ0eVNhaWxTdGFnZRIgChxJ",
            "U0xBTkRfUEFSVFlfU0FJTF9TVEFHRV9OT05FEAASIAocSVNMQU5EX1BBUlRZ",
            "X1NBSUxfU1RBR0VfU0FJTBABEiIKHklTTEFORF9QQVJUWV9TQUlMX1NUQUdF",
            "X0JBVFRMRRACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.IslandPartySailStage), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum IslandPartySailStage {
    [pbr::OriginalName("ISLAND_PARTY_SAIL_STAGE_NONE")] None = 0,
    [pbr::OriginalName("ISLAND_PARTY_SAIL_STAGE_SAIL")] Sail = 1,
    [pbr::OriginalName("ISLAND_PARTY_SAIL_STAGE_BATTLE")] Battle = 2,
  }

  #endregion

}

#endregion Designer generated code
