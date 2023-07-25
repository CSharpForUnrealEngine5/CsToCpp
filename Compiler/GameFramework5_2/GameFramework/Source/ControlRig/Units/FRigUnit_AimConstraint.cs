#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Deprecated/RigUnit_AimConstraint.h")]
public partial struct FRigUnit_AimConstraint {
// RigUnit_AimConstraint
	public string Joint;
	public EAimMode AimMode;
	public EAimMode UpMode;
	public FVector AimVector;
	public FVector UpVector;
	public TArray<FAimTarget> AimTargets;
	public TArray<FAimTarget> UpTargets;
	public FRigUnit_AimConstraint_WorkData WorkData;
}
