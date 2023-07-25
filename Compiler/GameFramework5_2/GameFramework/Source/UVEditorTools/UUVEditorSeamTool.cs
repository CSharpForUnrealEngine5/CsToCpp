#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorSeamTool.h")]
public partial class UUVEditorSeamTool : UInteractiveTool {
// UVEditorSeamTool
	public TArray<UUVEditorToolMeshInput> Targets;
	public UUVEditorSeamToolProperties Settings;
	public UUVToolLivePreviewAPI LivePreviewAPI;
	public UUVToolEmitChangeAPI EmitChangeAPI;
	public UInputBehaviorSet LivePreviewBehaviorSet;
	public ULocalInputBehaviorSource LivePreviewBehaviorSource;
	public UPreviewGeometry UnwrapGeometry;
	public UPreviewGeometry LivePreviewGeometry;
}
