#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editable sparse volume texture parameter.</summary>
[CppInclude("Materials/MaterialInstance.h")]
public partial struct FSparseVolumeTextureParameterValue {
	public FMaterialParameterInfo ParameterInfo;
	public USparseVolumeTexture ParameterValue;
	public FGuid ExpressionGUID;
}
