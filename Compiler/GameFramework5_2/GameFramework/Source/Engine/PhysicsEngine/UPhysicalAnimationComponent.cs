#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicalAnimationComponent.h")]
public partial class UPhysicalAnimationComponent : UActorComponent {
// PhysicalAnimationComponent
	public void SetSkeletalMeshComponent(UObject InSkeletalMeshComponent) {}
	public void ApplyPhysicalAnimationSettings(string BodyName,FPhysicalAnimationData PhysicalAnimationData) {}
	public void ApplyPhysicalAnimationSettingsBelow(string BodyName,FPhysicalAnimationData PhysicalAnimationData,bool bIncludeSelf/*=true*/) {}
	public void SetStrengthMultiplyer(float InStrengthMultiplyer) {}
	public float StrengthMultiplyer;
	public void ApplyPhysicalAnimationProfileBelow(string BodyName,string ProfileName,bool bIncludeSelf/*=true*/,bool bClearNotFound/*=false*/) {}
	public FTransform GetBodyTargetTransform(string BodyName) { return default; }
	public USkeletalMeshComponent SkeletalMeshComponent;
}
