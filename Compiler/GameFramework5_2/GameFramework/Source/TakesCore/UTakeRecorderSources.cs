#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TakeRecorderSources.h")]
///<summary>A list of sources to record for any given take. Stored as meta-data on ULevelSequence through ULevelSequence::FindMetaData<UTakeRecorderSources></summary>
public partial class UTakeRecorderSources : UObject {
// TakeRecorderSources
	public  UTakeRecorderSource AddSource(UClass InSourceType) { return default; }
	public  void RemoveSource(UTakeRecorderSource InSource) {}
	public  TArray<UTakeRecorderSource> GetSourcesCopy() { return default; }
	public  void StartRecordingSource(TArray<UTakeRecorderSource> InSources,FQualifiedFrameTime CurrentFrameTime) {}
	public TArray<UTakeRecorderSource> Sources;
	public TMap<UTakeRecorderSource,ULevelSequence> SourceSubSequenceMap;
	public TArray<UMovieSceneSubSection> ActiveSubSections;
}
