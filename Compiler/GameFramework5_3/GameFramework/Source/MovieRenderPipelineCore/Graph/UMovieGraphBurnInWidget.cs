namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for graph-based level sequence burn-ins.</summary>
[CppInclude("Graph/MovieGraphBurnInWidget.h")]
public partial class UMovieGraphBurnInWidget : UUserWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Called on the first temporal and first spatial sample of each output frame.</summary>
	public void UpdateForGraph(UMovieGraphPipeline InGraphPipeline) {}
}
