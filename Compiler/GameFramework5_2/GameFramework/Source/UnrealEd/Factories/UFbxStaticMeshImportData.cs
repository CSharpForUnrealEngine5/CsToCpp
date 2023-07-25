#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxStaticMeshImportData.h")]
public partial class UFbxStaticMeshImportData : UFbxMeshImportData {
// FbxStaticMeshImportData
	public string StaticMeshLODGroup;
	public byte VertexColorImportOption;
	public FColor VertexOverrideColor;
	public bool bRemoveDegenerates;
	public bool bBuildReversedIndexBuffer;
	public bool bBuildNanite;
	public bool bGenerateLightmapUVs;
	public bool bOneConvexHullPerUCX;
	public bool bAutoGenerateCollision;
	public bool bCombineMeshes;
	public float DistanceFieldResolutionScale;
}
