#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGWorldData.h")]
///<summary>Executes collision queries against world collision.</summary>
public partial class UPCGWorldRayHitData : UPCGSurfaceData {
// PCGWorldRayHitData
	public TWeakObjectPtr<UWorld> World;
	public TWeakObjectPtr<UPCGComponent> OriginatingComponent;
	public FBox Bounds;
	public FPCGWorldRayHitQueryParams QueryParams;
}
