#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/TakeRecorderDMXLibrarySource.h")]
///<summary>A recording source for DMX data related to a DMX Library</summary>
public partial class UTakeRecorderDMXLibrarySource : UTakeRecorderSource {
// TakeRecorderDMXLibrarySource
	public UDMXLibrary DMXLibrary;
	public FAddAllPatchesButton AddAllPatchesDummy;
	public TArray<FDMXEntityFixturePatchRef> FixturePatchRefs;
	public bool bRecordNormalizedValues;
	public void AddAllPatches() {}
	public UMovieSceneDMXLibraryTrackRecorder TrackRecorder;
}
