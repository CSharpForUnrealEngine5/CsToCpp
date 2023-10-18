namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tool to take one or more meshes, possibly intersecting and possibly with holes, and create a single solid mesh with consistent inside/outside</summary>
[CppInclude("VoxelSolidifyMeshesTool.h")]
public partial class UVoxelSolidifyMeshesTool : UBaseVoxelTool {
	public static UClass StaticClass() {return default;}
	///<summary>SolidifyProperties</summary>
	public UVoxelSolidifyMeshesToolProperties SolidifyProperties;
}
