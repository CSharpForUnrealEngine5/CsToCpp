namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/CustomizableObjectEditorViewportLights.h")]
public partial struct FViewportLightData {
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
