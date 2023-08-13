namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/FbxStaticMeshImportData.h")]
public partial class UFbxStaticMeshImportData : UFbxMeshImportData {
	public static UClass StaticClass() {return default;}
	///<summary>The LODGroup to associate with this mesh when it is imported</summary>
	public string StaticMeshLODGroup;
	///<summary>Specify how vertex colors should be imported</summary>
	public EVertexColorImportOption VertexColorImportOption;
	///<summary>Specify override color in the case that VertexColorImportOption is set to Override</summary>
	public FColor VertexOverrideColor;
	///<summary>Disabling this option will keep degenerate triangles found.  In general you should leave this option on.</summary>
	public bool bRemoveDegenerates;
	///<summary>bBuildReversedIndexBuffer</summary>
	public bool bBuildReversedIndexBuffer;
	///<summary>If enabled, allows to render objects with Nanite</summary>
	public bool bBuildNanite;
	///<summary>bGenerateLightmapUVs</summary>
	public bool bGenerateLightmapUVs;
	///<summary>If checked, one convex hull per UCX_ prefixed collision mesh will be generated instead of decomposing into multiple hulls</summary>
	public bool bOneConvexHullPerUCX;
	///<summary>If checked, collision will automatically be generated (ignored if custom collision is imported or used).</summary>
	public bool bAutoGenerateCollision;
	///<summary>If enabled, combines all meshes into a single mesh</summary>
	public bool bCombineMeshes;
	///<summary>Specify override color in the case that VertexColorImportOption is set to Override</summary>
	public float DistanceFieldResolutionScale;
}
