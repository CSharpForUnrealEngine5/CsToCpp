#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specifies a source for DataRegistry items, which is an interface that provides asynchronous access to individual structs</summary>
[CppInclude("DataRegistrySource.h")]
public partial class UDataRegistrySource : UObject {
	///<summary>What data source we were created from, if this is a transient source</summary>
	public UDataRegistrySource ParentSource;
}
