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
