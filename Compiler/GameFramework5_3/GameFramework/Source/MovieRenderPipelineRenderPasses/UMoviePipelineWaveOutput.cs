namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineWaveOutput.h")]
public partial class UMoviePipelineWaveOutput : UMoviePipelineOutputBase {
	public static UClass StaticClass() {return default;}
	///<summary>File name format string override. If specified it will override the FileNameFormat from the Output setting.</summary>
	public string FileNameFormatOverride;
}
