namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a named object interface for dynamically bound interfaces</summary>
[CppInclude("NamedInterfaces.h")]
public partial struct FNamedInterface {
	public FName InterfaceName;
	public UObject InterfaceObject;
}
