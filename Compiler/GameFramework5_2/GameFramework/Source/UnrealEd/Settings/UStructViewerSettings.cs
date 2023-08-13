namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Struct Viewer&#39;s loading and saving settings.</summary>
[CppInclude("Settings/StructViewerSettings.h")]
public partial class UStructViewerSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to display internal use structs.</summary>
	public bool DisplayInternalStructs;
	///<summary>The developer folder view modes used in SStructViewer</summary>
	public EStructViewerDeveloperType DeveloperFolderType;
}
