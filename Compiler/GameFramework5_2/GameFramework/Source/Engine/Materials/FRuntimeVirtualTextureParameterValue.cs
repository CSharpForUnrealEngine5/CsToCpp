namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editable runtime virtual texture parameter.</summary>
[CppInclude("Materials/MaterialInstance.h")]
public partial struct FRuntimeVirtualTextureParameterValue {
	public FMaterialParameterInfo ParameterInfo;
	public URuntimeVirtualTexture ParameterValue;
	public FGuid ExpressionGUID;
}
