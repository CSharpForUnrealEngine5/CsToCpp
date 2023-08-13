namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>InteractiveToolsContext owns the core parts of an Interactive Tools Framework implementation - the</summary>
[CppInclude("InteractiveToolsContext.h")]
public partial class UInteractiveToolsContext : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>current UInputRouter for this Context</summary>
	public UInputRouter InputRouter;
	///<summary>current UToolTargetManager for this Context</summary>
	public UToolTargetManager TargetManager;
	///<summary>current UInteractiveToolManager for this Context</summary>
	public UInteractiveToolManager ToolManager;
	///<summary>current UInteractiveGizmoManager for this Context</summary>
	public UInteractiveGizmoManager GizmoManager;
	///<summary>Current Context Object Store for this Context.</summary>
	public UContextObjectStore ContextObjectStore;
	///<summary>todo: deprecate and remove this, can now be accomplished via CreateToolManagerFunc()</summary>
	public TSoftObjectPtr<UClass> ToolManagerClass;
}
