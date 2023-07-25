#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTypes.h")]
///<summary>Represents a human pose tracked in the 3D space</summary>
public partial struct FARPose3D {
// ARPose3D
	public FARSkeletonDefinition SkeletonDefinition;
	public TArray<FTransform> JointTransforms;
	public TArray<bool> IsJointTracked;
	public EARJointTransformSpace JointTransformSpace;
}
