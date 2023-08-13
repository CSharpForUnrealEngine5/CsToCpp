namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusNodeLink.h")]
public partial class UOptimusNodeLink : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>NodeOutputPin</summary>
	public UOptimusNodePin NodeOutputPin;
	///<summary>NodeInputPin</summary>
	public UOptimusNodePin NodeInputPin;
}
