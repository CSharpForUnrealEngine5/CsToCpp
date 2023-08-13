namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom output node to write out physical material weights.</summary>
[CppInclude("Materials/MaterialExpressionPhysicalMaterialOutput.h")]
public partial class UMaterialExpressionPhysicalMaterialOutput : UMaterialExpressionCustomOutput {
	public static UClass StaticClass() {return default;}
	///<summary>Array of physical material inputs.</summary>
	public TArray<FPhysicalMaterialTraceInput> Inputs;
}
