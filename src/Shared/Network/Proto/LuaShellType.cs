// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LuaShellType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from LuaShellType.proto</summary>
  public static partial class LuaShellTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for LuaShellType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LuaShellTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJMdWFTaGVsbFR5cGUucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdv",
            "cmsuUHJvdG8qogEKDEx1YVNoZWxsVHlwZRIgChxMVUFfU0hFTExfVFlQRV9M",
            "VUFTSEVMTF9OT05FEAASIgoeTFVBX1NIRUxMX1RZUEVfTFVBU0hFTExfTk9S",
            "TUFMEAESJAogTFVBX1NIRUxMX1RZUEVfTFVBU0hFTExfU0VDVVJJVFkQAhIm",
            "CiJMVUFfU0hFTExfVFlQRV9MVUFTSEVMTF9TSEVMTF9DT0RFEANiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.LuaShellType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum LuaShellType {
    [pbr::OriginalName("LUA_SHELL_TYPE_LUASHELL_NONE")] LuashellNone = 0,
    [pbr::OriginalName("LUA_SHELL_TYPE_LUASHELL_NORMAL")] LuashellNormal = 1,
    [pbr::OriginalName("LUA_SHELL_TYPE_LUASHELL_SECURITY")] LuashellSecurity = 2,
    [pbr::OriginalName("LUA_SHELL_TYPE_LUASHELL_SHELL_CODE")] LuashellShellCode = 3,
  }

  #endregion

}

#endregion Designer generated code
