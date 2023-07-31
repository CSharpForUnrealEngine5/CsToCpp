#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event section that will trigger its event exactly once, every time it is evaluated.</summary>
[CppInclude("Sections/MovieSceneEventRepeaterSection.h")]
public partial class UMovieSceneEventRepeaterSection : UMovieSceneEventSectionBase {
	///<summary>The event that should be triggered each time this section is evaluated</summary>
	public FMovieSceneEvent Event;
}
