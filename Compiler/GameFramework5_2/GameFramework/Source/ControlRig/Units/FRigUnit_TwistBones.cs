#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Highlevel/Hierarchy/RigUnit_TwistBones.h")]
///<summary>Creates a gradient of twist rotation along a chain.</summary>
public partial struct FRigUnit_TwistBones {
// RigUnit_TwistBones
	public string StartBone;
	public string EndBone;
	public FVector TwistAxis;
	public FVector PoleAxis;
	public ERigVMAnimEasingType TwistEaseType;
	public float Weight;
	public bool bPropagateToChildren;
	public FRigUnit_TwistBones_WorkData WorkData;
}
