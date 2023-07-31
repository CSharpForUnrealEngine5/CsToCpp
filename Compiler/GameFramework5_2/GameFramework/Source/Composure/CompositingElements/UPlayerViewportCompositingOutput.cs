#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UPlayerViewportCompositingOutput</summary>
[CppInclude("CompositingElements/PlayerViewportCompositingOutput.h")]
public partial class UPlayerViewportCompositingOutput : UColorConverterOutputPass {
	///<summary>PlayerIndex</summary>
	public int PlayerIndex;
	///<summary>Enable or disable the tone curve (and expand gamut) when the tonemap pass settings are passed down to the main viewport post-processing.</summary>
	public bool ApplyToneCurve;
	///<summary>ActiveCamModifier</summary>
	public UPlayerCompOutputCameraModifier ActiveCamModifier;
	///<summary>TonemapperBaseMat</summary>
	public UMaterialInterface TonemapperBaseMat;
	///<summary>PreTonemapBaseMat</summary>
	public UMaterialInterface PreTonemapBaseMat;
	///<summary>ViewportOverrideMID</summary>
	public UMaterialInstanceDynamic ViewportOverrideMID;
}
