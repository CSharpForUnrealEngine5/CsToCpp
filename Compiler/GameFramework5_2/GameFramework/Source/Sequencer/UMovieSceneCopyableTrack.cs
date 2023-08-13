namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneCopyableTrack.h")]
public partial class UMovieSceneCopyableTrack : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Track</summary>
	public UMovieSceneTrack Track;
	///<summary>bIsRootTrack</summary>
	public bool bIsRootTrack;
	///<summary>bIsCameraCutTrack</summary>
	public bool bIsCameraCutTrack;
	///<summary>FolderPath</summary>
	public TArray<string> FolderPath;
}
