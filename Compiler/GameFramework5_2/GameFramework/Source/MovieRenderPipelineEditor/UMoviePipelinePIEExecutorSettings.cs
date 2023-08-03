#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the implementation responsible for executing the rendering of</summary>
[CppInclude("MoviePipelinePIEExecutorSettings.h")]
public partial class UMoviePipelinePIEExecutorSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>How long should we wait after being initialized to start doing any work? This can be used</summary>
	public int InitialDelayFrameCount;
	///<summary>Should the PIE Window be created at the same resolution as the MRQ Output? By default we create the window at 720p for a nicer</summary>
	public bool bResizePIEWindowToOutputResolution;
}
