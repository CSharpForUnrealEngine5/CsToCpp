namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a name to class name mapping for adding the named interfaces automatically</summary>
[CppInclude("NamedInterfaces.h")]
public partial struct FNamedInterfaceDef {
	public FName InterfaceName;
	public string InterfaceClassName;
}
