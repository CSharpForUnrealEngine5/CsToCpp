#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Link To Anim Sequence that we are linked too.</summary>
[CppInclude("LevelSequenceAnimSequenceLink.h")]
public partial struct FLevelSequenceAnimSequenceLinkItem {
	public FGuid SkelTrackGuid;
	public FSoftObjectPath PathToAnimSequence;
	public bool bExportTransforms;
	public bool bExportMorphTargets;
	public bool bExportAttributeCurves;
	public bool bExportMaterialCurves;
	public EAnimInterpolationType Interpolation;
	public ERichCurveInterpMode CurveInterpolation;
	public bool bRecordInWorldSpace;
	public bool bEvaluateAllSkeletalMeshComponents;
}
