#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingTypes.h")]
public partial struct FPerSkeletonAnimationSharingSetup {
	public USkeleton Skeleton;
	public USkeletalMesh SkeletalMesh;
	public UClass BlendAnimBlueprint;
	public UClass AdditiveAnimBlueprint;
	public UClass StateProcessorClass;
	public TArray<FAnimationStateEntry> AnimationStates;
}
