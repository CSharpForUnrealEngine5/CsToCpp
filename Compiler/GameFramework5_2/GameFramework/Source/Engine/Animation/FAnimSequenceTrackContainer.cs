namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>These two always should go together, but it is not right now.</summary>
[CppInclude("Animation/AnimSequence.h")]
public partial struct FAnimSequenceTrackContainer {
	public TArray<FRawAnimSequenceTrack> AnimationTracks;
	public TArray<string> TrackNames;
}
