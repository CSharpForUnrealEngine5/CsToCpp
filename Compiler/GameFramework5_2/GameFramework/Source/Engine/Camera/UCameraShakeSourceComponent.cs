#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraShakeSourceComponent.h")]
public partial class UCameraShakeSourceComponent : USceneComponent {
// CameraShakeSourceComponent
	public ECameraShakeAttenuation Attenuation;
	public float InnerAttenuationRadius;
	public float OuterAttenuationRadius;
	public UClass CameraShake;
	public bool bAutoStart;
	public UTexture2D EditorSpriteTexture;
	public float EditorSpriteTextureScale;
	public void Start() {}
	public void StartCameraShake(UClass InCameraShake,float Scale/*=1.0f*/,ECameraShakePlaySpace PlaySpace/*=ECameraShakePlaySpace.CameraLocal*/,FRotator UserPlaySpaceRot/*=FRotator.ZeroRotator*/) {}
	public void StopAllCameraShakesOfType(UClass InCameraShake,bool bImmediately/*=true*/) {}
	public void StopAllCameraShakes(bool bImmediately/*=true*/) {}
	public float GetAttenuationFactor(FVector Location) { return default; }
}
