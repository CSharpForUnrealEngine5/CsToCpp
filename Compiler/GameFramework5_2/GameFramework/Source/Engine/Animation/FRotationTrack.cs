#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimSequence.h")]
///<summary>Keyframe rotation data for one track.  Rot(i) occurs at Time(i).  Rot.Num() always equals Time.Num().</summary>
public partial struct FRotationTrack {
// RotationTrack
	public TArray<FQuat4f> RotKeys;
	public TArray<float> Times;
}
