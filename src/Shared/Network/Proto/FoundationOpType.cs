// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FoundationOpType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FoundationOpType.proto</summary>
  public static partial class FoundationOpTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for FoundationOpType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FoundationOpTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZGb3VuZGF0aW9uT3BUeXBlLnByb3RvEh9XZWVkd2Fja2VyLlNoYXJlZC5O",
            "ZXR3b3JrLlByb3RvKusBChBGb3VuZGF0aW9uT3BUeXBlEhsKF0ZPVU5EQVRJ",
            "T05fT1BfVFlQRV9OT05FEAASHAoYRk9VTkRBVElPTl9PUF9UWVBFX0JVSUxE",
            "EAESIQodRk9VTkRBVElPTl9PUF9UWVBFX0RFTU9MSVRJT04QAhIeChpGT1VO",
            "REFUSU9OX09QX1RZUEVfUkVCVUlMRBADEh0KGUZPVU5EQVRJT05fT1BfVFlQ",
            "RV9ST1RBVEUQBBIbChdGT1VOREFUSU9OX09QX1RZUEVfTE9DSxAFEh0KGUZP",
            "VU5EQVRJT05fT1BfVFlQRV9VTkxPQ0sQBmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.FoundationOpType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum FoundationOpType {
    [pbr::OriginalName("FOUNDATION_OP_TYPE_NONE")] None = 0,
    [pbr::OriginalName("FOUNDATION_OP_TYPE_BUILD")] Build = 1,
    [pbr::OriginalName("FOUNDATION_OP_TYPE_DEMOLITION")] Demolition = 2,
    [pbr::OriginalName("FOUNDATION_OP_TYPE_REBUILD")] Rebuild = 3,
    [pbr::OriginalName("FOUNDATION_OP_TYPE_ROTATE")] Rotate = 4,
    [pbr::OriginalName("FOUNDATION_OP_TYPE_LOCK")] Lock = 5,
    [pbr::OriginalName("FOUNDATION_OP_TYPE_UNLOCK")] Unlock = 6,
  }

  #endregion

}

#endregion Designer generated code
