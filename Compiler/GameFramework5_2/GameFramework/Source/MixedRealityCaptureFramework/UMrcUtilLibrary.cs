#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MrcUtilLibrary.h")]
public partial class UMrcUtilLibrary : UBlueprintFunctionLibrary {
	///<summary>Return true if the system is sending the capture texture to the spectator screen.</summary>
	public static bool IsMixedRealityCaptureBroadcasting() { return default; }
	///<summary>Toggle whether the capture system is sending the capture texture to the spectator screen or not.</summary>
	public static void SetMixedRealityCaptureBroadcasting(bool bEnable) {}
	///<summary>Return the Capture Texture, or nullptr if there isn&#39;t one.</summary>
	public static UTexture GetMixedRealityCaptureTexture() { return default; }
}
