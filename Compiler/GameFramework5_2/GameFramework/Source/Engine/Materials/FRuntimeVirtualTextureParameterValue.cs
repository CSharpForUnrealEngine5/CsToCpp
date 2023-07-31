#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editable runtime virtual texture parameter.</summary>
[CppInclude("Materials/MaterialInstance.h")]
public partial struct FRuntimeVirtualTextureParameterValue {
	public FMaterialParameterInfo ParameterInfo;
	public URuntimeVirtualTexture ParameterValue;
	public FGuid ExpressionGUID;
}
