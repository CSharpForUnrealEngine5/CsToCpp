#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base for Voxel tools</summary>
[CppInclude("BaseTools/BaseVoxelTool.h")]
public partial class UBaseVoxelTool : UBaseCreateFromSelectedTool {
	public static UClass StaticClass() {return default;}
	///<summary>VoxProperties</summary>
	public UVoxelProperties VoxProperties;
}
