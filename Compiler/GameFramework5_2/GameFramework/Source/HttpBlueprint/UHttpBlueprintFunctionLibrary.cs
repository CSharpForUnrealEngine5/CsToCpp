#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HttpBlueprintFunctionLibrary.h")]
public partial class UHttpBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// HttpBlueprintFunctionLibrary
	public static void MakeRequestHeader(TMap<string,string> Headers,FHttpHeader OutHeader) {}
	public static bool GetHeaderValue(FHttpHeader HeaderObject,string HeaderName,string OutHeaderValue) { return default; }
	public static TArray<string> GetAllHeaders(FHttpHeader HeaderObject) { return default; }
	public static TMap<string,string> GetAllHeaders_Map(FHttpHeader HeaderObject) { return default; }
	public static void AddHeader(FHttpHeader HeaderObject,string NewHeader,string NewHeaderValue) {}
	public static bool RemoveHeader(FHttpHeader HeaderObject,string HeaderToRemove) { return default; }
}
