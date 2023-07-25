#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Harmonics/RigUnit_ChainHarmonics.h")]
public partial struct FRigUnit_ChainHarmonics_Pendulum {
// RigUnit_ChainHarmonics_Pendulum
	public bool bEnabled;
	public float PendulumStiffness;
	public FVector PendulumGravity;
	public float PendulumBlend;
	public float PendulumDrag;
	public float PendulumMinimum;
	public float PendulumMaximum;
	public ERigVMAnimEasingType PendulumEase;
	public FVector UnwindAxis;
	public float UnwindMinimum;
	public float UnwindMaximum;
}
