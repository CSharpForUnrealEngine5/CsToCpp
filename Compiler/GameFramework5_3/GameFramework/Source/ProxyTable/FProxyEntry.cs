namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProxyTable.h")]
public partial struct FProxyEntry {
	public UProxyAsset Proxy;
	public FName Key;
	public FInstancedStruct ValueStruct;
	public TArray<FProxyStructOutput> OutputStructData;
}
