#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingTypes.h")]
public partial struct FPerSkeletonAnimationSharingSetup {
// PerSkeletonAnimationSharingSetup
	public USkeleton Skeleton;
	public USkeletalMesh SkeletalMesh;
	public UClass BlendAnimBlueprint;
	public UClass AdditiveAnimBlueprint;
	public UClass StateProcessorClass;
	public TArray<FAnimationStateEntry> AnimationStates;
}
