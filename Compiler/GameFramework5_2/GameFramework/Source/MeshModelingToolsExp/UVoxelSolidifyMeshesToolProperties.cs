#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties of the solidify operation</summary>
[CppInclude("VoxelSolidifyMeshesTool.h")]
public partial class UVoxelSolidifyMeshesToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Winding number threshold to determine what is consider inside the mesh</summary>
	public double WindingThreshold;
	///<summary>How far we allow bounds of solid surface to go beyond the bounds of the original input surface before clamping / cutting the surface off</summary>
	public double ExtendBounds;
	///<summary>How many binary search steps to take when placing vertices on the surface</summary>
	public int SurfaceSearchSteps;
	///<summary>Whether to fill at the border of the bounding box, if the surface extends beyond the voxel boundaries</summary>
	public bool bSolidAtBoundaries;
	///<summary>If true, uses the ThickenShells setting</summary>
	public bool bApplyThickenShells;
	///<summary>Thicken open-boundary surfaces (extrude them inwards) to ensure they are captured in the VoxWrap output. Units are in world space.</summary>
	public double ThickenShells;
}
