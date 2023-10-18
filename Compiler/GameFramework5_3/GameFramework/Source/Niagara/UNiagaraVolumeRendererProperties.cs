namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraVolumeRendererProperties.h")]
public partial class UNiagaraVolumeRendererProperties : UNiagaraRendererProperties {
	public static UClass StaticClass() {return default;}
	///<summary>What material to use for the volume.</summary>
	public UMaterialInterface Material;
	///<summary>MICMaterial</summary>
	public UMaterialInstanceConstant MICMaterial;
	///<summary>Binding to material.</summary>
	public FNiagaraParameterBinding MaterialParameterBinding;
	///<summary>If a render visibility tag is present, particles whose tag matches this value will be visible in this renderer.</summary>
	public int RendererVisibility;
	///<summary>StepFactor</summary>
	public float StepFactor;
	///<summary>LightingDownsampleFactor</summary>
	public float LightingDownsampleFactor;
	///<summary>ShadowStepFactor</summary>
	public float ShadowStepFactor;
	///<summary>ShadowBiasFactor</summary>
	public float ShadowBiasFactor;
	///<summary>Visibility tag binding, when valid the returned values is compared with RendererVisibility.</summary>
	public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
	///<summary>VolumeResolutionMaxAxisBinding</summary>
	public FNiagaraVariableAttributeBinding VolumeResolutionMaxAxisBinding;
	///<summary>VolumeWorldSpaceSizeBinding</summary>
	public FNiagaraVariableAttributeBinding VolumeWorldSpaceSizeBinding;
	///<summary>If this array has entries, we will create a MaterialInstanceDynamic per Emitter instance from Material and set the Material parameters using the Niagara simulation variables listed.</summary>
	public FNiagaraRendererMaterialParameters MaterialParameters;
}
