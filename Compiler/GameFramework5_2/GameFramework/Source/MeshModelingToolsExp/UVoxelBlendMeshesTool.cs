namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tool to smoothly blend meshes together</summary>
[CppInclude("VoxelBlendMeshesTool.h")]
public partial class UVoxelBlendMeshesTool : UBaseVoxelTool {
	public static UClass StaticClass() {return default;}
	///<summary>BlendProperties</summary>
	public UVoxelBlendMeshesToolProperties BlendProperties;
}
