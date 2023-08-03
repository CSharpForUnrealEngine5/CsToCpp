#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class contains the default values of render grid jobs.</summary>
[CppInclude("RenderGrid/RenderGrid.h")]
public partial class URenderGridDefaults : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The default level sequence for new jobs, this is what will be rendered during rendering. A job without a level sequence can&#39;t be rendered.</summary>
	public ULevelSequence LevelSequence;
	///<summary>The default movie pipeline render preset for new jobs. Render grid jobs are rendered using the movie pipeline plugin. This &#39;preset&#39; contains the configuration of that plugin.</summary>
	public UMoviePipelinePrimaryConfig RenderPreset;
	///<summary>The default output directory for new jobs. This is the folder in which the output files (of rendering) are placed into. To be more specific, the output files are placed in: {OutputDirectory}/{JobId}/, this folder will be created if it doesn&#39;t exist at the time of rendering.</summary>
	public string OutputDirectory;
}
