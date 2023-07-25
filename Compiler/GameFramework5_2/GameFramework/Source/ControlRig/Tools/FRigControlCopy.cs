#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/ControlRigPose.h")]
///<summary>The Data Stored For Each Control in A Pose.</summary>
public partial struct FRigControlCopy {
// RigControlCopy
	public string Name;
	public ERigControlType ControlType;
	public FRigControlValue Value;
	public FRigElementKey ParentKey;
	public FTransform OffsetTransform;
	public FTransform ParentTransform;
	public FTransform LocalTransform;
	public FTransform GlobalTransform;
}
