#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneBoolSection.h")]
///<summary>A single bool section.</summary>
public partial class UMovieSceneBoolSection : UMovieSceneSection {
// MovieSceneBoolSection
	public bool DefaultValue_DEPRECATED;
	public FMovieSceneBoolChannel BoolCurve;
	public bool bIsExternallyInverted;
}
