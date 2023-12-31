namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editable texture parameter.</summary>
[CppInclude("Materials/MaterialInstance.h")]
public partial struct FTextureParameterValue {
	public FName ParameterName_DEPRECATED;
	public FMaterialParameterInfo ParameterInfo;
	public UTexture ParameterValue;
	public FGuid ExpressionGUID;
}
