namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Keyframe position data for one track.  Pos(i) occurs at Time(i).  Pos.Num() always equals Time.Num().</summary>
[CppInclude("Animation/AnimSequence.h")]
public partial struct FTranslationTrack {
	public TArray<FVector3f> PosKeys;
	public TArray<float> Times;
}
