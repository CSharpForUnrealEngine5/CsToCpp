namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Example of declaring a UObject in a plugin module</summary>
[CppInclude("MyPluginObject.h")]
public partial class UMyPluginObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>MyStruct</summary>
	public FMyPluginStruct MyStruct;
}
