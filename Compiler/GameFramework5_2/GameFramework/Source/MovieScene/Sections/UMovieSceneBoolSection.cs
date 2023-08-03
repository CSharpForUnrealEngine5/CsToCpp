#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single bool section.</summary>
[CppInclude("Sections/MovieSceneBoolSection.h")]
public partial class UMovieSceneBoolSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>The default value to use when no keys are present - use GetCurve().SetDefaultValue()</summary>
	public bool DefaultValue_DEPRECATED;
	///<summary>Ordered curve data</summary>
	public FMovieSceneBoolChannel BoolCurve;
	///<summary>True if this section represents a property that is the inversion of the values stored on this channel</summary>
	public bool bIsExternallyInverted;
}
