#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the Merge Meshes operation</summary>
[CppInclude("MergeMeshesTool.h")]
public partial class UMergeMeshesToolProperties : UInteractiveToolPropertySet {
	///<summary>The size of the geometry bounding box major axis measured in voxels.</summary>
	public int VoxelCount;
	///<summary>Remeshing adaptivity, prior to optional simplification</summary>
	public float MeshAdaptivity;
	///<summary>Offset when remeshing, note large offsets with high voxels counts will be slow</summary>
	public float OffsetDistance;
	///<summary>Automatically simplify the result of voxel-based merge.</summary>
	public bool bAutoSimplify;
}
