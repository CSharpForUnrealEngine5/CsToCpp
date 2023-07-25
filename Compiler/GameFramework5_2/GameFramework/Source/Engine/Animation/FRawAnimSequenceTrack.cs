#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimTypes.h")]
///<summary>Raw keyframe data for one track.Each array will contain either NumFrames elements or 1 element.</summary>
public partial struct FRawAnimSequenceTrack {
// RawAnimSequenceTrack
	public TArray<FVector3f> PosKeys;
	public TArray<FQuat4f> RotKeys;
	public TArray<FVector3f> ScaleKeys;
}
