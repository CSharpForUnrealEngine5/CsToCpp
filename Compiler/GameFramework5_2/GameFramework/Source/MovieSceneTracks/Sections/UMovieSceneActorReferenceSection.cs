namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single actor reference point section</summary>
[CppInclude("Sections/MovieSceneActorReferenceSection.h")]
public partial class UMovieSceneActorReferenceSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>ActorReferenceData</summary>
	public FMovieSceneActorReferenceData ActorReferenceData;
	///<summary>Curve data</summary>
	public FIntegralCurve ActorGuidIndexCurve_DEPRECATED;
	///<summary>ActorGuidStrings_DEPRECATED</summary>
	public TArray<string> ActorGuidStrings_DEPRECATED;
}
