#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDecalRendererProperties.h")]
public partial class UNiagaraDecalRendererProperties : UNiagaraRendererProperties {
	///<summary>What material to use for the decal.</summary>
	public UMaterialInterface Material;
	///<summary>MICMaterial</summary>
	public UMaterialInstanceConstant MICMaterial;
	///<summary>Binding to material.</summary>
	public FNiagaraParameterBinding MaterialParameterBinding;
	///<summary>Whether or not to draw a single element for the Emitter or to draw the particles.</summary>
	public ENiagaraRendererSourceDataMode SourceMode;
	///<summary>If a render visibility tag is present, particles whose tag matches this value will be visible in this renderer.</summary>
	public int RendererVisibility;
	///<summary>When the decal is smaller than this screen size fade out the decal, can be used to reduce the amount of small decals drawn.</summary>
	public float DecalScreenSizeFade;
	///<summary>Position binding for the decals, should be center of the decal</summary>
	public FNiagaraVariableAttributeBinding PositionBinding;
	///<summary>Orientation binding for the decal.</summary>
	public FNiagaraVariableAttributeBinding DecalOrientationBinding;
	///<summary>Size binding for the decal.</summary>
	public FNiagaraVariableAttributeBinding DecalSizeBinding;
	///<summary>Fade binding for the decal, value can be queried using the Decal Lifetime Opacity material node.</summary>
	public FNiagaraVariableAttributeBinding DecalFadeBinding;
	///<summary>Sort Order binding for the decal, used to ensure decals to not flicker when overlapping.</summary>
	public FNiagaraVariableAttributeBinding DecalSortOrderBinding;
	///<summary>Color binding for the decal, value can be queried using the Decal Color material node.</summary>
	public FNiagaraVariableAttributeBinding DecalColorBinding;
	///<summary>Should the decal be visibile or not, works in conjunction with RendererVisibilityTagBinding to determine visibility.</summary>
	public FNiagaraVariableAttributeBinding DecalVisibleBinding;
	///<summary>Visibility tag binding, when valid the returned values is compated with RendererVisibility.</summary>
	public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
	///<summary>If this array has entries, we will create a MaterialInstanceDynamic per Emitter instance from Material and set the Material parameters using the Niagara simulation variables listed.</summary>
	public FNiagaraRendererMaterialParameters MaterialParameters;
}
