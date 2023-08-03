#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineCameraSetting.h")]
public partial class UMoviePipelineCameraSetting : UMoviePipelineSetting {
	public static UClass StaticClass() {return default;}
	///<summary>Shutter Timing allows you to bias the timing of your shutter angle to either be before, during, or after</summary>
	public EMoviePipelineShutterTiming ShutterTiming;
	///<summary>Overscan percent allows to render additional pixels beyond the set resolution and can be used in conjunction</summary>
	public float OverscanPercentage;
	///<summary>If true, when a Camera Cut section is found we will also render any other cameras within the same sequence (not parent, nor child sequences though).</summary>
	public bool bRenderAllCameras;
}
