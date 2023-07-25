#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
///<summary>Returns an array of transforms from a given hierarchy pose</summary>
public partial struct FRigUnit_PoseGetTransformArray {
// RigUnit_PoseGetTransformArray
	public FRigPose Pose;
	public ERigVMTransformSpace Space;
	public bool Valid;
	public TArray<FTransform> Transforms;
}
