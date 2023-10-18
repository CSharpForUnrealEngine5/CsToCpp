namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a point of alignment in the world</summary>
[CppInclude("RootMotionModifier.h")]
public partial struct FMotionWarpingTarget {
	public FName Name;
	public FVector Location;
	public FRotator Rotation;
	public TWeakObjectPtr<USceneComponent> Component;
	public FName BoneName;
	public bool bFollowComponent;
}
