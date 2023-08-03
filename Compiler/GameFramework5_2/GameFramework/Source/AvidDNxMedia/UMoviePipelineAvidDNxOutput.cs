#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Forward Declare</summary>
[CppInclude("MoviePipelineAvidDNxOutput.h")]
public partial class UMoviePipelineAvidDNxOutput : UMoviePipelineVideoOutputBase {
	public static UClass StaticClass() {return default;}
	///<summary>Should we use a lossy compression for the output?</summary>
	public bool bUseCompression;
	///<summary>How many threads should the AvidDNx Encoders use to encode frames?</summary>
	public int NumberOfEncodingThreads;
}
