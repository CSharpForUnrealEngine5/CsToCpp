#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineCommandLineEncoder.h")]
public partial class UMoviePipelineCommandLineEncoder : UMoviePipelineSetting {
	///<summary>File name format string override. If specified it will override the FileNameFormat from the Output setting.</summary>
	public string FileNameFormatOverride;
	///<summary>What encoding quality to use for this job? Exact command line arguments for each one are specified in Project Settings.</summary>
	public EMoviePipelineEncodeQuality Quality;
	///<summary>Any additional arguments to pass to the CLI encode for this particular job.</summary>
	public string AdditionalCommandLineArgs;
	///<summary>Should we delete the source files from disk after encoding?</summary>
	public bool bDeleteSourceFiles;
	///<summary>If a render was canceled (via hitting escape mid render) should we skip trying to encode the files we did produce?</summary>
	public bool bSkipEncodeOnRenderCanceled;
	///<summary>Write the duration for each frame into the generated text file. Needed for some input types on some CLI encoding software.</summary>
	public bool bWriteEachFrameDuration;
}
