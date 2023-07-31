#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Data Stored For Each Control in A Pose.</summary>
[CppInclude("Tools/ControlRigPose.h")]
public partial struct FRigControlCopy {
	public string Name;
	public ERigControlType ControlType;
	public FRigControlValue Value;
	public FRigElementKey ParentKey;
	public FTransform OffsetTransform;
	public FTransform ParentTransform;
	public FTransform LocalTransform;
	public FTransform GlobalTransform;
}
