#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineCommandLineEncoder.h")]
public partial class UMoviePipelineCommandLineEncoder : UMoviePipelineSetting {
// MoviePipelineCommandLineEncoder
	public string FileNameFormatOverride;
	public EMoviePipelineEncodeQuality Quality;
	public string AdditionalCommandLineArgs;
	public bool bDeleteSourceFiles;
	public bool bSkipEncodeOnRenderCanceled;
	public bool bWriteEachFrameDuration;
}
