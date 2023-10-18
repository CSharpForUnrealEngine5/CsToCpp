namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Creates a gradient of twist rotation along a chain.</summary>
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TwistBones.h")]
public partial struct FRigUnit_TwistBones {
	public FName StartBone;
	public FName EndBone;
	public FVector TwistAxis;
	public FVector PoleAxis;
	public ERigVMAnimEasingType TwistEaseType;
	public float Weight;
	public bool bPropagateToChildren;
	public FRigUnit_TwistBones_WorkData WorkData;
}
