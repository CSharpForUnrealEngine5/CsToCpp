#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A context object store allows tools to get access to arbitrary objects which expose data or APIs to enable additional functionality.</summary>
[CppInclude("ContextObjectStore.h")]
public partial class UContextObjectStore : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>ContextObjects</summary>
	public TArray<UObject> ContextObjects;
}
