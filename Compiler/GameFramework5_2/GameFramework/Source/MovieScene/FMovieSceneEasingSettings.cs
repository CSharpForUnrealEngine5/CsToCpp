#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneSection.h")]
public partial struct FMovieSceneEasingSettings {
	public int AutoEaseInDuration;
	public int AutoEaseOutDuration;
	public object /*EaseIn*/ EaseIn;
	public bool bManualEaseIn;
	public int ManualEaseInDuration;
	public object /*EaseOut*/ EaseOut;
	public bool bManualEaseOut;
	public int ManualEaseOutDuration;
	public float AutoEaseInTime_DEPRECATED;
	public float AutoEaseOutTime_DEPRECATED;
	public float ManualEaseInTime_DEPRECATED;
	public float ManualEaseOutTime_DEPRECATED;
}
