#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineCommandLineEncoderSettings.h")]
public partial class UMoviePipelineCommandLineEncoderSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Path to the executable (including extension). Can just be &quot;ffmpeg.exe&quot; if it can be located via PATH directories.</summary>
	public string ExecutablePath;
	///<summary>CodecHelpText</summary>
	public string CodecHelpText;
	///<summary>Which video codec should we use? Run &#39;MovieRenderPipeline.DumpCLIEncoderCodecs&#39; for options.</summary>
	public string VideoCodec;
	///<summary>Which audio codec should we use? Run &#39;MovieRenderPipeline.DumpCLIEncoderCodecs&#39; for options.</summary>
	public string AudioCodec;
	///<summary>Extension for the output files. Many encoders use this to determine the container type they are placed in. Should be without dot, ie: &quot;webm&quot;.</summary>
	public string OutputFileExtension;
	///<summary>The format string used when building the final command line argument to launch.</summary>
	public string CommandLineFormat;
	///<summary>Format string used for each video input.</summary>
	public string VideoInputStringFormat;
	///<summary>Format string used for each audio input.</summary>
	public string AudioInputStringFormat;
	///<summary>The flags used for low quality encoding.</summary>
	public string EncodeSettings_Low;
	///<summary>The flags used for medium quality encoding.</summary>
	public string EncodeSettings_Med;
	///<summary>The flags used for high quality encoding.</summary>
	public string EncodeSettings_High;
	///<summary>The flags used for epic quality encoding.</summary>
	public string EncodeSettings_Epic;
}
