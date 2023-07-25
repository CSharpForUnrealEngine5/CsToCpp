#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimSequence.h")]
///<summary>These two always should go together, but it is not right now.</summary>
public partial struct FAnimSequenceTrackContainer {
// AnimSequenceTrackContainer
	public TArray<FRawAnimSequenceTrack> AnimationTracks;
	public TArray<string> TrackNames;
}
