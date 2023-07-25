#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProxyTable.h")]
public partial class UProxyTable : UObject {
// ProxyTable
	public TArray<FProxyEntry> Entries;
	public TArray<UProxyTable> InheritEntriesFrom;
}
