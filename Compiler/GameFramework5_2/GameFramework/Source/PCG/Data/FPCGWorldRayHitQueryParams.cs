namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGWorldData.h")]
public partial struct FPCGWorldRayHitQueryParams {
	public bool bOverrideDefaultParams;
	public FVector RayOrigin;
	public FVector RayDirection;
	public double RayLength;
	public bool bApplyMetadataFromLandscape;
}
