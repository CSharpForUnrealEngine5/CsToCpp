#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LensComponent.h")]
///<summary>Component for applying a post-process lens distortion effect to a CineCameraComponent on the same actor</summary>
public partial class ULensComponent : UActorComponent {
// LensComponent
	public  FLensFilePicker GetLensFilePicker() { return default; }
	public  ULensFile GetLensFile() { return default; }
	public  void SetLensFilePicker(FLensFilePicker LensFile) {}
	public  void SetLensFile(ULensFile LensFile) {}
	public  EFIZEvaluationMode GetFIZEvaluationMode() { return default; }
	public  void SetFIZEvaluationMode(EFIZEvaluationMode Mode) {}
	public  float GetOverscanMultiplier() { return default; }
	public  void SetOverscanMultiplier(float Multiplier) {}
	public  EFilmbackOverrideSource GetFilmbackOverrideSetting() { return default; }
	public  void SetFilmbackOverrideSetting(EFilmbackOverrideSource Setting) {}
	public  FCameraFilmbackSettings GetCroppedFilmback() { return default; }
	public  void SetCroppedFilmback(FCameraFilmbackSettings Filmback) {}
	public  bool ShouldApplyNodalOffsetOnTick() { return default; }
	public  void SetApplyNodalOffsetOnTick(bool bApplyNodalOffset) {}
	public  EDistortionSource GetDistortionSource() { return default; }
	public  void SetDistortionSource(EDistortionSource Source) {}
	public  bool ShouldApplyDistortion() { return default; }
	public  void SetApplyDistortion(bool bApply) {}
	public  UClass GetLensModel() { return default; }
	public  void SetLensModel(UClass Model) {}
	public  FLensDistortionState GetDistortionState() { return default; }
	public  void SetDistortionState(FLensDistortionState State) {}
	public  void ClearDistortionState() {}
	public  float GetOriginalFocalLength() { return default; }
	public  FLensFileEvaluationInputs GetLensFileEvaluationInputs() { return default; }
	public  bool WasNodalOffsetAppliedThisTick() { return default; }
	public  bool WasDistortionEvaluated() { return default; }
	public  void ApplyNodalOffset(USceneComponent ComponentToOffset,bool bUseManualInputs/*=false*/,float ManualFocusInput/*=0.0f*/,float ManualZoomInput/*=0.0f*/) {}
	public FLensFilePicker LensFilePicker;
	public EFIZEvaluationMode EvaluationMode;
	public FComponentReference TargetCameraComponent;
	public FLensFileEvaluationInputs EvalInputs;
	public EDistortionSource DistortionStateSource;
	public bool bApplyDistortion;
	public UClass LensModel;
	public FLensDistortionState DistortionState;
	public bool bScaleOverscan;
	public float OverscanMultiplier;
	public EFilmbackOverrideSource FilmbackOverride;
	public FCameraFilmbackSettings CroppedFilmback;
	public bool bApplyNodalOffsetOnTick;
	public FTransform OriginalTrackedComponentTransform;
	public bool bIsDistortionSetup;
	public float OriginalFocalLength;
	public UMaterialInstanceDynamic LastDistortionMID;
	public UCineCameraComponent LastCameraComponent;
	public TMap<UClass,ULensDistortionModelHandlerBase> LensDistortionHandlerMap;
	public TWeakObjectPtr<USceneComponent> TrackedComponent;
	public string TrackedComponentName;
	public FRotator OriginalCameraRotation_DEPRECATED;
	public FVector OriginalCameraLocation_DEPRECATED;
	public bool bEvaluateLensFileForDistortion_DEPRECATED;
	public ULensDistortionModelHandlerBase LensDistortionHandler_DEPRECATED;
	public FGuid DistortionProducerID_DEPRECATED;
	public FDistortionHandlerPicker DistortionSource_DEPRECATED;
}
