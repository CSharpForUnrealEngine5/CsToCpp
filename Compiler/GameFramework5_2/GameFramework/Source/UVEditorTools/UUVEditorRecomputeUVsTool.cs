#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorRecomputeUVsTool.h")]
///<summary>UUVEditorRecomputeUVsTool Recomputes UVs based on existing segmentations of the mesh</summary>
public partial class UUVEditorRecomputeUVsTool : UInteractiveTool {
// UVEditorRecomputeUVsTool
	public TArray<UUVEditorToolMeshInput> Targets;
	public URecomputeUVsToolProperties Settings;
	public UPolygroupLayersProperties PolygroupLayerProperties;
	public TArray<URecomputeUVsOpFactory> Factories;
	public UUVToolSelectionAPI UVToolSelectionAPI;
}
