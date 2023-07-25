#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimSequence.h")]
///<summary>Keyframe position data for one track.  Pos(i) occurs at Time(i).  Pos.Num() always equals Time.Num().</summary>
public partial struct FTranslationTrack {
// TranslationTrack
	public TArray<FVector3f> PosKeys;
	public TArray<float> Times;
}
