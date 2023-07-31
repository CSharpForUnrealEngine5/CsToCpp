#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertySets/VoxelProperties.h")]
public partial class UVoxelProperties : UInteractiveToolPropertySet {
	///<summary>The size of the geometry bounding box major axis measured in voxels</summary>
	public int VoxelCount;
	///<summary>Automatically simplify the result of voxel-based meshes.</summary>
	public bool bAutoSimplify;
	///<summary>Remove internal, occluded geometry</summary>
	public bool bRemoveInternalSurfaces;
	///<summary>The max error (as a multiple of the voxel size) to accept when simplifying the output</summary>
	public double SimplifyMaxErrorFactor;
	///<summary>Automatically remove components smaller than this (to clean up any isolated floating bits)</summary>
	public double CubeRootMinComponentVolume;
}
