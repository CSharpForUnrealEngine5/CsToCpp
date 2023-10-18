namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Export configuration options for a single internal pass on an ACompositingElement, or its output pass (where TransformPassName is None)</summary>
[CppInclude("MovieScene/MovieSceneComposureExportTrack.h")]
public partial struct FMovieSceneComposureExportPass {
	public FName TransformPassName;
	public bool bRenamePass;
	public FName ExportedAs;
}
