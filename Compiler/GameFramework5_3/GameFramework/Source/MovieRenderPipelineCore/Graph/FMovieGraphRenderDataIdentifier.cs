namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This data structure can be used to identify what render data a set of pixels represents</summary>
[CppInclude("Graph/MovieGraphRenderDataIdentifier.h")]
public partial struct FMovieGraphRenderDataIdentifier {
	public FName RootBranchName;
	public string RendererName;
	public string SubResourceName;
	public string CameraName;
}
