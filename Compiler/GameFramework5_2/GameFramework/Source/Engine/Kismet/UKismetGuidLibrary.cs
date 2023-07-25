#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetGuidLibrary.h")]
public partial class UKismetGuidLibrary : UBlueprintFunctionLibrary {
// KismetGuidLibrary
	public bool EqualEqual_GuidGuid(FGuid A,FGuid B) { return default; }
	public bool NotEqual_GuidGuid(FGuid A,FGuid B) { return default; }
	public bool IsValid_Guid(FGuid InGuid) { return default; }
	public void Invalidate_Guid(FGuid InGuid) {}
	public FGuid NewGuid() { return default; }
	public string Conv_GuidToString(FGuid InGuid) { return default; }
	public void Parse_StringToGuid(string GuidString,FGuid OutGuid,bool Success) {}
}
