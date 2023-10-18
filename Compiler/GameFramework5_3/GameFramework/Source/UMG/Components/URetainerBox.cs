namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Retainer Box renders children widgets to a render target first before</summary>
[CppInclude("Components/RetainerBox.h")]
public partial class URetainerBox : UContentWidget {
	public static UClass StaticClass() {return default;}
	///<summary>bRetainRender</summary>
	public bool bRetainRender;
	///<summary>Should this widget redraw the contents it has every time it receives an invalidation request</summary>
	public bool RenderOnInvalidation;
	///<summary>Should this widget redraw the contents it has every time the phase occurs.</summary>
	public bool RenderOnPhase;
	///<summary>The Phase this widget will draw on.</summary>
	public int Phase;
	///<summary>The PhaseCount controls how many phases are possible know what to modulus the current frame</summary>
	public int PhaseCount;
	///<summary>Requests the retainer redrawn the contents it has.</summary>
	public void SetRenderingPhase(int RenderPhase,int TotalPhases) {}
	///<summary>Requests the retainer redrawn the contents it has.</summary>
	public void RequestRender() {}
	///<summary>Get the current dynamic effect material applied to the retainer box.</summary>
	public UMaterialInstanceDynamic GetEffectMaterial() { return default; }
	///<summary>Set a new effect material to the retainer widget.</summary>
	public void SetEffectMaterial(UMaterialInterface EffectMaterial) {}
	///<summary>Sets the name of the texture parameter to set the render target to on the material.</summary>
	public void SetTextureParameter(FName TextureParameter) {}
	///<summary>Set the flag for if we retain the render or pass-through</summary>
	public void SetRetainRendering(bool bInRetainRendering) {}
	///<summary>The effect to optionally apply to the render target.  We will set the texture sampler based on the name</summary>
	public UMaterialInterface EffectMaterial;
	///<summary>The texture sampler parameter of the @EffectMaterial, that we&#39;ll set to the render target.</summary>
	public FName TextureParameter;
	///<summary>If true, retained rendering occurs in designer</summary>
	public bool bShowEffectsInDesigner;
}
