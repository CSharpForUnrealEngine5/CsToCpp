#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters for 3D grids, eg grids used for sampling, SDFs, voxelization, etc</summary>
[CppInclude("GeometryScript/MeshVoxelFunctions.h")]
public partial struct FGeometryScript3DGridParameters {
	public EGeometryScriptGridSizingMethod SizeMethod;
	public float GridCellSize;
	public int GridResolution;
}
