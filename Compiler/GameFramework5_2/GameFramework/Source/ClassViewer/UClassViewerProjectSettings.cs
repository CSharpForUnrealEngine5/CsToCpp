#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the Class Viewer Project Settings</summary>
[CppInclude("ClassViewerProjectSettings.h")]
public partial class UClassViewerProjectSettings : UObject {
	///<summary>The base directories to be considered Internal Only for the class picker.</summary>
	public TArray<FDirectoryPath> InternalOnlyPaths;
	///<summary>The base classes to be considered Internal Only for the class picker.</summary>
	public TArray<FSoftClassPath> InternalOnlyClasses;
}
