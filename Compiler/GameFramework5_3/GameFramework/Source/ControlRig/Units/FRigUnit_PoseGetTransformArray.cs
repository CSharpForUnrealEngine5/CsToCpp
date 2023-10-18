namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns an array of transforms from a given hierarchy pose</summary>
[CppInclude("Units/Execution/RigUnit_Hierarchy.h")]
public partial struct FRigUnit_PoseGetTransformArray {
	public FRigPose Pose;
	public ERigVMTransformSpace Space;
	public bool Valid;
	public TArray<FTransform> Transforms;
}
