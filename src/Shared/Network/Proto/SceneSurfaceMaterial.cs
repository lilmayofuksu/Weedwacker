// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneSurfaceMaterial.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from SceneSurfaceMaterial.proto</summary>
  public static partial class SceneSurfaceMaterialReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneSurfaceMaterial.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneSurfaceMaterialReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpTY2VuZVN1cmZhY2VNYXRlcmlhbC5wcm90bxIfV2VlZHdhY2tlci5TaGFy",
            "ZWQuTmV0d29yay5Qcm90byqjAgoUU2NlbmVTdXJmYWNlTWF0ZXJpYWwSIgoe",
            "U0NFTkVfU1VSRkFDRV9NQVRFUklBTF9JTlZBTElEEAASIAocU0NFTkVfU1VS",
            "RkFDRV9NQVRFUklBTF9HUkFTUxABEh8KG1NDRU5FX1NVUkZBQ0VfTUFURVJJ",
            "QUxfRElSVBACEh8KG1NDRU5FX1NVUkZBQ0VfTUFURVJJQUxfUk9DSxADEh8K",
            "G1NDRU5FX1NVUkZBQ0VfTUFURVJJQUxfU05PVxAEEiAKHFNDRU5FX1NVUkZB",
            "Q0VfTUFURVJJQUxfV0FURVIQBRIfChtTQ0VORV9TVVJGQUNFX01BVEVSSUFM",
            "X1RJTEUQBhIfChtTQ0VORV9TVVJGQUNFX01BVEVSSUFMX1NBTkQQB2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Weedwacker.Shared.Network.Proto.SceneSurfaceMaterial), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum SceneSurfaceMaterial {
    [pbr::OriginalName("SCENE_SURFACE_MATERIAL_INVALID")] Invalid = 0,
    [pbr::OriginalName("SCENE_SURFACE_MATERIAL_GRASS")] Grass = 1,
    [pbr::OriginalName("SCENE_SURFACE_MATERIAL_DIRT")] Dirt = 2,
    [pbr::OriginalName("SCENE_SURFACE_MATERIAL_ROCK")] Rock = 3,
    [pbr::OriginalName("SCENE_SURFACE_MATERIAL_SNOW")] Snow = 4,
    [pbr::OriginalName("SCENE_SURFACE_MATERIAL_WATER")] Water = 5,
    [pbr::OriginalName("SCENE_SURFACE_MATERIAL_TILE")] Tile = 6,
    [pbr::OriginalName("SCENE_SURFACE_MATERIAL_SAND")] Sand = 7,
  }

  #endregion

}

#endregion Designer generated code
