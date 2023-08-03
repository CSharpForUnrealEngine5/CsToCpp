#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/CameraShakeSourceComponent.h")]
public partial class UCameraShakeSourceComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The attenuation profile for how camera shakes&#39; intensity falls off with distance</summary>
	public ECameraShakeAttenuation Attenuation;
	///<summary>Under this distance from the source, the camera shakes are at full intensity</summary>
	public float InnerAttenuationRadius;
	///<summary>Outside of this distance from the source, the camera shakes don&#39;t apply at all</summary>
	public float OuterAttenuationRadius;
	///<summary>CameraShake</summary>
	public UClass CameraShake;
	///<summary>bAutoStart</summary>
	public bool bAutoStart;
	///<summary>Sprite to display in the editor.</summary>
	public UTexture2D EditorSpriteTexture;
	///<summary>Sprite scaling for display in the editor.</summary>
	public float EditorSpriteTextureScale;
	///<summary>Start</summary>
	public  void Start() {}
	///<summary>Starts a new camera shake originating from this source, and apply it on all player controllers</summary>
	public  void StartCameraShake(UClass InCameraShake,float Scale/*=1.0f*/,ECameraShakePlaySpace PlaySpace/*=ECameraShakePlaySpace.CameraLocal*/,FRotator UserPlaySpaceRot/*=FRotator.ZeroRotator*/) {}
	///<summary>Stops a camera shake originating from this source</summary>
	public  void StopAllCameraShakesOfType(UClass InCameraShake,bool bImmediately/*=true*/) {}
	///<summary>Stops all currently active camera shakes that are originating from this source from all player controllers</summary>
	public  void StopAllCameraShakes(bool bImmediately/*=true*/) {}
	///<summary>Computes an attenuation factor from this source</summary>
	public  float GetAttenuationFactor(FVector Location) { return default; }
}
