#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomatedLevelSequenceCapture.h")]
public partial class UAutomatedLevelSequenceCapture : UMovieSceneCapture {
// AutomatedLevelSequenceCapture
	public FSoftObjectPath LevelSequenceAsset;
	public string ShotName;
	public bool bUseCustomStartFrame;
	public FFrameNumber CustomStartFrame;
	public bool bUseCustomEndFrame;
	public FFrameNumber CustomEndFrame;
	public int WarmUpFrameCount;
	public float DelayBeforeWarmUp;
	public float DelayBeforeShotWarmUp;
	public float DelayEveryFrame;
	public ULevelSequenceBurnInOptions BurnInOptions;
	public bool bWriteEditDecisionList;
	public bool bWriteFinalCutProXML;
	public TWeakObjectPtr<ALevelSequenceActor> LevelSequenceActor;
}
