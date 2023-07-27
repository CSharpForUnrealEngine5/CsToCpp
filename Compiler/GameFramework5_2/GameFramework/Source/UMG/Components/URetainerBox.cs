#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/RetainerBox.h")]
///<summary>The Retainer Box renders children widgets to a render target first before</summary>
public partial class URetainerBox : UContentWidget {
// RetainerBox
	public bool bRetainRender;
	public bool RenderOnInvalidation;
	public bool RenderOnPhase;
	public int Phase;
	public int PhaseCount;
	public  void SetRenderingPhase(int RenderPhase,int TotalPhases) {}
	public  void RequestRender() {}
	public  UMaterialInstanceDynamic GetEffectMaterial() { return default; }
	public  void SetEffectMaterial(UMaterialInterface EffectMaterial) {}
	public  void SetTextureParameter(string TextureParameter) {}
	public  void SetRetainRendering(bool bInRetainRendering) {}
	public UMaterialInterface EffectMaterial;
	public string TextureParameter;
}
