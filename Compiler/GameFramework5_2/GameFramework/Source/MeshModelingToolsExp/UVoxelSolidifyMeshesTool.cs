#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tool to take one or more meshes, possibly intersecting and possibly with holes, and create a single solid mesh with consistent inside/outside</summary>
[CppInclude("VoxelSolidifyMeshesTool.h")]
public partial class UVoxelSolidifyMeshesTool : UBaseVoxelTool {
	///<summary>SolidifyProperties</summary>
	public UVoxelSolidifyMeshesToolProperties SolidifyProperties;
}
