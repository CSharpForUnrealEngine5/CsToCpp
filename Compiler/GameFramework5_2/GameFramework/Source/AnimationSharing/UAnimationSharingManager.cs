#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingManager.h")]
public partial class UAnimationSharingManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the AnimationSharing Manager, nullptr if none was set up</summary>
	public static UAnimationSharingManager GetAnimationSharingManager(UObject WorldContextObject) { return default; }
	///<summary>Create an Animation Sharing Manager using the provided Setup</summary>
	public static bool CreateAnimationSharingManager(UObject WorldContextObject,UAnimationSharingSetup Setup) { return default; }
	///<summary>Register an Actor with this Animation Sharing manager, according to the SharingSkeleton</summary>
	public  void RegisterActorWithSkeletonBP(AActor InActor,USkeleton SharingSkeleton) {}
	///<summary>Returns whether or not the animation sharing is enabled</summary>
	public static bool AnimationSharingEnabled() { return default; }
	///<summary>Array of unique skeletons, matches PerSkeletonData array entries</summary>
	public TArray<USkeleton> Skeletons;
	///<summary>Sharing data required for the unique Skeleton setups</summary>
	public TArray<UAnimSharingInstance> PerSkeletonData;
}
