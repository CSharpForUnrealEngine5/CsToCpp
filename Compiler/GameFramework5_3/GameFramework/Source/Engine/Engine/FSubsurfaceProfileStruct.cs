namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>struct with all the settings we want in USubsurfaceProfile, separate to make it easer to pass this data around in the engine.</summary>
[CppInclude("Engine/SubsurfaceProfile.h")]
public partial struct FSubsurfaceProfileStruct {
	public FLinearColor SurfaceAlbedo;
	public FLinearColor MeanFreePathColor;
	public float MeanFreePathDistance;
	public float WorldUnitScale;
	public bool bEnableBurley;
	public bool bEnableMeanFreePath;
	public FLinearColor Tint;
	public float ScatterRadius;
	public FLinearColor SubsurfaceColor;
	public FLinearColor FalloffColor;
	public FLinearColor BoundaryColorBleed;
	public float ExtinctionScale;
	public float NormalScale;
	public float ScatteringDistribution;
	public float IOR;
	public float Roughness0;
	public float Roughness1;
	public float LobeMix;
	public FLinearColor TransmissionTintColor;
}
