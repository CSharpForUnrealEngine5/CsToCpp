#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Keyframe scale data for one track.  Scale(i) occurs at Time(i).  Rot.Num() always equals Time.Num().</summary>
[CppInclude("Animation/AnimSequence.h")]
public partial struct FScaleTrack {
	public TArray<FVector3f> ScaleKeys;
	public TArray<float> Times;
}
