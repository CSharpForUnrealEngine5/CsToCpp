#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialInstance.h")]
///<summary>Editable texture parameter.</summary>
public partial struct FTextureParameterValue {
// TextureParameterValue
	public string ParameterName_DEPRECATED;
	public FMaterialParameterInfo ParameterInfo;
	public UTexture ParameterValue;
	public FGuid ExpressionGUID;
}
