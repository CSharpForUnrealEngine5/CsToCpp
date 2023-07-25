#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RootMotionModifier.h")]
///<summary>Represents a point of alignment in the world</summary>
public partial struct FMotionWarpingTarget {
// MotionWarpingTarget
	public string Name;
	public FVector Location;
	public FRotator Rotation;
	public TWeakObjectPtr<USceneComponent> Component;
	public string BoneName;
	public bool bFollowComponent;
}
