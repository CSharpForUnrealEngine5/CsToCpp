#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexPaintingTool.h")]
public partial class UMeshWeightPaintingToolProperties : UMeshVertexPaintingToolProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Texture Blend Weight Painting Mode</summary>
	public EMeshPaintWeightTypes TextureWeightType;
	///<summary>Texture Blend Weight index which should be applied during Painting</summary>
	public EMeshPaintTextureIndex PaintTextureWeightIndex;
	///<summary>Texture Blend Weight index which should be erased during Painting</summary>
	public EMeshPaintTextureIndex EraseTextureWeightIndex;
}
