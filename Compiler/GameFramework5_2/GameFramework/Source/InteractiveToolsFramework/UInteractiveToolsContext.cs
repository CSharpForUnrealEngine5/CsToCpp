#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InteractiveToolsContext.h")]
///<summary>InteractiveToolsContext owns the core parts of an Interactive Tools Framework implementation - the</summary>
public partial class UInteractiveToolsContext : UObject {
// InteractiveToolsContext
	public UInputRouter InputRouter;
	public UToolTargetManager TargetManager;
	public UInteractiveToolManager ToolManager;
	public UInteractiveGizmoManager GizmoManager;
	public UContextObjectStore ContextObjectStore;
	public TSoftObjectPtr<UClass> ToolManagerClass;
}
