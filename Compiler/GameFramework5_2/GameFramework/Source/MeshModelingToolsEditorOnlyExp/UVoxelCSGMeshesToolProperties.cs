#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VoxelCSGMeshesTool.h")]
///<summary>Standard properties of the Voxel CSG operation</summary>
public partial class UVoxelCSGMeshesToolProperties : UInteractiveToolPropertySet {
// VoxelCSGMeshesToolProperties
	public EVoxelCSGOperation Operation;
	public int VoxelCount;
	public float MeshAdaptivity;
	public float OffsetDistance;
	public bool bAutoSimplify;
}
