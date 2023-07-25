#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraRendererProperties.h")]
///<summary>Parameters to apply to the material, these are both constant and dynamic bindings</summary>
public partial struct FNiagaraRendererMaterialParameters {
// NiagaraRendererMaterialParameters
	public TArray<FNiagaraMaterialAttributeBinding> AttributeBindings;
	public TArray<FNiagaraRendererMaterialScalarParameter> ScalarParameters;
	public TArray<FNiagaraRendererMaterialVectorParameter> VectorParameters;
	public TArray<FNiagaraRendererMaterialTextureParameter> TextureParameters;
	public TArray<FNiagaraRendererMaterialStaticBoolParameter> StaticBoolParameters;
}
