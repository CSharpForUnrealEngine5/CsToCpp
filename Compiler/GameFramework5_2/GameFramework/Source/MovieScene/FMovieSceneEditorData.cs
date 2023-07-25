#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieScene.h")]
///<summary>Editor only data that needs to be saved between sessions for editing but has no runtime purpose</summary>
public partial struct FMovieSceneEditorData {
// MovieSceneEditorData
	public TMap<string,FMovieSceneExpansionState> ExpansionStates;
	public TArray<string> PinnedNodes;
	public double ViewStart;
	public double ViewEnd;
	public double WorkStart;
	public double WorkEnd;
	public TSet<FFrameNumber> MarkedFrames_DEPRECATED;
	public FFloatRange WorkingRange_DEPRECATED;
	public FFloatRange ViewRange_DEPRECATED;
}
