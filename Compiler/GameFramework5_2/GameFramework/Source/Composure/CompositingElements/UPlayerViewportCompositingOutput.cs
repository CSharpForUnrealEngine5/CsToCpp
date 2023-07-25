#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/PlayerViewportCompositingOutput.h")]
///<summary>UPlayerViewportCompositingOutput</summary>
public partial class UPlayerViewportCompositingOutput : UColorConverterOutputPass {
// PlayerViewportCompositingOutput
	public int PlayerIndex;
	public bool ApplyToneCurve;
	public UPlayerCompOutputCameraModifier ActiveCamModifier;
	public UMaterialInterface TonemapperBaseMat;
	public UMaterialInterface PreTonemapBaseMat;
	public UMaterialInstanceDynamic ViewportOverrideMID;
}
