#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingManager.h")]
public partial class UAnimationSharingManager : UObject {
// AnimationSharingManager
	public UObject GetAnimationSharingManager(UObject WorldContextObject) { return default; }
	public bool CreateAnimationSharingManager(UObject WorldContextObject,UObject Setup) { return default; }
	public void RegisterActorWithSkeletonBP(UObject InActor,UObject SharingSkeleton) {}
	public bool AnimationSharingEnabled() { return default; }
	public TArray<USkeleton> Skeletons;
	public TArray<UAnimSharingInstance> PerSkeletonData;
}
