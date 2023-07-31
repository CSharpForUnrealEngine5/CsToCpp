#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Keyframe position data for one track.  Pos(i) occurs at Time(i).  Pos.Num() always equals Time.Num().</summary>
[CppInclude("Animation/AnimTypes.h")]
public partial struct FAnimNotifyTrack {
	public string TrackName;
	public FLinearColor TrackColor;
}
