#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Exporters/AnimSeqExportOption.h")]
public partial class UAnimSeqExportOption : UObject {
// AnimSeqExportOption
	public bool bExportTransforms;
	public bool bExportMorphTargets;
	public bool bExportAttributeCurves;
	public bool bExportMaterialCurves;
	public bool bRecordInWorldSpace;
	public bool bEvaluateAllSkeletalMeshComponents;
	public EAnimInterpolationType Interpolation;
	public ERichCurveInterpMode CurveInterpolation;
	public TArray<string> IncludeAnimationNames;
	public TArray<string> ExcludeAnimationNames;
	public FFrameNumber WarmUpFrames;
	public FFrameNumber DelayBeforeStart;
	public bool bTransactRecording;
}
