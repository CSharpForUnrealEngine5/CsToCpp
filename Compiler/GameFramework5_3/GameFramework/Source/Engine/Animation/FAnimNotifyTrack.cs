namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Keyframe position data for one track.  Pos(i) occurs at Time(i).  Pos.Num() always equals Time.Num().</summary>
[CppInclude("Animation/AnimTypes.h")]
public partial struct FAnimNotifyTrack {
	public FName TrackName;
	public FLinearColor TrackColor;
}
