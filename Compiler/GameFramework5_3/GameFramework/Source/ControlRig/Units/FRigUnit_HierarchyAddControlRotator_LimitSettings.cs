namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
public partial struct FRigUnit_HierarchyAddControlRotator_LimitSettings {
	public FRigControlLimitEnabled LimitPitch;
	public FRigControlLimitEnabled LimitYaw;
	public FRigControlLimitEnabled LimitRoll;
	public FRotator MinValue;
	public FRotator MaxValue;
	public bool bDrawLimits;
}
