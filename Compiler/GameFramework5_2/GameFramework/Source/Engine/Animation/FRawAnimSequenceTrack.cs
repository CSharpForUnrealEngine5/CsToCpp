#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Raw keyframe data for one track.Each array will contain either NumFrames elements or 1 element.</summary>
[CppInclude("Animation/AnimTypes.h")]
public partial struct FRawAnimSequenceTrack {
	public TArray<FVector3f> PosKeys;
	public TArray<FQuat4f> RotKeys;
	public TArray<FVector3f> ScaleKeys;
}
