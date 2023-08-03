#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for level sequence burn ins</summary>
[CppInclude("MoviePipelineBurnInWidget.h")]
public partial class UMoviePipelineBurnInWidget : UUserWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Called on the first temporal and first spatial sample of each output frame with the information about the frame being produced.</summary>
	public  void OnOutputFrameStarted(UMoviePipeline ForPipeline) {}
}
