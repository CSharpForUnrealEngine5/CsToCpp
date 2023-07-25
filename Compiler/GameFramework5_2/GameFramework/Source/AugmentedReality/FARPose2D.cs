#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTypes.h")]
///<summary>Represents a human pose tracked in the 2D space</summary>
public partial struct FARPose2D {
// ARPose2D
	public FARSkeletonDefinition SkeletonDefinition;
	public TArray<FVector2D> JointLocations;
	public TArray<bool> IsJointTracked;
}
