namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorTransformTool.h")]
public partial class UUVEditorTransformTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>Targets</summary>
	public TArray<UUVEditorToolMeshInput> Targets;
	///<summary>Settings</summary>
	public UUVEditorUVTransformPropertiesBase Settings;
	///<summary>DisplaySettings</summary>
	public UUVEditorTransformToolDisplayProperties DisplaySettings;
	///<summary>Factories</summary>
	public TArray<UUVEditorUVTransformOperatorFactory> Factories;
	///<summary>UVToolSelectionAPI</summary>
	public UUVToolSelectionAPI UVToolSelectionAPI;
}
