#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a point of alignment in the world</summary>
[CppInclude("RootMotionModifier.h")]
public partial struct FMotionWarpingTarget {
	public string Name;
	public FVector Location;
	public FRotator Rotation;
	public TWeakObjectPtr<USceneComponent> Component;
	public string BoneName;
	public bool bFollowComponent;
}
