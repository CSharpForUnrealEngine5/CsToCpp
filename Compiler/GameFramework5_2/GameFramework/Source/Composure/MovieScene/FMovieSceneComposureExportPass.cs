#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Export configuration options for a single internal pass on an ACompositingElement, or its output pass (where TransformPassName is None)</summary>
[CppInclude("MovieScene/MovieSceneComposureExportTrack.h")]
public partial struct FMovieSceneComposureExportPass {
	public string TransformPassName;
	public bool bRenamePass;
	public string ExportedAs;
}
