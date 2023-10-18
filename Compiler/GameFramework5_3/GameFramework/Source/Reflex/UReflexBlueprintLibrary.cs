namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ReflexBlueprint.h")]
public partial class UReflexBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetReflexAvailable</summary>
	public static bool GetReflexAvailable() { return default; }
	///<summary>SetReflexMode</summary>
	public static void SetReflexMode(EReflexMode Mode) {}
	///<summary>GetReflexMode</summary>
	public static EReflexMode GetReflexMode() { return default; }
	///<summary>SetFlashIndicatorEnabled</summary>
	public static void SetFlashIndicatorEnabled(bool bEnabled) {}
	///<summary>GetFlashIndicatorEnabled</summary>
	public static bool GetFlashIndicatorEnabled() { return default; }
	///<summary>GetGameToRenderLatencyInMs</summary>
	public static float GetGameToRenderLatencyInMs() { return default; }
	///<summary>GetGameLatencyInMs</summary>
	public static float GetGameLatencyInMs() { return default; }
	///<summary>GetRenderLatencyInMs</summary>
	public static float GetRenderLatencyInMs() { return default; }
}
