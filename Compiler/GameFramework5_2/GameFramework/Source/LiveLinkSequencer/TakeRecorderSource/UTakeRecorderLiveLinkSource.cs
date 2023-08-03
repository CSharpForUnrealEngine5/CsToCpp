#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A recording source that records LiveLink</summary>
[CppInclude("TakeRecorderSource/TakeRecorderLiveLinkSource.h")]
public partial class UTakeRecorderLiveLinkSource : UTakeRecorderSource {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to perform key-reduction algorithms as part of the recording</summary>
	public bool bReduceKeys;
	///<summary>Name of the subject to record</summary>
	public string SubjectName;
	///<summary>Whether we should save subject settings in the the live link section. If not, we&#39;ll create one with subject information with no settings</summary>
	public bool bSaveSubjectSettings;
	///<summary>If true we use timecode even if not synchronized, else we use world time</summary>
	public bool bUseSourceTimecode;
	///<summary>If true discard livelink samples with timecode that occurs before the start of recording</summary>
	public bool bDiscardSamplesBeforeStart;
	///<summary>The track recorder we created.</summary>
	public UMovieSceneLiveLinkTrackRecorder TrackRecorder;
}
