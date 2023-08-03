#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a cinematic shot section.</summary>
[CppInclude("Sections/MovieSceneCinematicShotSection.h")]
public partial class UMovieSceneCinematicShotSection : UMovieSceneSubSection {
	public static UClass StaticClass() {return default;}
	///<summary>@return The shot display name. if empty, returns the sequence&#39;s name</summary>
	public  string GetShotDisplayName() { return default; }
	///<summary>Set the shot display name</summary>
	public  void SetShotDisplayName(string InShotDisplayName) {}
	///<summary>The Shot&#39;s display name</summary>
	public string ShotDisplayName;
	///<summary>The Shot&#39;s display name</summary>
	public string DisplayName_DEPRECATED;
	///<summary>The shot&#39;s reference frame offset for single thumbnail rendering</summary>
	public float ThumbnailReferenceOffset;
}
