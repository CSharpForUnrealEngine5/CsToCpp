#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorLayerEditTool.h")]
public partial class UUVEditorChannelEditTool : UInteractiveTool {
	///<summary>Targets</summary>
	public TArray<UUVEditorToolMeshInput> Targets;
	///<summary>ToolActions</summary>
	public UUVEditorChannelEditToolActionPropertySet ToolActions;
	///<summary>ActionSelectionProperties</summary>
	public UUVEditorChannelEditSettings ActionSelectionProperties;
	///<summary>SourceChannelProperties</summary>
	public UUVEditorChannelEditTargetProperties SourceChannelProperties;
	///<summary>AddActionProperties</summary>
	public UUVEditorChannelEditAddProperties AddActionProperties;
	///<summary>CopyActionProperties</summary>
	public UUVEditorChannelEditCopyProperties CopyActionProperties;
	///<summary>DeleteActionProperties</summary>
	public UUVEditorChannelEditDeleteProperties DeleteActionProperties;
	///<summary>EmitChangeAPI</summary>
	public UUVToolEmitChangeAPI EmitChangeAPI;
}
