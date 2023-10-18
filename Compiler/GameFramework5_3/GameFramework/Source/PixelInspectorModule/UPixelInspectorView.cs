namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Note: UPixelInspectorView is only ever created as a transient object, so making properties transient is redundant.</summary>
[CppInclude("PixelInspectorView.h")]
public partial class UPixelInspectorView : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Final color in display space after tone mapping.</summary>
	public FLinearColor FinalColor;
	///<summary>Amount of exposure applied to Scene Color due to auto-exposure and/or exposure compensation.</summary>
	public float PreExposure;
	///<summary>HDR scene-linear color in working color space, before post-processing. Previously called Scene Color.</summary>
	public FLinearColor SceneColorBeforePostProcessing;
	///<summary>HDR scene-linear color in working color space, before tone mapping. Previously called Hdr Color.</summary>
	public FLinearColor SceneColorBeforeTonemap;
	///<summary>Luminance of the Scene Color Before Tonemap.</summary>
	public float LuminanceBeforeTonemap;
	///<summary>From the GBufferA RGB Channels.</summary>
	public FVector Normal;
	///<summary>From the GBufferA A Channel.</summary>
	public float PerObjectGBufferData;
	///<summary>From the GBufferB R Channel.</summary>
	public float Metallic;
	///<summary>From the GBufferB G Channel.</summary>
	public float Specular;
	///<summary>From the GBufferB B Channel.</summary>
	public float Roughness;
	///<summary>From the GBufferB A Channel encoded with SelectiveOutputMask.</summary>
	public EMaterialShadingModel MaterialShadingModel;
	///<summary>From the GBufferB A Channel encoded with ShadingModel.</summary>
	public int SelectiveOutputMask;
	///<summary>From the GBufferC RGB Channels.</summary>
	public FLinearColor BaseColor;
	///<summary>From the GBufferC A Channel encoded with AmbientOcclusion.</summary>
	public float IndirectIrradiance;
	///<summary>From the GBufferC A Channel encoded with IndirectIrradiance.</summary>
	public float AmbientOcclusion;
	///<summary>From the GBufferD RGB Channels.</summary>
	public FLinearColor SubSurfaceColor;
	///<summary>From the GBufferD RGB Channels.</summary>
	public FVector SubsurfaceProfile;
	///<summary>From the GBufferD A Channel.</summary>
	public float Opacity;
	///<summary>From the GBufferD R Channel.</summary>
	public float ClearCoat;
	///<summary>From the GBufferD G Channel.</summary>
	public float ClearCoatRoughness;
	///<summary>From the GBufferD RG Channels.</summary>
	public FVector WorldNormal;
	///<summary>From the GBufferD B Channel.</summary>
	public float BackLit;
	///<summary>From the GBufferD A Channel.</summary>
	public float Cloth;
	///<summary>From the GBufferD RG Channels.</summary>
	public FVector EyeTangent;
	///<summary>From the GBufferD B Channel.</summary>
	public float IrisMask;
	///<summary>From the GBufferD A Channel.</summary>
	public float IrisDistance;
}
