#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageAppLibrary.h")]
///<summary>Generally useful Blueprint/remote functions for Epic Stage App integration.</summary>
public partial class UStageAppFunctionLibrary : UBlueprintFunctionLibrary {
// StageAppFunctionLibrary
	public static string GetAPIVersion() { return default; }
	public static int GetRemoteControlWebInterfacePort() { return default; }
}
