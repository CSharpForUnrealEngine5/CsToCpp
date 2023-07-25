#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ScriptableInteractiveTool.h")]
///<summary>UScriptableInteractiveTool is an extension of UInteractiveTool that allows the Tool functionality to be</summary>
public partial class UScriptableInteractiveTool : UInteractiveTool {
// ScriptableInteractiveTool
	public string ToolName;
	public string ToolLongName;
	public string ToolCategory;
	public string ToolTooltip;
	public bool bShowToolInEditor;
	public EScriptableToolShutdownType ToolShutdownType;
	public void OnScriptSetup() {}
	public void OnScriptTick(float DeltaTime) {}
	public bool OnScriptCanAccept() { return default; }
	public void OnScriptShutdown(EToolShutdownType ShutdownType) {}
	public void RequestToolShutdown(bool bAccept,bool bShowUserPopupMessage,string UserMessage) {}
	public TWeakObjectPtr<UWorld> TargetWorld;
	public UObject GetToolWorld() { return default; }
	public void OnScriptRender(UObject RenderAPI) {}
	public void OnScriptDrawHUD(UObject DrawHUDAPI) {}
	public UScriptableTool_RenderAPI RenderHelper;
	public UScriptableTool_HUDAPI DrawHUDHelper;
	public UObject AddPropertySetOfType(UClass PropertySetType,string Identifier,EToolsFrameworkOutcomePins Outcome) { return default; }
	public void RemovePropertySetByName(string Identifier,EToolsFrameworkOutcomePins Outcome) {}
	public void SetPropertySetVisibleByName(string Identifier,bool bVisible) {}
	public void ForcePropertySetUpdateByName(string Identifier) {}
	public UObject RestorePropertySetSettings(UObject PropertySet,string SaveKey) { return default; }
	public UObject SavePropertySetSettings(UObject PropertySet,string SaveKey) { return default; }
	public UObject WatchFloatProperty(UObject PropertySet,string PropertyName,FToolFloatPropertyModifiedDelegate OnModified) { return default; }
	public UObject WatchIntProperty(UObject PropertySet,string PropertyName,FToolIntPropertyModifiedDelegate OnModified) { return default; }
	public UObject WatchBoolProperty(UObject PropertySet,string PropertyName,FToolBoolPropertyModifiedDelegate OnModified) { return default; }
	public UObject WatchEnumProperty(UObject PropertySet,string PropertyName,FToolEnumPropertyModifiedDelegate OnModified) { return default; }
	public UObject WatchStringProperty(UObject PropertySet,string PropertyName,FToolStringPropertyModifiedDelegate OnModified) { return default; }
	public UObject WatchNameProperty(UObject PropertySet,string PropertyName,FToolFNamePropertyModifiedDelegate OnModified) { return default; }
	public UObject WatchObjectProperty(UObject PropertySet,string PropertyName,FToolObjectPropertyModifiedDelegate OnModified) { return default; }
	public UObject WatchProperty(UObject PropertySet,string PropertyName,FToolPropertyModifiedDelegate OnModified) { return default; }
	public void CreateTRSGizmo(string Identifier,FTransform InitialTransform,FScriptableToolGizmoOptions GizmoOptions,EToolsFrameworkOutcomePins Outcome) {}
	public void DestroyTRSGizmo(string Identifier,EToolsFrameworkOutcomePins Outcome) {}
	public void SetGizmoVisible(string Identifier,bool bVisible) {}
	public void SetGizmoTransform(string Identifier,FTransform NewTransform,bool bUndoable) {}
	public FTransform GetGizmoTransform(string Identifier) { return default; }
	public void OnGizmoTransformChanged(string GizmoIdentifier,FTransform NewTransform) {}
	public TMap<string,UCombinedTransformGizmo> Gizmos;
	public void AddLogMessage(string Message,bool bHighlighted/*=false*/) {}
	public void DisplayUserHelpMessage(string Message) {}
	public void DisplayUserWarningMessage(string Message) {}
	public void ClearUserMessages(bool bHelpMessage/*=true*/,bool bWarningMessage/*=true*/) {}
}
