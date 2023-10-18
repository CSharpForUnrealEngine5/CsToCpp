namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InternationalizationExportSettings.h")]
public partial class UInternationalizationExportSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Which cultures should be exported</summary>
	public TArray<string> CulturesToGenerate;
	///<summary>The commandlet to run</summary>
	public string CommandletClass;
	///<summary>Source for the localization data</summary>
	public string SourcePath;
	///<summary>Destination for the localization data</summary>
	public string DestinationPath;
	///<summary>Filename for the Portable Object format file</summary>
	public string PortableObjectName;
	///<summary>Name of the manifest file</summary>
	public string ManifestName;
	///<summary>Name of the archive file</summary>
	public string ArchiveName;
	///<summary>Whether or not to export localization data</summary>
	public bool bExportLoc;
	///<summary>Whether or not to import localization data</summary>
	public bool bImportLoc;
	///<summary>Whether or not to use culture path</summary>
	public bool bUseCultureDirectory;
}
