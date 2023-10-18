namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generally useful Blueprint/remote functions for Epic Stage App integration.</summary>
[CppInclude("StageAppLibrary.h")]
public partial class UStageAppFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get the current semantic version for the stage app API as a formatted string.</summary>
	public static string GetAPIVersion() { return default; }
	///<summary>Get the port number used to access the remote control web interface for this engine instance.</summary>
	public static int GetRemoteControlWebInterfacePort() { return default; }
}
