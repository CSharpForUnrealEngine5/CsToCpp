#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract base class for movie scene animations (C++ version).</summary>
[CppInclude("MovieSceneSequence.h")]
public partial class UMovieSceneSequence : UMovieSceneSignedObject {
	///<summary>Find the first object binding ID associated with the specified tag name (set up through RMB-&gt;Expose on Object bindings from within sequencer)</summary>
	public  FMovieSceneObjectBindingID FindBindingByTag(string InBindingName) { return default; }
	///<summary>Find all object binding IDs associated with the specified tag name (set up through RMB-&gt;Expose on Object bindings from within sequencer)</summary>
	public  TArray<FMovieSceneObjectBindingID> FindBindingsByTag(string InBindingName) { return default; }
	///<summary>Get the earliest timecode source out of all of the movie scene sections contained within this sequence&#39;s movie scene.</summary>
	public  FMovieSceneTimecodeSource GetEarliestTimecodeSource() { return default; }
	///<summary>Serialized compiled data - should only be used through UMovieSceneCompiledDataManager</summary>
	public UMovieSceneCompiledData CompiledData;
	///<summary>The default completion mode for this movie scene when a section&#39;s completion mode is set to project default</summary>
	public EMovieSceneCompletionMode DefaultCompletionMode;
	///<summary>true if the result of GetParentObject is significant in object resolution for LocateBoundObjects.</summary>
	public bool bParentContextsAreSignificant;
	///<summary>When true, this sequence should be compiled as if it is playable directly (outside of a root sequence). When false, various compiled data will be omitted, preventing direct playback at runtime (although will still play as a sub sequence)</summary>
	public bool bPlayableDirectly;
	///<summary>Flags used to define this sequence&#39;s behavior and characteristics</summary>
	public EMovieSceneSequenceFlags SequenceFlags;
}
