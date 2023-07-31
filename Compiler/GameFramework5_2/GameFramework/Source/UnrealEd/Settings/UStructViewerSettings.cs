#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Struct Viewer&#39;s loading and saving settings.</summary>
[CppInclude("Settings/StructViewerSettings.h")]
public partial class UStructViewerSettings : UObject {
	///<summary>Whether to display internal use structs.</summary>
	public bool DisplayInternalStructs;
	///<summary>The developer folder view modes used in SStructViewer</summary>
	public EStructViewerDeveloperType DeveloperFolderType;
}
