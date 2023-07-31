#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Class Viewer&#39;s loading and saving settings.</summary>
[CppInclude("Settings/ClassViewerSettings.h")]
public partial class UClassViewerSettings : UObject {
	///<summary>AllowedClasses</summary>
	public TArray<string> AllowedClasses;
	///<summary>Whether to display internal use classes.</summary>
	public bool DisplayInternalClasses;
	///<summary>The developer folder view modes used in SClassViewer</summary>
	public EClassViewerDeveloperType DeveloperFolderType;
}
