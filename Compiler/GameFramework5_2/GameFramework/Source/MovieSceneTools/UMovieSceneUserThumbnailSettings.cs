#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneToolsUserSettings.h")]
public partial class UMovieSceneUserThumbnailSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to draw thumbnails or not</summary>
	public bool bDrawThumbnails;
	///<summary>Whether to draw a single thumbnail for this section or as many as can fit</summary>
	public bool bDrawSingleThumbnails;
	///<summary>Size at which to draw thumbnails on thumbnail sections</summary>
	public FIntPoint ThumbnailSize;
	///<summary>Quality to render the thumbnails with</summary>
	public EThumbnailQuality Quality;
}
