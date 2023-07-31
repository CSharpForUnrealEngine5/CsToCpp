#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UScriptableInteractiveTool is an extension of UInteractiveTool that allows the Tool functionality to be</summary>
[CppInclude("ScriptableInteractiveTool.h")]
public partial class UScriptableInteractiveTool : UInteractiveTool {
	///<summary>Name of this Tool, will be used in (eg) Toolbars</summary>
	public string ToolName;
	///<summary>Long Name of this Tool, will be used in (eg) longer labels like the Accept/Cancel toolbar</summary>
	public string ToolLongName;
	///<summary>Category of this Tool, will be used in (eg) Tool Palette Section headers</summary>
	public string ToolCategory;
	///<summary>Tooltip used for this Tool in (eg) icons/etc</summary>
	public string ToolTooltip;
	///<summary>A generic flag to indicate whether this Tool should be shown in the UE Editor. This may be interpreted in different ways</summary>
	public bool bShowToolInEditor;
	///<summary>Specifies how the user exits this Tool, either Accept/Cancel-style or Complete-style</summary>
	public EScriptableToolShutdownType ToolShutdownType;
	///<summary>Implement OnScriptSetup to do initial setup/configuration of the Tool, such as adding</summary>
	public  void OnScriptSetup() {}
	///<summary>OnScriptTick is called every Editor Tick, ie basically every frame.</summary>
	public  void OnScriptTick(float DeltaTime) {}
	///<summary>CanAccept function. Implement this function for AcceptCancel Tools, and return</summary>
	public  bool OnScriptCanAccept() { return default; }
	///<summary>OnScriptShutdown is called when the Tool is shutting down. The ShutdownType defines</summary>
	public  void OnScriptShutdown(EToolShutdownType ShutdownType) {}
	///<summary>Request that the active Tool be shut down. The Tool can post this to shut itself down (eg in a Tool where</summary>
	public  void RequestToolShutdown(bool bAccept,bool bShowUserPopupMessage,string UserMessage) {}
	///<summary>TargetWorld</summary>
	public TWeakObjectPtr<UWorld> TargetWorld;
	///<summary>Access the World this Tool is currently operating on.</summary>
	public  UWorld GetToolWorld() { return default; }
	///<summary>OnScriptRender is called every frame. Use the RenderAPI object to draw</summary>
	public  void OnScriptRender(UScriptableTool_RenderAPI RenderAPI) {}
	///<summary>OnScriptDrawHUD is called every frame. Use the DrawHUDAPI to draw various</summary>
	public  void OnScriptDrawHUD(UScriptableTool_HUDAPI DrawHUDAPI) {}
	///<summary>RenderHelper</summary>
	public UScriptableTool_RenderAPI RenderHelper;
	///<summary>DrawHUDHelper</summary>
	public UScriptableTool_HUDAPI DrawHUDHelper;
	///<summary>Create a new Tool Property Set (ie BP subclass of UScriptableInteractiveToolPropertySet) with the given string Identifier</summary>
	public  UScriptableInteractiveToolPropertySet AddPropertySetOfType(UClass PropertySetType,string Identifier,EToolsFrameworkOutcomePins Outcome) { return default; }
	///<summary>Remove a Property Set from the current Tool, found via it&#39;s unique Identifier.</summary>
	public  void RemovePropertySetByName(string Identifier,EToolsFrameworkOutcomePins Outcome) {}
	///<summary>Set the visibility of a Property Set that is paired with the given unique Identifier.</summary>
	public  void SetPropertySetVisibleByName(string Identifier,bool bVisible) {}
	///<summary>Force the Property Set associated with the given Identifier to be updated.</summary>
	public  void ForcePropertySetUpdateByName(string Identifier) {}
	///<summary>Restore the values of the specified PropertySet, optionally with a specific SaveKey string.</summary>
	public  UScriptableInteractiveToolPropertySet RestorePropertySetSettings(UScriptableInteractiveToolPropertySet PropertySet,string SaveKey) { return default; }
	///<summary>Save the values of the specified PropertySet, optionally with a specific SaveKey string.</summary>
	public  UScriptableInteractiveToolPropertySet SavePropertySetSettings(UScriptableInteractiveToolPropertySet PropertySet,string SaveKey) { return default; }
	///<summary>Watch a Float-valued Property for changes (double precision)</summary>
	public  UScriptableInteractiveToolPropertySet WatchFloatProperty(UScriptableInteractiveToolPropertySet PropertySet,string PropertyName,FToolFloatPropertyModifiedDelegate OnModified) { return default; }
	///<summary>Watch an Integer-valued Property for changes</summary>
	public  UScriptableInteractiveToolPropertySet WatchIntProperty(UScriptableInteractiveToolPropertySet PropertySet,string PropertyName,FToolIntPropertyModifiedDelegate OnModified) { return default; }
	///<summary>Watch a Bool-valued Property for changes</summary>
	public  UScriptableInteractiveToolPropertySet WatchBoolProperty(UScriptableInteractiveToolPropertySet PropertySet,string PropertyName,FToolBoolPropertyModifiedDelegate OnModified) { return default; }
	///<summary>Watch an Enum-valued Property for changes. Note that in this case the OnModified</summary>
	public  UScriptableInteractiveToolPropertySet WatchEnumProperty(UScriptableInteractiveToolPropertySet PropertySet,string PropertyName,FToolEnumPropertyModifiedDelegate OnModified) { return default; }
	///<summary>Watch a String-valued Property for changes</summary>
	public  UScriptableInteractiveToolPropertySet WatchStringProperty(UScriptableInteractiveToolPropertySet PropertySet,string PropertyName,FToolStringPropertyModifiedDelegate OnModified) { return default; }
	///<summary>Watch an (F)Name-valued Property for changes</summary>
	public  UScriptableInteractiveToolPropertySet WatchNameProperty(UScriptableInteractiveToolPropertySet PropertySet,string PropertyName,FToolFNamePropertyModifiedDelegate OnModified) { return default; }
	///<summary>Watch an Object-valued Property for changes (ie UObject, UClass, etc)</summary>
	public  UScriptableInteractiveToolPropertySet WatchObjectProperty(UScriptableInteractiveToolPropertySet PropertySet,string PropertyName,FToolObjectPropertyModifiedDelegate OnModified) { return default; }
	///<summary>Watch any Property in a PropertySet for changes. This function handles most basic</summary>
	public  UScriptableInteractiveToolPropertySet WatchProperty(UScriptableInteractiveToolPropertySet PropertySet,string PropertyName,FToolPropertyModifiedDelegate OnModified) { return default; }
	///<summary>Create a Translate/Rotate/Scale Gizmo with the given Options at the specified InitialTransform.</summary>
	public  void CreateTRSGizmo(string Identifier,FTransform InitialTransform,FScriptableToolGizmoOptions GizmoOptions,EToolsFrameworkOutcomePins Outcome) {}
	///<summary>Destroy a created Gizmo by name Identifier</summary>
	public  void DestroyTRSGizmo(string Identifier,EToolsFrameworkOutcomePins Outcome) {}
	///<summary>Set an existing Gizmo visible/hidden based on its name Identifier</summary>
	public  void SetGizmoVisible(string Identifier,bool bVisible) {}
	///<summary>Update the Transform on the Gizmo specified by the name Identifier</summary>
	public  void SetGizmoTransform(string Identifier,FTransform NewTransform,bool bUndoable) {}
	///<summary>Get the current Transform on the Gizmo specified by the name Identifier</summary>
	public  FTransform GetGizmoTransform(string Identifier) { return default; }
	///<summary>The OnGizmoTransformChanged event fires whenever the transform on any Gizmo created by CreateTRSGizmo() is modified.</summary>
	public  void OnGizmoTransformChanged(string GizmoIdentifier,FTransform NewTransform) {}
	///<summary>trying to avoid making a UStruct for this internal stuff</summary>
	public TMap<string,UCombinedTransformGizmo> Gizmos;
	///<summary>Append a Message to the UE Editor Log.</summary>
	public  void AddLogMessage(string Message,bool bHighlighted/*=false*/) {}
	///<summary>Display a short Help message for the user, ie to guide them in Tool usage.</summary>
	public  void DisplayUserHelpMessage(string Message) {}
	///<summary>Display a Warning message to the user, ie to indicate a problem/issue occurred.</summary>
	public  void DisplayUserWarningMessage(string Message) {}
	///<summary>Clear any active message shown via DisplayUserHelpMessage and/or DisplayUserWarningMessage</summary>
	public  void ClearUserMessages(bool bHelpMessage/*=true*/,bool bWarningMessage/*=true*/) {}
}
