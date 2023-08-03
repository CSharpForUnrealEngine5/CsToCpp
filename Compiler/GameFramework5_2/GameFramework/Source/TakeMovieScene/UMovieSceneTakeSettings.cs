#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Universal take recorder settings that apply to a whole take</summary>
[CppInclude("MovieSceneTakeSettings.h")]
public partial class UMovieSceneTakeSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Hours Name</summary>
	public string HoursName;
	///<summary>Minutes Name</summary>
	public string MinutesName;
	///<summary>Seconds Name</summary>
	public string SecondsName;
	///<summary>Frames Name</summary>
	public string FramesName;
	///<summary>SubFrames Name</summary>
	public string SubFramesName;
	///<summary>Slate Name</summary>
	public string SlateName;
}
