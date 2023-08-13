namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A PlayerCameraManager is responsible for managing the camera for a particular</summary>
[CppInclude("Camera/PlayerCameraManager.h")]
public partial class APlayerCameraManager : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>PlayerController that owns this Camera actor</summary>
	public APlayerController PCOwner;
	///<summary>Dummy component we can use to attach things to the camera.</summary>
	public USceneComponent TransformComponent;
	///<summary>FOV to use by default.</summary>
	public float DefaultFOV;
	///<summary>The default desired width (in world units) of the orthographic view (ignored in Perspective mode)</summary>
	public float DefaultOrthoWidth;
	///<summary>Default aspect ratio. Most of the time the value from a camera component will be used instead.</summary>
	public float DefaultAspectRatio;
	///<summary>CameraCache</summary>
	public FCameraCacheEntry CameraCache;
	///<summary>LastFrameCameraCache</summary>
	public FCameraCacheEntry LastFrameCameraCache;
	///<summary>Current ViewTarget</summary>
	public FTViewTarget ViewTarget;
	///<summary>Pending view target for blending</summary>
	public FTViewTarget PendingViewTarget;
	///<summary>Cached camera properties.</summary>
	public FCameraCacheEntry CameraCachePrivate;
	///<summary>Cached camera properties, one frame old.</summary>
	public FCameraCacheEntry LastFrameCameraCachePrivate;
	///<summary>List of active camera modifier instances that have a chance to update the final camera POV</summary>
	public TArray<UCameraModifier> ModifierList;
	///<summary>List of modifiers to create by default for this camera</summary>
	public TArray<UClass> DefaultModifiers;
	///<summary>Distance to place free camera from view target (used in certain CameraStyles)</summary>
	public float FreeCamDistance;
	///<summary>Offset to Z free camera position (used in certain CameraStyles)</summary>
	public FVector FreeCamOffset;
	///<summary>Offset to view target (used in certain CameraStyles)</summary>
	public FVector ViewTargetOffset;
	///<summary>If bound, broadcast on fade start (with fade time) instead of manually altering audio device&#39;s primary volume directly</summary>
	public FOnAudioFadeChangeSignature OnAudioFadeChangeEvent;
	///<summary>CameraBlood emitter attached to this camera</summary>
	public TArray<object /*CameraLensEffects*/> CameraLensEffects;
	///<summary>Cached ref to modifier for code-driven screen shakes</summary>
	public UCameraModifier_CameraShake CachedCameraShakeMod;
	///<summary>Internal list of active post process effects. Parallel array to PostProcessBlendCacheWeights.</summary>
	public TArray<FPostProcessSettings> PostProcessBlendCache;
	///<summary>Internal. Receives the output of individual camera animations.</summary>
	public ACameraActor AnimCameraActor;
	///<summary>True when this camera should use an orthographic perspective instead of FOV</summary>
	public bool bIsOrthographic;
	///<summary>True if black bars should be added if the destination view has a different aspect ratio (only used when a view target doesn&#39;t specify whether or not to constrain the aspect ratio; most of the time the value from a camera component is used instead)</summary>
	public bool bDefaultConstrainAspectRatio;
	///<summary>True if clients are handling setting their own viewtarget and the server should not replicate it.</summary>
	public bool bClientSimulatingViewTarget;
	///<summary>True if server will use camera positions replicated from the client instead of calculating them locally.</summary>
	public bool bUseClientSideCameraUpdates;
	///<summary>True if we did a camera cut this frame. Automatically reset to false every frame.</summary>
	public bool bGameCameraCutThisFrame;
	///<summary>Minimum view pitch, in degrees.</summary>
	public float ViewPitchMin;
	///<summary>Maximum view pitch, in degrees.</summary>
	public float ViewPitchMax;
	///<summary>Minimum view yaw, in degrees.</summary>
	public float ViewYawMin;
	///<summary>Maximum view yaw, in degrees.</summary>
	public float ViewYawMax;
	///<summary>Minimum view roll, in degrees.</summary>
	public float ViewRollMin;
	///<summary>Maximum view roll, in degrees.</summary>
	public float ViewRollMax;
	///<summary>Implementable blueprint hook to allow a PlayerCameraManager subclass to</summary>
	public void PhotographyCameraModify(FVector NewCameraLocation,FVector PreviousCameraLocation,FVector OriginalCameraLocation,FVector ResultCameraLocation) {}
	///<summary>Event triggered upon entering Photography mode (before pausing, if</summary>
	public void OnPhotographySessionStart() {}
	///<summary>Event triggered upon leaving Photography mode (after unpausing, if</summary>
	public void OnPhotographySessionEnd() {}
	///<summary>Event triggered upon the start of a multi-part photograph capture (i.e. a</summary>
	public void OnPhotographyMultiPartCaptureStart() {}
	///<summary>Event triggered upon the end of a multi-part photograph capture, when manual</summary>
	public void OnPhotographyMultiPartCaptureEnd() {}
	///<summary>Blueprint hook to allow blueprints to override existing camera behavior or implement custom cameras.</summary>
	public bool BlueprintUpdateCamera(AActor CameraTarget,FVector NewCameraLocation,FRotator NewCameraRotation,float NewCameraFOV) { return default; }
	///<summary>Returns the PlayerController that owns this camera.</summary>
	public virtual APlayerController GetOwningPlayerController() { return default; }
	///<summary>Timeout in seconds used to determine when to force a call to ServerUpdateCamera</summary>
	public float ServerUpdateCameraTimeout;
	///<summary>Creates and initializes a new camera modifier of the specified class.</summary>
	public virtual UCameraModifier AddNewCameraModifier(UClass ModifierClass) { return default; }
	///<summary>Returns camera modifier for this camera of the given class, if it exists.</summary>
	public virtual UCameraModifier FindCameraModifierByClass(UClass ModifierClass) { return default; }
	///<summary>Removes the given camera modifier from this camera (if it&#39;s on the camera in the first place) and discards it.</summary>
	public virtual bool RemoveCameraModifier(UCameraModifier ModifierToRemove) { return default; }
	///<summary>Returns the camera&#39;s current full FOV angle, in degrees.</summary>
	public virtual float GetFOVAngle() { return default; }
	///<summary>Returns camera&#39;s current rotation.</summary>
	public virtual FRotator GetCameraRotation() { return default; }
	///<summary>Returns camera&#39;s current location.</summary>
	public virtual FVector GetCameraLocation() { return default; }
	///<summary>Creates a camera lens effect of the given class on this camera.</summary>
	public virtual object /*ReturnValue*/ AddGenericCameraLensEffect(UClass LensEffectEmitterClass) { return default; }
	///<summary>Removes the given lens effect from the camera.</summary>
	public virtual void RemoveGenericCameraLensEffect(object /*Emitter*/ Emitter) {}
	///<summary>Removes all camera lens effects.</summary>
	public virtual void ClearCameraLensEffects() {}
	///<summary>AddCameraLensEffect</summary>
	public virtual AEmitterCameraLensEffectBase AddCameraLensEffect(UClass LensEffectEmitterClass) { return default; }
	///<summary>RemoveCameraLensEffect</summary>
	public virtual void RemoveCameraLensEffect(AEmitterCameraLensEffectBase Emitter) {}
	///<summary>Plays a camera shake on this camera.</summary>
	public virtual UCameraShakeBase StartCameraShake(UClass ShakeClass,float Scale/*=1.0f*/,ECameraShakePlaySpace PlaySpace/*=ECameraShakePlaySpace.CameraLocal*/,FRotator UserPlaySpaceRot/*=FRotator.ZeroRotator*/) { return default; }
	///<summary>Plays a camera shake on this camera.</summary>
	public virtual UCameraShakeBase StartCameraShakeFromSource(UClass ShakeClass,UCameraShakeSourceComponent SourceComponent,float Scale/*=1.0f*/,ECameraShakePlaySpace PlaySpace/*=ECameraShakePlaySpace.CameraLocal*/,FRotator UserPlaySpaceRot/*=FRotator.ZeroRotator*/) { return default; }
	///<summary>Immediately stops the given shake instance and invalidates it.</summary>
	public virtual void StopCameraShake(UCameraShakeBase ShakeInstance,bool bImmediately/*=true*/) {}
	///<summary>Stops playing all shakes of the given class.</summary>
	public virtual void StopAllInstancesOfCameraShake(UClass Shake,bool bImmediately/*=true*/) {}
	///<summary>Stops all active camera shakes on this camera.</summary>
	public virtual void StopAllCameraShakes(bool bImmediately/*=true*/) {}
	///<summary>Stops playing all shakes of the given class originating from the given source.</summary>
	public virtual void StopAllInstancesOfCameraShakeFromSource(UClass Shake,UCameraShakeSourceComponent SourceComponent,bool bImmediately/*=true*/) {}
	///<summary>Stops playing all shakes originating from the given source.</summary>
	public virtual void StopAllCameraShakesFromSource(UCameraShakeSourceComponent SourceComponent,bool bImmediately/*=true*/) {}
	///<summary>Does a camera fade to/from a solid color.  Animates automatically.</summary>
	public virtual void StartCameraFade(float FromAlpha,float ToAlpha,float Duration,FLinearColor Color,bool bShouldFadeAudio/*=false*/,bool bHoldWhenFinished/*=false*/) {}
	///<summary>Stops camera fading.</summary>
	public virtual void StopCameraFade() {}
	///<summary>Turns on camera fading at the given opacity. Does not auto-animate, allowing user to animate themselves.</summary>
	public virtual void SetManualCameraFade(float InFadeAmount,FLinearColor Color,bool bInFadeAudio) {}
	///<summary>Sets the bGameCameraCutThisFrame flag to true (indicating we did a camera cut this frame; useful for game code to call, e.g., when performing a teleport that should be seamless)</summary>
	public virtual void SetGameCameraCutThisFrame() {}
	///<summary>ClientSide camera updates prevents DoUpdateCamera from swapping PendingViewTarget in when the blend is complete, just use a timer to swap</summary>
	public void SwapPendingViewTargetWhenUsingClientSideCameraUpdates() {}
}
