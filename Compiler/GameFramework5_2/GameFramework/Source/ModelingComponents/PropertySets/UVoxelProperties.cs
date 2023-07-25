#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertySets/VoxelProperties.h")]
public partial class UVoxelProperties : UInteractiveToolPropertySet {
// VoxelProperties
	public int VoxelCount;
	public bool bAutoSimplify;
	public bool bRemoveInternalSurfaces;
	public double SimplifyMaxErrorFactor;
	public double CubeRootMinComponentVolume;
}
