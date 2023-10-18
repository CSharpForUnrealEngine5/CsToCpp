namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProxyTable.h")]
public partial class UProxyTable : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Keys</summary>
	public TArray<FGuid> Keys;
	///<summary>RuntimeValues</summary>
	public TArray<FRuntimeProxyValue> RuntimeValues;
	///<summary>Entries</summary>
	public TArray<FProxyEntry> Entries;
	///<summary>InheritEntriesFrom</summary>
	public TArray<UProxyTable> InheritEntriesFrom;
}
