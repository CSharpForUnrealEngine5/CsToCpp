#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom output node to write out physical material weights.</summary>
[CppInclude("Materials/MaterialExpressionLandscapePhysicalMaterialOutput.h")]
public partial class UMaterialExpressionLandscapePhysicalMaterialOutput : UMaterialExpressionCustomOutput {
	///<summary>Array of physical material inputs.</summary>
	public TArray<FPhysicalMaterialInput> Inputs;
}
