#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorLayerEditTool.h")]
public partial class UUVEditorChannelEditTool : UInteractiveTool {
// UVEditorChannelEditTool
	public TArray<UUVEditorToolMeshInput> Targets;
	public UUVEditorChannelEditToolActionPropertySet ToolActions;
	public UUVEditorChannelEditSettings ActionSelectionProperties;
	public UUVEditorChannelEditTargetProperties SourceChannelProperties;
	public UUVEditorChannelEditAddProperties AddActionProperties;
	public UUVEditorChannelEditCopyProperties CopyActionProperties;
	public UUVEditorChannelEditDeleteProperties DeleteActionProperties;
	public UUVToolEmitChangeAPI EmitChangeAPI;
}
