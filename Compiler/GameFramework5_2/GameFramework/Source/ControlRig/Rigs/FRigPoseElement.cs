namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchyPose.h")]
public partial struct FRigPoseElement {
	public FCachedRigElement Index;
	public FTransform GlobalTransform;
	public FTransform LocalTransform;
	public float CurveValue;
}
