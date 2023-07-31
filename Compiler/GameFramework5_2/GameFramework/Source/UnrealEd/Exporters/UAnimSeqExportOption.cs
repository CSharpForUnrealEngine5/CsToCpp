#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Exporters/AnimSeqExportOption.h")]
public partial class UAnimSeqExportOption : UObject {
	///<summary>If enabled, export the transforms from the animation</summary>
	public bool bExportTransforms;
	///<summary>If enabled, export the morph targets from the animation</summary>
	public bool bExportMorphTargets;
	///<summary>If enabled, export the attribute curves from the animation</summary>
	public bool bExportAttributeCurves;
	///<summary>If enabled, export the material curves from the animation</summary>
	public bool bExportMaterialCurves;
	///<summary>If enabled we record in World Space otherwise we record from 0,0,0</summary>
	public bool bRecordInWorldSpace;
	///<summary>If true we evaluate all other skeletal mesh components under the same actor, this may be needed for example, to get physics to get baked</summary>
	public bool bEvaluateAllSkeletalMeshComponents;
	///<summary>This defines how values between keys are calculated for transforms</summary>
	public EAnimInterpolationType Interpolation;
	///<summary>This defines how values between keys are calculated for curves</summary>
	public ERichCurveInterpMode CurveInterpolation;
	///<summary>Include only the animation bones/curves that match this list</summary>
	public TArray<string> IncludeAnimationNames;
	///<summary>Exclude all animation bones/curves that match this list</summary>
	public TArray<string> ExcludeAnimationNames;
	///<summary>Number of Display Rate frames to evaluate before doing the export. It will evaluate after any Delay. This will use frames before the start frame. Use it if there is some post anim BP effects you want to run before export start time.</summary>
	public FFrameNumber WarmUpFrames;
	///<summary>Number of Display Rate frames to delay at the same frame before doing the export. It will evalaute first, then any warm up, then the export. Use it if there is some post anim BP effects you want to ran repeatedly at the start.</summary>
	public FFrameNumber DelayBeforeStart;
	///<summary>Whether or not to transact the animation sequence data recording</summary>
	public bool bTransactRecording;
}
