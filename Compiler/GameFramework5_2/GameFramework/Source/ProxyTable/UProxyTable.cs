namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProxyTable.h")]
public partial class UProxyTable : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Entries</summary>
	public TArray<FProxyEntry> Entries;
	///<summary>InheritEntriesFrom</summary>
	public TArray<UProxyTable> InheritEntriesFrom;
}
