namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings describing how to record an animation</summary>
[CppInclude("Animation/AnimationRecordingSettings.h")]
public partial struct FAnimationRecordingSettings {
	public bool bRecordInWorldSpace;
	public bool bRemoveRootAnimation;
	public bool bAutoSaveAsset;
	public FFrameRate SampleFrameRate;
	public float Length;
	public EAnimInterpolationType Interpolation;
	public ERichCurveInterpMode InterpMode;
	public ERichCurveTangentMode TangentMode;
	public bool bRecordTransforms;
	public bool bRecordMorphTargets;
	public bool bRecordAttributeCurves;
	public bool bRecordMaterialCurves;
	public bool bTransactRecording;
	public TArray<string> IncludeAnimationNames;
	public TArray<string> ExcludeAnimationNames;
}
