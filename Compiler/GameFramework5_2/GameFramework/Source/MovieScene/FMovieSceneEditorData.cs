namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor only data that needs to be saved between sessions for editing but has no runtime purpose</summary>
[CppInclude("MovieScene.h")]
public partial struct FMovieSceneEditorData {
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
