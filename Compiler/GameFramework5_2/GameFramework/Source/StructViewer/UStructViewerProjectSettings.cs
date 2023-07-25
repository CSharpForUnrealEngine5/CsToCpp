#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StructViewerProjectSettings.h")]
///<summary>Implements the settings for the Struct Viewer Project Settings</summary>
public partial class UStructViewerProjectSettings : UObject {
// StructViewerProjectSettings
	public TArray<FDirectoryPath> InternalOnlyPaths;
	public TArray<TSoftObjectPtr<UScriptStruct>> InternalOnlyStructs;
}
