// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGReason.proto</summary>
  public static partial class GCGReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9HQ0dSZWFzb24ucHJvdG8SH1dlZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsu",
            "UHJvdG8q2AIKCUdDR1JlYXNvbhIWChJHQ0dfUkVBU09OX0RFRkFVTFQQABIV",
            "ChFHQ0dfUkVBU09OX0VGRkVDVBABEhMKD0dDR19SRUFTT05fQ09TVBACEhEK",
            "DUdDR19SRUFTT05fR00QAxIVChFHQ0dfUkVBU09OX0FUVEFDSxAEEhUKEUdD",
            "R19SRUFTT05fUkVCT09UEAUSGAoUR0NHX1JFQVNPTl9QTEFZX0NBUkQQBhIe",
            "ChpHQ0dfUkVBU09OX1FVSUNLTFlfT05TVEFHRRAHEh8KG0dDR19SRUFTT05f",
            "UkVNT1ZFX0FGVEVSX0RJRRAIEhMKD0dDR19SRUFTT05fSU5JVBAJEhwKGEdD",
            "R19SRUFTT05fRUZGRUNUX0RBTUFHRRAKEhoKFkdDR19SRUFTT05fRUZGRUNU",
            "X0hFQUwQCxIcChhHQ0dfUkVBU09OX0VGRkVDVF9SRVZJVkUQDGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.GCGReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GCGReason {
    [pbr::OriginalName("GCG_REASON_DEFAULT")] Default = 0,
    [pbr::OriginalName("GCG_REASON_EFFECT")] Effect = 1,
    [pbr::OriginalName("GCG_REASON_COST")] Cost = 2,
    [pbr::OriginalName("GCG_REASON_GM")] Gm = 3,
    [pbr::OriginalName("GCG_REASON_ATTACK")] Attack = 4,
    [pbr::OriginalName("GCG_REASON_REBOOT")] Reboot = 5,
    [pbr::OriginalName("GCG_REASON_PLAY_CARD")] PlayCard = 6,
    [pbr::OriginalName("GCG_REASON_QUICKLY_ONSTAGE")] QuicklyOnstage = 7,
    [pbr::OriginalName("GCG_REASON_REMOVE_AFTER_DIE")] RemoveAfterDie = 8,
    [pbr::OriginalName("GCG_REASON_INIT")] Init = 9,
    [pbr::OriginalName("GCG_REASON_EFFECT_DAMAGE")] EffectDamage = 10,
    [pbr::OriginalName("GCG_REASON_EFFECT_HEAL")] EffectHeal = 11,
    [pbr::OriginalName("GCG_REASON_EFFECT_REVIVE")] EffectRevive = 12,
  }

  #endregion

}

#endregion Designer generated code
