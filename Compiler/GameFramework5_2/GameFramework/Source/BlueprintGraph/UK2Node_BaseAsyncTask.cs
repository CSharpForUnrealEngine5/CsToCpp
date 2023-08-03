#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>!!! The proxy object should have RF_StrongRefOnFrame flag. !!!</summary>
[CppInclude("K2Node_BaseAsyncTask.h")]
public partial class UK2Node_BaseAsyncTask : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the function to call to create a proxy object</summary>
	public string ProxyFactoryFunctionName;
	///<summary>The class containing the proxy object functions</summary>
	public UClass ProxyFactoryClass;
	///<summary>The type of proxy object that will be created</summary>
	public UClass ProxyClass;
	///<summary>The name of the &#39;go&#39; function on the proxy object that will be called after delegates are in place, can be NAME_None</summary>
	public string ProxyActivateFunctionName;
}
