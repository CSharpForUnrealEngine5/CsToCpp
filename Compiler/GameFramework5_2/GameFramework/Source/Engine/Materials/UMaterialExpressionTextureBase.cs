#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionTextureBase.h")]
public partial class UMaterialExpressionTextureBase : UMaterialExpression {
	///<summary>Texture</summary>
	public UTexture Texture;
	///<summary>SamplerType</summary>
	public EMaterialSamplerType SamplerType;
	///<summary>Is default selected texture when using mesh paint mode texture painting</summary>
	public bool IsDefaultMeshpaintTexture;
}
