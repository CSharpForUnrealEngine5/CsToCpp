#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGWorldData.h")]
public partial struct FPCGWorldRayHitQueryParams {
// PCGWorldRayHitQueryParams
	public bool bOverrideDefaultParams;
	public FVector RayOrigin;
	public FVector RayDirection;
	public double RayLength;
	public bool bApplyMetadataFromLandscape;
}
