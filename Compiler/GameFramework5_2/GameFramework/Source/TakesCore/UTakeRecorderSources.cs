#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A list of sources to record for any given take. Stored as meta-data on ULevelSequence through ULevelSequence::FindMetaData&lt;UTakeRecorderSources&gt;</summary>
[CppInclude("TakeRecorderSources.h")]
public partial class UTakeRecorderSources : UObject {
	///<summary>Add a new source to this source list of the templated type</summary>
	public  UTakeRecorderSource AddSource(UClass InSourceType) { return default; }
	///<summary>Remove the specified source from this list</summary>
	public  void RemoveSource(UTakeRecorderSource InSource) {}
	///<summary>Retrieves a copy of the list of sources that are being recorded. This is intended for Blueprint usages which cannot</summary>
	public  TArray<UTakeRecorderSource> GetSourcesCopy() { return default; }
	///<summary>Calls the recording initialization flows on each of the specified sources.</summary>
	public  void StartRecordingSource(TArray<UTakeRecorderSource> InSources,FQualifiedFrameTime CurrentFrameTime) {}
	///<summary>The array of all sources contained within this list</summary>
	public TArray<UTakeRecorderSource> Sources;
	///<summary>Maps each source to the level sequence that was created for that source, or to the root source if a subsequence was not created.</summary>
	public TMap<UTakeRecorderSource,ULevelSequence> SourceSubSequenceMap;
	///<summary>List of sub-sections that we&#39;re recording into. Needed to ensure they&#39;re all the right size at the end without re-adjusting every sub-section in a sequence.</summary>
	public TArray<UMovieSceneSubSection> ActiveSubSections;
}
