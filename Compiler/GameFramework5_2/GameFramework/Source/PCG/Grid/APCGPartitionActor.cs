#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Grid/PCGPartitionActor.h")]
///<summary>The APCGPartitionActor actor is used to store grid cell data</summary>
public partial class APCGPartitionActor : APartitionActor {
// PCGPartitionActor
	public  UPCGComponent GetLocalComponent(UPCGComponent OriginalComponent) { return default; }
	public  UPCGComponent GetOriginalComponent(UPCGComponent LocalComponent) { return default; }
	public FGuid PCGGuid;
	public TMap<UPCGComponent,TSoftObjectPtr<UPCGComponent>> LocalToOriginal;
	public TMap<UPCGComponent,TWeakObjectPtr<UPCGComponent>> LocalToOriginalMap_DEPRECATED;
	public uint PCGGridSize;
	public bool bUse2DGrid;
	public UBoxComponent BoundsComponent;
}
