namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specifies a source for DataRegistry items, which is an interface that provides asynchronous access to individual structs</summary>
[CppInclude("DataRegistrySource.h")]
public partial class UDataRegistrySource : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>What data source we were created from, if this is a transient source</summary>
	public UDataRegistrySource ParentSource;
}
