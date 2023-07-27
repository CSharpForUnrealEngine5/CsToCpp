#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetGuidLibrary.h")]
public partial class UKismetGuidLibrary : UBlueprintFunctionLibrary {
// KismetGuidLibrary
	public static bool EqualEqual_GuidGuid(FGuid A,FGuid B) { return default; }
	public static bool NotEqual_GuidGuid(FGuid A,FGuid B) { return default; }
	public static bool IsValid_Guid(FGuid InGuid) { return default; }
	public static void Invalidate_Guid(FGuid InGuid) {}
	public static FGuid NewGuid() { return default; }
	public static string Conv_GuidToString(FGuid InGuid) { return default; }
	public static void Parse_StringToGuid(string GuidString,FGuid OutGuid,bool Success) {}
}
