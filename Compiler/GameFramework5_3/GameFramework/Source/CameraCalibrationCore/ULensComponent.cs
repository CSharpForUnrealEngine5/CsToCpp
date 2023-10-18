namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component for applying a post-process lens distortion effect to a CineCameraComponent on the same actor</summary>
[CppInclude("LensComponent.h")]
public partial class ULensComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Get the LensFile picker used by this component</summary>
	public FLensFilePicker GetLensFilePicker() { return default; }
	///<summary>Get the LensFile used by this component</summary>
	public ULensFile GetLensFile() { return default; }
	///<summary>Set the LensFile picker used by this component</summary>
	public void SetLensFilePicker(FLensFilePicker LensFile) {}
	///<summary>Set the LensFile used by this component</summary>
	public void SetLensFile(ULensFile LensFile) {}
	///<summary>Get the evaluation mode used to evaluate the LensFile</summary>
	public EFIZEvaluationMode GetFIZEvaluationMode() { return default; }
	///<summary>Set the evaluation mode used to evaluate the LensFile</summary>
	public void SetFIZEvaluationMode(EFIZEvaluationMode Mode) {}
	///<summary>Get the evaluation mode used to evaluate the LensFile</summary>
	public float GetOverscanMultiplier() { return default; }
	///<summary>Set the LensFile used by this component</summary>
	public void SetOverscanMultiplier(float Multiplier) {}
	///<summary>Get the filmback override setting</summary>
	public EFilmbackOverrideSource GetFilmbackOverrideSetting() { return default; }
	///<summary>Set the filmback override setting</summary>
	public void SetFilmbackOverrideSetting(EFilmbackOverrideSource Setting) {}
	///<summary>Get the cropped filmback (only relevant if the filmback override setting is set to use the CroppedFilmback</summary>
	public FCameraFilmbackSettings GetCroppedFilmback() { return default; }
	///<summary>Set the cropped filmback (only relevant if the filmback override setting is set to use the CroppedFilmback</summary>
	public void SetCroppedFilmback(FCameraFilmbackSettings Filmback) {}
	///<summary>Returns true if nodal offset will be automatically applied during this component&#39;s tick, false otherwise</summary>
	public bool ShouldApplyNodalOffsetOnTick() { return default; }
	///<summary>Set whether nodal offset should be automatically applied during this component&#39;s tick</summary>
	public void SetApplyNodalOffsetOnTick(bool bApplyNodalOffset) {}
	///<summary>Get the distortion source setting</summary>
	public EDistortionSource GetDistortionSource() { return default; }
	///<summary>Set the distortion source setting</summary>
	public void SetDistortionSource(EDistortionSource Source) {}
	///<summary>Whether distortion should be applied to the target camera</summary>
	public bool ShouldApplyDistortion() { return default; }
	///<summary>Set whether distortion should be applied to the target camera</summary>
	public void SetApplyDistortion(bool bApply) {}
	///<summary>Get the current lens model</summary>
	public UClass GetLensModel() { return default; }
	///<summary>Set the current lens model</summary>
	public void SetLensModel(UClass Model) {}
	///<summary>Get the current distortion state</summary>
	public FLensDistortionState GetDistortionState() { return default; }
	///<summary>Set the current distortion state</summary>
	public void SetDistortionState(FLensDistortionState State) {}
	///<summary>Reset the distortion state to defaults to represent &quot;no distortion&quot;</summary>
	public void ClearDistortionState() {}
	///<summary>Get the original (not adjusted for overscan) focal length of the camera</summary>
	public float GetOriginalFocalLength() { return default; }
	///<summary>Get the data used by this component to evaluate the LensFile</summary>
	public FLensFileEvaluationInputs GetLensFileEvaluationInputs() { return default; }
	///<summary>Returns true if nodal offset was applied during the current tick, false otherwise</summary>
	public bool WasNodalOffsetAppliedThisTick() { return default; }
	///<summary>Returns true if distortion was evaluated this tick</summary>
	public bool WasDistortionEvaluated() { return default; }
	///<summary>Manually apply nodal offset to the specified component.</summary>
	public void ApplyNodalOffset(USceneComponent ComponentToOffset,bool bUseManualInputs/*=false*/,float ManualFocusInput/*=0.0f*/,float ManualZoomInput/*=0.0f*/) {}
	///<summary>Lens File used to drive distortion with current camera settings</summary>
	public FLensFilePicker LensFilePicker;
	///<summary>Specify how the Lens File should be evaluated</summary>
	public EFIZEvaluationMode EvaluationMode;
	///<summary>The CineCameraComponent on which to apply the post-process distortion effect</summary>
	public FComponentReference TargetCameraComponent;
	///<summary>Inputs to LensFile evaluation</summary>
	public FLensFileEvaluationInputs EvalInputs;
	///<summary>Specifies from where the distortion state information comes</summary>
	public EDistortionSource DistortionStateSource;
	///<summary>Whether or not to apply distortion to the target camera component</summary>
	public bool bApplyDistortion;
	///<summary>The current lens model used for distortion</summary>
	public UClass LensModel;
	///<summary>The current distortion state</summary>
	public FLensDistortionState DistortionState;
	///<summary>Whether to scale the computed overscan by the overscan percentage</summary>
	public bool bScaleOverscan;
	///<summary>The percentage of the computed overscan that should be applied to the target camera</summary>
	public float OverscanMultiplier;
	///<summary>Controls whether this component can override the camera&#39;s filmback, and if so, which override to use</summary>
	public EFilmbackOverrideSource FilmbackOverride;
	///<summary>Cropped filmback to use if the filmback override settings are set to use it</summary>
	public FCameraFilmbackSettings CroppedFilmback;
	///<summary>If checked, nodal offset will be applied automatically when this component ticks.</summary>
	public bool bApplyNodalOffsetOnTick;
	///<summary>Serialized transform of the TrackedComponent prior to nodal offset being applied</summary>
	public FTransform OriginalTrackedComponentTransform;
	///<summary>Whether a distortion effect is currently being applied to the target camera component</summary>
	public bool bIsDistortionSetup;
	///<summary>Focal length of the target camera before any overscan has been applied</summary>
	public float OriginalFocalLength;
	///<summary>Cached MID last applied to the target camera</summary>
	public UMaterialInstanceDynamic LastDistortionMID;
	///<summary>Cached most recent target camera, used to clean up the old camera when the user changes the target</summary>
	public UCineCameraComponent LastCameraComponent;
	///<summary>Map of lens models to handlers</summary>
	public TMap<UClass,ULensDistortionModelHandlerBase> LensDistortionHandlerMap;
	///<summary>Scene component that should have nodal offset applied</summary>
	public TWeakObjectPtr<USceneComponent> TrackedComponent;
	///<summary>Serialized name of the TrackedComponent, used to determine which component to re-apply nodal offset to in spawnables</summary>
	public string TrackedComponentName;
	///<summary>OriginalCameraRotation_DEPRECATED</summary>
	public FRotator OriginalCameraRotation_DEPRECATED;
	///<summary>OriginalCameraLocation_DEPRECATED</summary>
	public FVector OriginalCameraLocation_DEPRECATED;
	///<summary>DistortionSource_DEPRECATED</summary>
	public FDistortionHandlerPicker DistortionSource_DEPRECATED;
}
