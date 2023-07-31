#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a named object interface for dynamically bound interfaces</summary>
[CppInclude("NamedInterfaces.h")]
public partial struct FNamedInterface {
	public string InterfaceName;
	public UObject InterfaceObject;
}
