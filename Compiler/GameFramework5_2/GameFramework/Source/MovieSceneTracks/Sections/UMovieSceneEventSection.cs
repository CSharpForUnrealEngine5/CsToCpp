namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a section in movie scene event tracks.</summary>
[CppInclude("Sections/MovieSceneEventSection.h")]
public partial class UMovieSceneEventSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>Events_DEPRECATED</summary>
	public FNameCurve Events_DEPRECATED;
	///<summary>EventData</summary>
	public FMovieSceneEventSectionData EventData;
}
