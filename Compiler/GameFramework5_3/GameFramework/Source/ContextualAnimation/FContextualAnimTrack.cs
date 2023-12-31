namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimTypes.h")]
public partial struct FContextualAnimTrack {
	public UAnimSequenceBase Animation;
	public float AnimMaxStartTime;
	public bool bRequireFlyingMode;
	public bool bOptional;
	public FContextualAnimAlignmentTrackContainer AlignmentData;
	public FContextualAnimAlignmentTrackContainer IKTargetData;
	public TArray<UContextualAnimSelectionCriterion> SelectionCriteria;
	public FTransform MeshToScene;
	public FName Role;
	public int SectionIdx;
	public int AnimSetIdx;
	public int AnimTrackIdx;
}
