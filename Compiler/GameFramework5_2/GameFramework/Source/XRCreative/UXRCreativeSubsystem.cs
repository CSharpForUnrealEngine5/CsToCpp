namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeSubsystem.h")]
public partial class UXRCreativeSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Enter VR Mode</summary>
	public static bool EnterVRMode() { return default; }
	///<summary>Exit VR Mode</summary>
	public static void ExitVRMode() {}
	///<summary>Helpers</summary>
	public UXRCreativeSubsystemHelpers Helpers;
}
