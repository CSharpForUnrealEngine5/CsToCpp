namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Deprecated/RigUnit_TwoBoneIKFK.h")]
public partial struct FRigUnit_TwoBoneIKFK {
	public FName StartJoint;
	public FName EndJoint;
	public FVector PoleTarget;
	public float Spin;
	public FTransform EndEffector;
	public float IKBlend;
	public FTransform StartJointFKTransform;
	public FTransform MidJointFKTransform;
	public FTransform EndJointFKTransform;
	public float PreviousFKIKBlend;
	public FTransform StartJointIKTransform;
	public FTransform MidJointIKTransform;
	public FTransform EndJointIKTransform;
	public int StartJointIndex;
	public int MidJointIndex;
	public int EndJointIndex;
	public float UpperLimbLength;
	public float LowerLimbLength;
	public bool bIsInitialized;
}
