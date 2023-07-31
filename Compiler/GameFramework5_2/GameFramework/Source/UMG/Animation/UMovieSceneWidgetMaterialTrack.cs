#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A material track which is specialized for materials which are owned by widget brushes.</summary>
[CppInclude("Animation/MovieSceneWidgetMaterialTrack.h")]
public partial class UMovieSceneWidgetMaterialTrack : UMovieSceneMaterialTrack {
	///<summary>The name of the brush property which will be animated by this track.</summary>
	public TArray<string> BrushPropertyNamePath;
	///<summary>The name of this track, generated from the property name path.</summary>
	public string TrackName;
}
