#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshVoxelFunctions.h")]
///<summary>Parameters for 3D grids, eg grids used for sampling, SDFs, voxelization, etc</summary>
public partial struct FGeometryScript3DGridParameters {
// GeometryScript3DGridParameters
	public EGeometryScriptGridSizingMethod SizeMethod;
	public float GridCellSize;
	public int GridResolution;
}
