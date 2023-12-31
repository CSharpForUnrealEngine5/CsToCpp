namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>C++ Base Class for the debug widget that is drawn onto the game viewport</summary>
[CppInclude("MovieRenderDebugWidget.h")]
public partial class UMovieRenderDebugWidget : UUserWidget {
	public static UClass StaticClass() {return default;}
	///<summary>OnInitializedForPipeline</summary>
	public void OnInitializedForPipeline(UMoviePipeline ForPipeline) {}
}
