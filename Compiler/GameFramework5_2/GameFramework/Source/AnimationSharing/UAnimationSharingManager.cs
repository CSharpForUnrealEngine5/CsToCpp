#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingManager.h")]
public partial class UAnimationSharingManager : UObject {
// AnimationSharingManager
	public static UAnimationSharingManager GetAnimationSharingManager(UObject WorldContextObject) { return default; }
	public static bool CreateAnimationSharingManager(UObject WorldContextObject,UAnimationSharingSetup Setup) { return default; }
	public  void RegisterActorWithSkeletonBP(AActor InActor,USkeleton SharingSkeleton) {}
	public static bool AnimationSharingEnabled() { return default; }
	public TArray<USkeleton> Skeletons;
	public TArray<UAnimSharingInstance> PerSkeletonData;
}
