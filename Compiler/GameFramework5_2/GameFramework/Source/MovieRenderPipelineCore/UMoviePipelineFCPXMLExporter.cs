#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MoviePipelineFCPXMLExporterSetting.h")]
public partial class UMoviePipelineFCPXMLExporter : UMoviePipelineOutputBase {
	///<summary>File name format string override. If specified it will override the FileNameFormat from the Output setting. Can include folder prefixes, and format string tags ({sequence_name}, etc.)</summary>
	public string FileNameFormatOverride;
	///<summary>Whether to build the FCPXML from sequence data directly (for reimporting) or from actual frame output data (for post processing)</summary>
	public FCPXMLExportDataSource DataSource;
}
