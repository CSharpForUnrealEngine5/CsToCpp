#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the Struct Viewer Project Settings</summary>
[CppInclude("StructViewerProjectSettings.h")]
public partial class UStructViewerProjectSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The base directories to be considered Internal Only for the struct picker.</summary>
	public TArray<FDirectoryPath> InternalOnlyPaths;
	///<summary>The base classes to be considered Internal Only for the struct picker.</summary>
	public TArray<TSoftObjectPtr<UScriptStruct>> InternalOnlyStructs;
}
