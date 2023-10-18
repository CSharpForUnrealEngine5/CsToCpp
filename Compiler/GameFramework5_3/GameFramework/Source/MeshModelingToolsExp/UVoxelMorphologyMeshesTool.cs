namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Morphology tool -- dilate, contract, close, open operations on the input shape</summary>
[CppInclude("VoxelMorphologyMeshesTool.h")]
public partial class UVoxelMorphologyMeshesTool : UBaseVoxelTool {
	public static UClass StaticClass() {return default;}
	///<summary>MorphologyProperties</summary>
	public UVoxelMorphologyMeshesToolProperties MorphologyProperties;
}
