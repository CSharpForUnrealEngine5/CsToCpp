#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_DynamicHierarchy.h")]
public partial struct FRigUnit_HierarchyAddControlVector_LimitSettings {
// RigUnit_HierarchyAddControlVector_LimitSettings
	public FRigControlLimitEnabled LimitX;
	public FRigControlLimitEnabled LimitY;
	public FRigControlLimitEnabled LimitZ;
	public FVector MinValue;
	public FVector MaxValue;
	public bool bDrawLimits;
}
