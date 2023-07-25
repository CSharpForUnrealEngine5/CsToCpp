#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsAsset.h")]
public partial class USkeletalBodySetup : UBodySetup {
// SkeletalBodySetup
	public FPhysicalAnimationProfile CurrentPhysicalAnimationProfile;
	public bool bSkipScaleFromAnimation;
	public TArray<FPhysicalAnimationProfile> PhysicalAnimationData;
}
