#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorSeamTool.h")]
public partial class UUVEditorSeamTool : UInteractiveTool {
	///<summary>Targets</summary>
	public TArray<UUVEditorToolMeshInput> Targets;
	///<summary>Settings</summary>
	public UUVEditorSeamToolProperties Settings;
	///<summary>LivePreviewAPI</summary>
	public UUVToolLivePreviewAPI LivePreviewAPI;
	///<summary>EmitChangeAPI</summary>
	public UUVToolEmitChangeAPI EmitChangeAPI;
	///<summary>LivePreviewBehaviorSet</summary>
	public UInputBehaviorSet LivePreviewBehaviorSet;
	///<summary>LivePreviewBehaviorSource</summary>
	public ULocalInputBehaviorSource LivePreviewBehaviorSource;
	///<summary>UnwrapGeometry</summary>
	public UPreviewGeometry UnwrapGeometry;
	///<summary>LivePreviewGeometry</summary>
	public UPreviewGeometry LivePreviewGeometry;
}
