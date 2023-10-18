namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A recording source that records LiveLink</summary>
[CppInclude("TakeRecorderSource/TakeRecorderLiveLinkSource.h")]
public partial class UTakeRecorderLiveLinkSource : UTakeRecorderSource {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to perform key-reduction algorithms as part of the recording</summary>
	public bool bReduceKeys;
	///<summary>Name of the subject to record</summary>
	public FName SubjectName;
	///<summary>Whether we should save subject settings in the the live link section. If not, we&#39;ll create one with subject information with no settings</summary>
	public bool bSaveSubjectSettings;
	///<summary>Whether the livelink subject&#39;s timecode or the system time should be used for the recording.</summary>
	public bool bUseSourceTimecode;
	///<summary>If true discard livelink samples with timecode that occurs before the start of recording</summary>
	public bool bDiscardSamplesBeforeStart;
	///<summary>The track recorder we created.</summary>
	public UMovieSceneLiveLinkTrackRecorder TrackRecorder;
}
