namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UUVEditorRecomputeUVsTool Recomputes UVs based on existing segmentations of the mesh</summary>
[CppInclude("UVEditorRecomputeUVsTool.h")]
public partial class UUVEditorRecomputeUVsTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
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
