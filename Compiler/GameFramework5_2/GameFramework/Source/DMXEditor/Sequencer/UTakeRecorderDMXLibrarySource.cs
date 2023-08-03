#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A recording source for DMX data related to a DMX Library</summary>
[CppInclude("Sequencer/TakeRecorderDMXLibrarySource.h")]
public partial class UTakeRecorderDMXLibrarySource : UTakeRecorderSource {
	public static UClass StaticClass() {return default;}
	///<summary>DMX Library to record Patches&#39; Fixture Functions from</summary>
	public UDMXLibrary DMXLibrary;
	///<summary>Dummy property to be replaced with the &quot;Add all patches&quot; button.</summary>
	public FAddAllPatchesButton AddAllPatchesDummy;
	///<summary>The Fixture Patches to record from the selected Library</summary>
	public TArray<FDMXEntityFixturePatchRef> FixturePatchRefs;
	///<summary>If true, all values are recorded as normalized values (0.0 to 1.0).</summary>
	public bool bRecordNormalizedValues;
	///<summary>Adds all Patches from the active DMX Library as recording sources</summary>
	public  void AddAllPatches() {}
	///<summary>Track recorder used by this source</summary>
	public UMovieSceneDMXLibraryTrackRecorder TrackRecorder;
}
