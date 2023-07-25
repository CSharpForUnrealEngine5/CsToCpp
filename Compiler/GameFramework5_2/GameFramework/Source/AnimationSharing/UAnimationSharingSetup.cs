#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingSetup.h")]
///<summary>The Animation Sharing Setup asset contains all the information that will be shared across the specified Actors</summary>
public partial class UAnimationSharingSetup : UObject {
// AnimationSharingSetup
	public TArray<FPerSkeletonAnimationSharingSetup> SkeletonSetups;
	public FAnimationSharingScalability ScalabilitySettings;
}
