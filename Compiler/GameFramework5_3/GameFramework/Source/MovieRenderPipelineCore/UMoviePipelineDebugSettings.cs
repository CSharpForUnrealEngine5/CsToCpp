namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineDebugSettings.h")]
public partial class UMoviePipelineDebugSettings : UMoviePipelineSetting {
	public static UClass StaticClass() {return default;}
	///<summary>If true, we will write all samples that get generated to disk individually. This can be useful for debugging or if you need to accumulate</summary>
	public bool bWriteAllSamples;
	///<summary>If true, automatically trigger RenderDoc to capture rendering information for frames from CaptureStartFrame to CaptureEndFrame, inclusive</summary>
	public bool bCaptureFramesWithRenderDoc;
	///<summary>Used when capturing rendering information with RenderDoc. In Display Rate frames.</summary>
	public int CaptureFrame;
	///<summary>If true, automatically capture an Unreal Insights trace file for the duration of the render.</summary>
	public bool bCaptureUnrealInsightsTrace;
}
