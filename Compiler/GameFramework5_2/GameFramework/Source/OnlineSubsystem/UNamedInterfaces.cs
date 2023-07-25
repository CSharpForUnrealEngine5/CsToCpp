#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NamedInterfaces.h")]
///<summary>Named interfaces are a registry of UObjects accessible by an FName key that will persist for the lifetime of the process</summary>
public partial class UNamedInterfaces : UObject {
// NamedInterfaces
	public TArray<FNamedInterface> NamedInterfaces;
	public TArray<FNamedInterfaceDef> NamedInterfaceDefs;
}
