namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneCameraShakeSection.h")]
public partial struct FMovieSceneCameraShakeSectionData {
	public UClass ShakeClass;
	public float PlayScale;
	public ECameraShakePlaySpace PlaySpace;
	public FRotator UserDefinedPlaySpace;
}
