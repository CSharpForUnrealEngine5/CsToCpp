namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the Merge Meshes operation</summary>
[CppInclude("MergeMeshesTool.h")]
public partial class UMergeMeshesToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>The size of the geometry bounding box major axis measured in voxels.</summary>
	public int VoxelCount;
	///<summary>Remeshing adaptivity, prior to optional simplification</summary>
	public float MeshAdaptivity;
	///<summary>Offset when remeshing, note large offsets with high voxels counts will be slow.  Hidden because this duplicates functionality of the voxel offset tool</summary>
	public float OffsetDistance;
	///<summary>Automatically simplify the result of voxel-based merge.</summary>
	public bool bAutoSimplify;
}
