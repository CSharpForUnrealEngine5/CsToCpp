namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieRenderPipelineDataTypes.h")]
public partial struct FMoviePipelineFormatArgs {
	public TMap<string,string> FilenameArguments;
	public TMap<string,string> FileMetadata;
	public UMoviePipelineExecutorJob InJob;
}
