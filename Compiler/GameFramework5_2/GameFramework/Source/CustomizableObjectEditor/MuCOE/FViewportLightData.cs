#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/CustomizableObjectEditorViewportLights.h")]
public partial struct FViewportLightData {
// ViewportLightData
	public bool bIsSpotLight;
	public FTransform Transform;
	public float Intensity;
	public FLinearColor Color;
	public float AttenuationRadius;
	public float SourceRadius;
	public float SourceLength;
	public float InnerConeAngle;
	public float OuterConeAngle;
}
