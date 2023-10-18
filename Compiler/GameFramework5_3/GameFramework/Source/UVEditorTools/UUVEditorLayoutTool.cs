namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorLayoutTool.h")]
public partial class UUVEditorLayoutTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>Targets</summary>
	public TArray<UUVEditorToolMeshInput> Targets;
	///<summary>Settings</summary>
	public UUVLayoutProperties Settings;
	///<summary>Factories</summary>
	public TArray<UUVLayoutOperatorFactory> Factories;
	///<summary>UVToolSelectionAPI</summary>
	public UUVToolSelectionAPI UVToolSelectionAPI;
	///<summary>UVTool2DViewportAPI</summary>
	public UUVTool2DViewportAPI UVTool2DViewportAPI;
}
