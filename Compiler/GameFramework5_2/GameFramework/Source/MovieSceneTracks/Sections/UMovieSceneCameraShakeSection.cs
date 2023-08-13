namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneCameraShakeSection.h")]
public partial class UMovieSceneCameraShakeSection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>ShakeData</summary>
	public FMovieSceneCameraShakeSectionData ShakeData;
	///<summary>ShakeClass_DEPRECATED</summary>
	public UClass ShakeClass_DEPRECATED;
	///<summary>PlayScale_DEPRECATED</summary>
	public float PlayScale_DEPRECATED;
	///<summary>PlaySpace_DEPRECATED</summary>
	public ECameraShakePlaySpace PlaySpace_DEPRECATED;
	///<summary>UserDefinedPlaySpace_DEPRECATED</summary>
	public FRotator UserDefinedPlaySpace_DEPRECATED;
}
