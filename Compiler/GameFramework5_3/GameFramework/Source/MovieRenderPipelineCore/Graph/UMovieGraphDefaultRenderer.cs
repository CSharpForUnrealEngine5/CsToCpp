namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is the default implementation for the Movie Graph Pipeline renderer. This</summary>
[CppInclude("Graph/MovieGraphDefaultRenderer.h")]
public partial class UMovieGraphDefaultRenderer : UMovieGraphRendererBase {
	public static UClass StaticClass() {return default;}
	///<summary>A pointer to the CDOs of the Render Pass nodes that are valid for the current shot render.</summary>
	public TArray<UMovieGraphRenderPassNode> RenderPassesInUse;
}
