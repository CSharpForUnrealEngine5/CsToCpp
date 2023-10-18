namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionTextureBase.h")]
public partial class UMaterialExpressionTextureBase : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Texture</summary>
	public UTexture Texture;
	///<summary>SamplerType</summary>
	public EMaterialSamplerType SamplerType;
	///<summary>Is default selected texture when using mesh paint mode texture painting</summary>
	public bool IsDefaultMeshpaintTexture;
}
