namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Named interfaces are a registry of UObjects accessible by an FName key that will persist for the lifetime of the process</summary>
[CppInclude("NamedInterfaces.h")]
public partial class UNamedInterfaces : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Holds the set of registered named interfaces</summary>
	public TArray<FNamedInterface> NamedInterfaces;
	///<summary>The list of named interfaces to automatically create and store</summary>
	public TArray<FNamedInterfaceDef> NamedInterfaceDefs;
}
