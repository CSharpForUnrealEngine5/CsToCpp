namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event section that triggeres specific timed events.</summary>
[CppInclude("Sections/MovieSceneEventTriggerSection.h")]
public partial class UMovieSceneEventTriggerSection : UMovieSceneEventSectionBase {
	public static UClass StaticClass() {return default;}
	///<summary>The channel that defines this section&#39;s timed events</summary>
	public FMovieSceneEventChannel EventChannel;
}
