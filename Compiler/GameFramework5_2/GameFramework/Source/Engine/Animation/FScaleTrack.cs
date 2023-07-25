#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimSequence.h")]
///<summary>Keyframe scale data for one track.  Scale(i) occurs at Time(i).  Rot.Num() always equals Time.Num().</summary>
public partial struct FScaleTrack {
// ScaleTrack
	public TArray<FVector3f> ScaleKeys;
	public TArray<float> Times;
}
