#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a human pose tracked in the 2D space</summary>
[CppInclude("ARTypes.h")]
public partial struct FARPose2D {
	public FARSkeletonDefinition SkeletonDefinition;
	public TArray<FVector2D> JointLocations;
	public TArray<bool> IsJointTracked;
}
