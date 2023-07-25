#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Camera/PlayerCameraManager.h")]
///<summary>A PlayerCameraManager is responsible for managing the camera for a particular</summary>
public partial class APlayerCameraManager : AActor {
// PlayerCameraManager
	public APlayerController PCOwner;
	public USceneComponent TransformComponent;
	public float DefaultFOV;
	public float DefaultOrthoWidth;
	public float DefaultAspectRatio;
	public FCameraCacheEntry CameraCache;
	public FCameraCacheEntry LastFrameCameraCache;
	public FTViewTarget ViewTarget;
	public FTViewTarget PendingViewTarget;
	public FCameraCacheEntry CameraCachePrivate;
	public FCameraCacheEntry LastFrameCameraCachePrivate;
	public TArray<UCameraModifier> ModifierList;
	public TArray<UClass> DefaultModifiers;
	public float FreeCamDistance;
	public FVector FreeCamOffset;
	public FVector ViewTargetOffset;
	public FOnAudioFadeChangeSignature OnAudioFadeChangeEvent;
	public TArray<object /*CameraLensEffects*/> CameraLensEffects;
	public UCameraModifier_CameraShake CachedCameraShakeMod;
	public TArray<FPostProcessSettings> PostProcessBlendCache;
	public ACameraActor AnimCameraActor;
	public bool bIsOrthographic;
	public bool bDefaultConstrainAspectRatio;
	public bool bClientSimulatingViewTarget;
	public bool bUseClientSideCameraUpdates;
	public bool bGameCameraCutThisFrame;
	public float ViewPitchMin;
	public float ViewPitchMax;
	public float ViewYawMin;
	public float ViewYawMax;
	public float ViewRollMin;
	public float ViewRollMax;
	public void PhotographyCameraModify(FVector NewCameraLocation,FVector PreviousCameraLocation,FVector OriginalCameraLocation,FVector ResultCameraLocation) {}
	public void OnPhotographySessionStart() {}
	public void OnPhotographySessionEnd() {}
	public void OnPhotographyMultiPartCaptureStart() {}
	public void OnPhotographyMultiPartCaptureEnd() {}
	public bool BlueprintUpdateCamera(UObject CameraTarget,FVector NewCameraLocation,FRotator NewCameraRotation,float NewCameraFOV) { return default; }
	public UObject GetOwningPlayerController() { return default; }
	public float ServerUpdateCameraTimeout;
	public UObject AddNewCameraModifier(UClass ModifierClass) { return default; }
	public UObject FindCameraModifierByClass(UClass ModifierClass) { return default; }
	public bool RemoveCameraModifier(UObject ModifierToRemove) { return default; }
	public float GetFOVAngle() { return default; }
	public FRotator GetCameraRotation() { return default; }
	public FVector GetCameraLocation() { return default; }
	public object /*ReturnValue*/ AddGenericCameraLensEffect(UClass LensEffectEmitterClass) { return default; }
	public void RemoveGenericCameraLensEffect(object /*Emitter*/ Emitter) {}
	public void ClearCameraLensEffects() {}
	public UObject AddCameraLensEffect(UClass LensEffectEmitterClass) { return default; }
	public void RemoveCameraLensEffect(UObject Emitter) {}
	public UObject StartCameraShake(UClass ShakeClass,float Scale/*=1.0f*/,ECameraShakePlaySpace PlaySpace/*=ECameraShakePlaySpace.CameraLocal*/,FRotator UserPlaySpaceRot/*=FRotator.ZeroRotator*/) { return default; }
	public UObject StartCameraShakeFromSource(UClass ShakeClass,UObject SourceComponent,float Scale/*=1.0f*/,ECameraShakePlaySpace PlaySpace/*=ECameraShakePlaySpace.CameraLocal*/,FRotator UserPlaySpaceRot/*=FRotator.ZeroRotator*/) { return default; }
	public void StopCameraShake(UObject ShakeInstance,bool bImmediately/*=true*/) {}
	public void StopAllInstancesOfCameraShake(UClass Shake,bool bImmediately/*=true*/) {}
	public void StopAllCameraShakes(bool bImmediately/*=true*/) {}
	public void StopAllInstancesOfCameraShakeFromSource(UClass Shake,UObject SourceComponent,bool bImmediately/*=true*/) {}
	public void StopAllCameraShakesFromSource(UObject SourceComponent,bool bImmediately/*=true*/) {}
	public void StartCameraFade(float FromAlpha,float ToAlpha,float Duration,FLinearColor Color,bool bShouldFadeAudio/*=false*/,bool bHoldWhenFinished/*=false*/) {}
	public void StopCameraFade() {}
	public void SetManualCameraFade(float InFadeAmount,FLinearColor Color,bool bInFadeAudio) {}
	public void SetGameCameraCutThisFrame() {}
	public void SwapPendingViewTargetWhenUsingClientSideCameraUpdates() {}
}
