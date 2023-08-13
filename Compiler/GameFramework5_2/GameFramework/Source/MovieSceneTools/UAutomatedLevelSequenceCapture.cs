namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AutomatedLevelSequenceCapture.h")]
public partial class UAutomatedLevelSequenceCapture : UMovieSceneCapture {
	public static UClass StaticClass() {return default;}
	///<summary>A level sequence asset to playback at runtime - used where the level sequence does not already exist in the world.</summary>
	public FSoftObjectPath LevelSequenceAsset;
	///<summary>Optional shot name to render. The frame range to render will be set to the shot frame range.</summary>
	public string ShotName;
	///<summary>When enabled, the StartFrame setting will override the default starting frame number</summary>
	public bool bUseCustomStartFrame;
	///<summary>Frame number to start capturing.</summary>
	public FFrameNumber CustomStartFrame;
	///<summary>When enabled, the EndFrame setting will override the default ending frame number</summary>
	public bool bUseCustomEndFrame;
	///<summary>Frame number to end capturing.</summary>
	public FFrameNumber CustomEndFrame;
	///<summary>The number of extra frames to play before the sequence&#39;s start frame, to &quot;warm up&quot; the animation.  This is useful if your</summary>
	public int WarmUpFrameCount;
	///<summary>The number of seconds to wait (in real-time) before we start playing back the warm up frames.  Useful for allowing post processing effects to settle down before capturing the animation.</summary>
	public float DelayBeforeWarmUp;
	///<summary>The number of seconds to wait (in real-time) at shot boundaries.  Useful for allowing post processing effects to settle down before capturing the animation.</summary>
	public float DelayBeforeShotWarmUp;
	///<summary>The number of seconds to wait (in real-time) at every frame.  Useful for allowing post processing effects to settle down before capturing the animation.</summary>
	public float DelayEveryFrame;
	///<summary>BurnInOptions</summary>
	public ULevelSequenceBurnInOptions BurnInOptions;
	///<summary>Whether to write edit decision lists (EDLs) if the sequence contains shots</summary>
	public bool bWriteEditDecisionList;
	///<summary>Whether to write Final Cut Pro XML files (XMLs) if the sequence contains shots</summary>
	public bool bWriteFinalCutProXML;
	///<summary>The pre-existing level sequence actor to use for capture that specifies playback settings</summary>
	public TWeakObjectPtr<ALevelSequenceActor> LevelSequenceActor;
}
