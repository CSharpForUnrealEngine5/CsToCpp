#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieScene/MovieSceneComposureExportTrack.h")]
///<summary>Export configuration options for a single internal pass on an ACompositingElement, or its output pass (where TransformPassName is None)</summary>
public partial struct FMovieSceneComposureExportPass {
// MovieSceneComposureExportPass
	public string TransformPassName;
	public bool bRenamePass;
	public string ExportedAs;
}
