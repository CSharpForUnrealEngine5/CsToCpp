#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorTransformTool.h")]
public partial class UUVEditorTransformTool : UInteractiveTool {
// UVEditorTransformTool
	public TArray<UUVEditorToolMeshInput> Targets;
	public UUVEditorUVTransformPropertiesBase Settings;
	public UUVEditorTransformToolDisplayProperties DisplaySettings;
	public TArray<UUVEditorUVTransformOperatorFactory> Factories;
	public UUVToolSelectionAPI UVToolSelectionAPI;
}
