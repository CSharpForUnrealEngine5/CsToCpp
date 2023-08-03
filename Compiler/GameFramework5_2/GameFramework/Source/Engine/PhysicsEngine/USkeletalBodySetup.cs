#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsAsset.h")]
public partial class USkeletalBodySetup : UBodySetup {
	public static UClass StaticClass() {return default;}
	///<summary>dummy place for customization inside phat. Profiles are ordered dynamically and we need a static place for detail customization</summary>
	public FPhysicalAnimationProfile CurrentPhysicalAnimationProfile;
	///<summary>If true we ignore scale changes from animation. This is useful for subtle scale animations like breathing where the physics collision should remain unchanged</summary>
	public bool bSkipScaleFromAnimation;
	///<summary>PhysicalAnimationData</summary>
	public TArray<FPhysicalAnimationProfile> PhysicalAnimationData;
}
