#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneActorReferenceSection.h")]
///<summary>A single actor reference point section</summary>
public partial class UMovieSceneActorReferenceSection : UMovieSceneSection {
// MovieSceneActorReferenceSection
	public FMovieSceneActorReferenceData ActorReferenceData;
	public FIntegralCurve ActorGuidIndexCurve_DEPRECATED;
	public TArray<string> ActorGuidStrings_DEPRECATED;
}
