namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorLayerEditTool.h")]
public partial class UUVEditorChannelEditTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
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
