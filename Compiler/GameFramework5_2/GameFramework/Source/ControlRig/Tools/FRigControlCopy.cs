namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Data Stored For Each Control in A Pose.</summary>
[CppInclude("Tools/ControlRigPose.h")]
public partial struct FRigControlCopy {
	public FName Name;
	public ERigControlType ControlType;
	public FRigControlValue Value;
	public FRigElementKey ParentKey;
	public FTransform OffsetTransform;
	public FTransform ParentTransform;
	public FTransform LocalTransform;
	public FTransform GlobalTransform;
}
