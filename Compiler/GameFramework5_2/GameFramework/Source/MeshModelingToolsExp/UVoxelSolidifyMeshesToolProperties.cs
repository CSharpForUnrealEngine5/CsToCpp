#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VoxelSolidifyMeshesTool.h")]
///<summary>Properties of the solidify operation</summary>
public partial class UVoxelSolidifyMeshesToolProperties : UInteractiveToolPropertySet {
// VoxelSolidifyMeshesToolProperties
	public double WindingThreshold;
	public double ExtendBounds;
	public int SurfaceSearchSteps;
	public bool bSolidAtBoundaries;
	public bool bApplyThickenShells;
	public double ThickenShells;
}
