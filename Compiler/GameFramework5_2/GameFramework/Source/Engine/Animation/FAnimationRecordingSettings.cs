#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimationRecordingSettings.h")]
///<summary>Settings describing how to record an animation</summary>
public partial struct FAnimationRecordingSettings {
// AnimationRecordingSettings
	public bool bRecordInWorldSpace;
	public bool bRemoveRootAnimation;
	public bool bAutoSaveAsset;
	public FFrameRate SampleFrameRate;
	public float Length;
	public EAnimInterpolationType Interpolation;
	public byte InterpMode;
	public byte TangentMode;
	public bool bRecordTransforms;
	public bool bRecordMorphTargets;
	public bool bRecordAttributeCurves;
	public bool bRecordMaterialCurves;
	public bool bTransactRecording;
	public TArray<string> IncludeAnimationNames;
	public TArray<string> ExcludeAnimationNames;
}
