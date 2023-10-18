namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet2/Breakpoint.h")]
public partial struct FBlueprintBreakpoint {
	public bool bEnabled;
	public TSoftObjectPtr<UEdGraphNode> Node;
	public bool bStepOnce;
	public bool bStepOnce_WasPreviouslyDisabled;
	public bool bStepOnce_RemoveAfterHit;
}
