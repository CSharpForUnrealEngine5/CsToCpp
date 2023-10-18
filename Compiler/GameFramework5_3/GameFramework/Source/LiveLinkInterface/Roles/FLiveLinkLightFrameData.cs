namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Dynamic data for light.</summary>
[CppInclude("Roles/LiveLinkLightTypes.h")]
public partial struct FLiveLinkLightFrameData {
	public float Temperature;
	public float Intensity;
	public FColor LightColor;
	public float InnerConeAngle;
	public float OuterConeAngle;
	public float AttenuationRadius;
	public float SourceRadius;
	public float SoftSourceRadius;
	public float SourceLength;
}
