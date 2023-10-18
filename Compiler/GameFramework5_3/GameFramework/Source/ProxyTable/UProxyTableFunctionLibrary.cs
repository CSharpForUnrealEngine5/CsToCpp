namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Proxy Table Function Library</summary>
[CppInclude("ProxyTableFunctionLibrary.h")]
public partial class UProxyTableFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Temporary backwards compatibility function!  please switch to EvaluateProxyAsset</summary>
	public static UObject EvaluateProxyTable(UObject ContextObject,UProxyTable ProxyTable,FName Key) { return default; }
	///<summary>Resolve a proxy asset and return the selected UObject, or null</summary>
	public static UObject EvaluateProxyAsset(UObject ContextObject,UProxyAsset Proxy,UClass ObjectClass) { return default; }
	///<summary>Create a LookupProxy struct</summary>
	public static FInstancedStruct MakeLookupProxy(UProxyAsset Proxy) { return default; }
	///<summary>MakeLookupProxyWithOverrideTable</summary>
	public static FInstancedStruct MakeLookupProxyWithOverrideTable(UProxyAsset Proxy,UProxyTable ProxyTable) { return default; }
}
