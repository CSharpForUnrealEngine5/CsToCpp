namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Example UStruct declared in a plugin module</summary>
[CppInclude("MyPluginObject.h")]
public partial struct FMyPluginStruct {
	public string TestString;
}
