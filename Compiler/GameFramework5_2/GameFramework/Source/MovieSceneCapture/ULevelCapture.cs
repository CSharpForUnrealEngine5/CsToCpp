#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelCapture.h")]
public partial class ULevelCapture : UMovieSceneCapture {
	public static UClass StaticClass() {return default;}
	///<summary>Specifies whether the capture should start immediately, or whether it will be invoked externally (through StartMovieCapture/StopMovieCapture exec commands)</summary>
	public bool bAutoStartCapture;
	///<summary>Copy of the ID from PrerequisiteActor. Required because JSON serialization exports the path of the object, rather that its GUID</summary>
	public FGuid PrerequisiteActorId;
}
