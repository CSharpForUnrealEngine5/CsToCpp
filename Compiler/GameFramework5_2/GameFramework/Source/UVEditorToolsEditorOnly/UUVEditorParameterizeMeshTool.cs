#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UParameterizeMeshTool automatically decomposes the input mesh into charts, solves for UVs,</summary>
[CppInclude("UVEditorParameterizeMeshTool.h")]
public partial class UUVEditorParameterizeMeshTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>Targets</summary>
	public TArray<UUVEditorToolMeshInput> Targets;
	///<summary>Settings</summary>
	public UParameterizeMeshToolProperties Settings;
	///<summary>UVAtlasProperties</summary>
	public UParameterizeMeshToolUVAtlasProperties UVAtlasProperties;
	///<summary>XAtlasProperties</summary>
	public UParameterizeMeshToolXAtlasProperties XAtlasProperties;
	///<summary>PatchBuilderProperties</summary>
	public UParameterizeMeshToolPatchBuilderProperties PatchBuilderProperties;
	///<summary>PolygroupLayerProperties</summary>
	public UPolygroupLayersProperties PolygroupLayerProperties;
	///<summary>Factories</summary>
	public TArray<UParameterizeMeshOperatorFactory> Factories;
}
