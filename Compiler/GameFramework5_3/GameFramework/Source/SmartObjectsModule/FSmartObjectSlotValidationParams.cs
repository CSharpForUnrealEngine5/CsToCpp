namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters for Smart Object navigation and collision validation.</summary>
[CppInclude("SmartObjectTypes.h")]
public partial struct FSmartObjectSlotValidationParams {
	public UClass NavigationFilter;
	public FVector SearchExtents;
	public FSmartObjectTraceParams GroundTraceParameters;
	public FSmartObjectTraceParams TransitionTraceParameters;
	public bool bUseNavigationCapsuleSize;
	public FSmartObjectUserCapsuleParams UserCapsule;
}
