// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SealBattleType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SealBattleType.proto</summary>
  public static partial class SealBattleTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for SealBattleType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SealBattleTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRTZWFsQmF0dGxlVHlwZS5wcm90bxIfV2VlZHdhY2tlci5TaGFyZWQuTmV0",
            "d29yay5Qcm90byp4Cg5TZWFsQmF0dGxlVHlwZRIfChtTRUFMX0JBVFRMRV9U",
            "WVBFX0tFRVBfQUxJVkUQABIhCh1TRUFMX0JBVFRMRV9UWVBFX0tJTExfTU9O",
            "U1RFUhABEiIKHlNFQUxfQkFUVExFX1RZUEVfRU5FUkdZX0NIQVJHRRACYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.SealBattleType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum SealBattleType {
    [pbr::OriginalName("SEAL_BATTLE_TYPE_KEEP_ALIVE")] KeepAlive = 0,
    [pbr::OriginalName("SEAL_BATTLE_TYPE_KILL_MONSTER")] KillMonster = 1,
    [pbr::OriginalName("SEAL_BATTLE_TYPE_ENERGY_CHARGE")] EnergyCharge = 2,
  }

  #endregion

}

#endregion Designer generated code
