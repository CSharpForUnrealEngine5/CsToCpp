#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Executes collision queries against world collision.</summary>
[CppInclude("Data/PCGWorldData.h")]
public partial class UPCGWorldRayHitData : UPCGSurfaceData {
	///<summary>~End UPCGConcreteDataWithPointCache interface</summary>
	public TWeakObjectPtr<UWorld> World;
	///<summary>OriginatingComponent</summary>
	public TWeakObjectPtr<UPCGComponent> OriginatingComponent;
	///<summary>Bounds</summary>
	public FBox Bounds;
	///<summary>QueryParams</summary>
	public FPCGWorldRayHitQueryParams QueryParams;
}
