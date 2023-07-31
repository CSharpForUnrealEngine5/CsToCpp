#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PixelInspectorView.h")]
public partial class UPixelInspectorView : UObject {
	///<summary>Final RGBA 8bits Color after tone mapping, default value is black.</summary>
	public FLinearColor FinalColor;
	///<summary>HDR RGB Color.</summary>
	public FLinearColor SceneColor;
	///<summary>HDR Luminance.</summary>
	public float PreExposure;
	///<summary>HDR Luminance.</summary>
	public float Luminance;
	///<summary>HDR RGB Color.</summary>
	public FLinearColor HdrColor;
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
