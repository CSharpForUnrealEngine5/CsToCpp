#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UUVEditorRecomputeUVsTool Recomputes UVs based on existing segmentations of the mesh</summary>
[CppInclude("UVEditorRecomputeUVsTool.h")]
public partial class UUVEditorRecomputeUVsTool : UInteractiveTool {
	///<summary>Targets</summary>
	public TArray<UUVEditorToolMeshInput> Targets;
	///<summary>Settings</summary>
	public URecomputeUVsToolProperties Settings;
	///<summary>PolygroupLayerProperties</summary>
	public UPolygroupLayersProperties PolygroupLayerProperties;
	///<summary>Factories</summary>
	public TArray<URecomputeUVsOpFactory> Factories;
	///<summary>UVToolSelectionAPI</summary>
	public UUVToolSelectionAPI UVToolSelectionAPI;
}
