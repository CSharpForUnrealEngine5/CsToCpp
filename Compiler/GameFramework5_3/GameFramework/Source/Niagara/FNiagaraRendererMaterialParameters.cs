namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters to apply to the material, these are both constant and dynamic bindings</summary>
[CppInclude("NiagaraRendererProperties.h")]
public partial struct FNiagaraRendererMaterialParameters {
	public TArray<FNiagaraMaterialAttributeBinding> AttributeBindings;
	public TArray<FNiagaraRendererMaterialScalarParameter> ScalarParameters;
	public TArray<FNiagaraRendererMaterialVectorParameter> VectorParameters;
	public TArray<FNiagaraRendererMaterialTextureParameter> TextureParameters;
	public TArray<FNiagaraRendererMaterialStaticBoolParameter> StaticBoolParameters;
}
