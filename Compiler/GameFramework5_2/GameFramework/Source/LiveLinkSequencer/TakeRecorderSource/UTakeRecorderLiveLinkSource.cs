#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TakeRecorderSource/TakeRecorderLiveLinkSource.h")]
///<summary>A recording source that records LiveLink</summary>
public partial class UTakeRecorderLiveLinkSource : UTakeRecorderSource {
// TakeRecorderLiveLinkSource
	public bool bReduceKeys;
	public string SubjectName;
	public bool bSaveSubjectSettings;
	public bool bUseSourceTimecode;
	public bool bDiscardSamplesBeforeStart;
	public UMovieSceneLiveLinkTrackRecorder TrackRecorder;
}
