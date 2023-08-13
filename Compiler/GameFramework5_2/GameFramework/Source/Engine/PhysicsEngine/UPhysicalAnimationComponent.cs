namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicalAnimationComponent.h")]
public partial class UPhysicalAnimationComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the skeletal mesh we are driving through physical animation. Will erase any existing physical animation data.</summary>
	public void SetSkeletalMeshComponent(USkeletalMeshComponent InSkeletalMeshComponent) {}
	///<summary>Applies the physical animation settings to the body given.</summary>
	public void ApplyPhysicalAnimationSettings(string BodyName,FPhysicalAnimationData PhysicalAnimationData) {}
	///<summary>Applies the physical animation settings to the body given and all bodies below.</summary>
	public void ApplyPhysicalAnimationSettingsBelow(string BodyName,FPhysicalAnimationData PhysicalAnimationData,bool bIncludeSelf/*=true*/) {}
	///<summary>Updates strength multiplyer and any active motors</summary>
	public void SetStrengthMultiplyer(float InStrengthMultiplyer) {}
	///<summary>Multiplies the strength of any active motors. (can blend from 0-1 for example)</summary>
	public float StrengthMultiplyer;
	///<summary>Applies the physical animation profile to the body given and all bodies below.</summary>
	public void ApplyPhysicalAnimationProfileBelow(string BodyName,string ProfileName,bool bIncludeSelf/*=true*/,bool bClearNotFound/*=false*/) {}
	///<summary>Returns the target transform for the given body. If physical animation component is not controlling this body, returns its current transform.</summary>
	public FTransform GetBodyTargetTransform(string BodyName) { return default; }
	///<summary>SkeletalMeshComponent</summary>
	public USkeletalMeshComponent SkeletalMeshComponent;
}
