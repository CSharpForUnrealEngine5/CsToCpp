namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the Class Viewer&#39;s loading and saving settings.</summary>
[CppInclude("Settings/ClassViewerSettings.h")]
public partial class UClassViewerSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>AllowedClasses</summary>
	public TArray<string> AllowedClasses;
	///<summary>Whether to display internal use classes.</summary>
	public bool DisplayInternalClasses;
	///<summary>The developer folder view modes used in SClassViewer</summary>
	public EClassViewerDeveloperType DeveloperFolderType;
}
