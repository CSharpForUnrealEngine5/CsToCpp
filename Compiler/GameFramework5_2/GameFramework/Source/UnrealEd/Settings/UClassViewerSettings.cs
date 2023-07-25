#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/ClassViewerSettings.h")]
///<summary>Implements the Class Viewer's loading and saving settings.</summary>
public partial class UClassViewerSettings : UObject {
// ClassViewerSettings
	public TArray<string> AllowedClasses;
	public bool DisplayInternalClasses;
	public EClassViewerDeveloperType DeveloperFolderType;
}
