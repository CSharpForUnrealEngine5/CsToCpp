namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HttpBlueprintFunctionLibrary.h")]
public partial class UHttpBlueprintFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>MakeRequestHeader</summary>
	public static void MakeRequestHeader(TMap<string,string> Headers,FHttpHeader OutHeader) {}
	///<summary>Get the value associated with a Header name</summary>
	public static bool GetHeaderValue(FHttpHeader HeaderObject,string HeaderName,string OutHeaderValue) { return default; }
	///<summary>Returns all of the headers and their values by value</summary>
	public static TArray<string> GetAllHeaders(FHttpHeader HeaderObject) { return default; }
	///<summary>Returns all of the headers and their values as a map by value</summary>
	public static TMap<string,string> GetAllHeaders_Map(FHttpHeader HeaderObject) { return default; }
	///<summary>Adds a new Header</summary>
	public static void AddHeader(FHttpHeader HeaderObject,string NewHeader,string NewHeaderValue) {}
	///<summary>Removes a header from the HeaderObject</summary>
	public static bool RemoveHeader(FHttpHeader HeaderObject,string HeaderToRemove) { return default; }
}
