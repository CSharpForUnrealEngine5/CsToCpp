#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceAnimSequenceLink.h")]
///<summary>Link To Anim Sequence that we are linked too.</summary>
public partial struct FLevelSequenceAnimSequenceLinkItem {
// LevelSequenceAnimSequenceLinkItem
	public FGuid SkelTrackGuid;
	public FSoftObjectPath PathToAnimSequence;
	public bool bExportTransforms;
	public bool bExportMorphTargets;
	public bool bExportAttributeCurves;
	public bool bExportMaterialCurves;
	public EAnimInterpolationType Interpolation;
	public byte CurveInterpolation;
	public bool bRecordInWorldSpace;
	public bool bEvaluateAllSkeletalMeshComponents;
}
