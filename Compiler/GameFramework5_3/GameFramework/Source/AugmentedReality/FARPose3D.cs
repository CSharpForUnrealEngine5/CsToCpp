namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a human pose tracked in the 3D space</summary>
[CppInclude("ARTypes.h")]
public partial struct FARPose3D {
	public FARSkeletonDefinition SkeletonDefinition;
	public TArray<FTransform> JointTransforms;
	public TArray<bool> IsJointTracked;
	public EARJointTransformSpace JointTransformSpace;
}
