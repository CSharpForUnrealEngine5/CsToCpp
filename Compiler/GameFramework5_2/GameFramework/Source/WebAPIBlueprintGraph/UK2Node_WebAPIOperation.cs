#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_WebAPIOperation.h")]
public partial class UK2Node_WebAPIOperation : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>The class containing the operation functions, AND is the return type of the latent function.</summary>
	public UClass OperationClass;
	///<summary>The name of the latent function to call to create an operation object.</summary>
	public string LatentFunctionName;
	///<summary>The name of the delegated function to call to create an operation object.</summary>
	public string DelegatedFunctionName;
	///<summary>Latent Action is preferred, but not compatible when used in a function, so allow conversion between the two.</summary>
	public EWebAPIOperationAsyncType OperationAsyncType;
}
