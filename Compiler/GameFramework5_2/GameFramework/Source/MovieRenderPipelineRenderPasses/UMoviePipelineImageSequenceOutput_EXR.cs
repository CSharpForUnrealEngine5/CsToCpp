namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineEXROutput.h")]
public partial class UMoviePipelineImageSequenceOutput_EXR : UMoviePipelineImageSequenceOutputBase {
	public static UClass StaticClass() {return default;}
	///<summary>Which compression method should the resulting EXR file be compressed with</summary>
	public EEXRCompressionFormat Compression;
	///<summary>Should we write all render passes to the same exr file? Not all software supports multi-layer exr files.</summary>
	public bool bMultilayer;
}
