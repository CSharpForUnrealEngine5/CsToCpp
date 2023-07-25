#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorParameterizeMeshTool.h")]
///<summary>UParameterizeMeshTool automatically decomposes the input mesh into charts, solves for UVs,</summary>
public partial class UUVEditorParameterizeMeshTool : UInteractiveTool {
// UVEditorParameterizeMeshTool
	public TArray<UUVEditorToolMeshInput> Targets;
	public UParameterizeMeshToolProperties Settings;
	public UParameterizeMeshToolUVAtlasProperties UVAtlasProperties;
	public UParameterizeMeshToolXAtlasProperties XAtlasProperties;
	public UParameterizeMeshToolPatchBuilderProperties PatchBuilderProperties;
	public UPolygroupLayersProperties PolygroupLayerProperties;
	public TArray<UParameterizeMeshOperatorFactory> Factories;
}
