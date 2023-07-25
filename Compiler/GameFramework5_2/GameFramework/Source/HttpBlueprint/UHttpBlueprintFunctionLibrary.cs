#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HttpBlueprintFunctionLibrary.h")]
public partial class UHttpBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
// HttpBlueprintFunctionLibrary
	public void MakeRequestHeader(TMap<string,string> Headers,FHttpHeader OutHeader) {}
	public bool GetHeaderValue(FHttpHeader HeaderObject,string HeaderName,string OutHeaderValue) { return default; }
	public TArray<string> GetAllHeaders(FHttpHeader HeaderObject) { return default; }
	public TMap<string,string> GetAllHeaders_Map(FHttpHeader HeaderObject) { return default; }
	public void AddHeader(FHttpHeader HeaderObject,string NewHeader,string NewHeaderValue) {}
	public bool RemoveHeader(FHttpHeader HeaderObject,string HeaderToRemove) { return default; }
}
