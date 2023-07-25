#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieRenderPipelineDataTypes.h")]
public partial struct FMoviePipelineFormatArgs {
// MoviePipelineFormatArgs
	public TMap<string,string> FilenameArguments;
	public TMap<string,string> FileMetadata;
	public UMoviePipelineExecutorJob InJob;
}
