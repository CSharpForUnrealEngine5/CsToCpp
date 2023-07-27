#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReflexBlueprint.h")]
public partial class UReflexBlueprintLibrary : UBlueprintFunctionLibrary {
// ReflexBlueprintLibrary
	public static bool GetReflexAvailable() { return default; }
	public static void SetReflexMode(EReflexMode Mode) {}
	public static EReflexMode GetReflexMode() { return default; }
	public static void SetFlashIndicatorEnabled(bool bEnabled) {}
	public static bool GetFlashIndicatorEnabled() { return default; }
	public static float GetGameToRenderLatencyInMs() { return default; }
	public static float GetGameLatencyInMs() { return default; }
	public static float GetRenderLatencyInMs() { return default; }
}
