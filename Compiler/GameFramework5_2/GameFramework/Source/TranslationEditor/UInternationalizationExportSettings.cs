#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InternationalizationExportSettings.h")]
public partial class UInternationalizationExportSettings : UObject {
// InternationalizationExportSettings
	public TArray<string> CulturesToGenerate;
	public string CommandletClass;
	public string SourcePath;
	public string DestinationPath;
	public string PortableObjectName;
	public string ManifestName;
	public string ArchiveName;
	public bool bExportLoc;
	public bool bImportLoc;
	public bool bUseCultureDirectory;
}
