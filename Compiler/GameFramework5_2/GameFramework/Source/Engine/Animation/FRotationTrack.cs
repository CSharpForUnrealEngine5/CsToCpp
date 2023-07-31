#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Keyframe rotation data for one track.  Rot(i) occurs at Time(i).  Rot.Num() always equals Time.Num().</summary>
[CppInclude("Animation/AnimSequence.h")]
public partial struct FRotationTrack {
	public TArray<FQuat4f> RotKeys;
	public TArray<float> Times;
}
