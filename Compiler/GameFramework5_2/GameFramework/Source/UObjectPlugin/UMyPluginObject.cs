#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Example of declaring a UObject in a plugin module</summary>
[CppInclude("MyPluginObject.h")]
public partial class UMyPluginObject : UObject {
	///<summary>MyStruct</summary>
	public FMyPluginStruct MyStruct;
}
