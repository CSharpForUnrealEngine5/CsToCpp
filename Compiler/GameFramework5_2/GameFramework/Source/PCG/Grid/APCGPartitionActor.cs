#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The APCGPartitionActor actor is used to store grid cell data</summary>
[CppInclude("Grid/PCGPartitionActor.h")]
public partial class APCGPartitionActor : APartitionActor {
	public static UClass StaticClass() {return default;}
	///<summary>TODO: Make this in-editor only; during runtime, we should keep a map of component to bounds/volume only</summary>
	public  UPCGComponent GetLocalComponent(UPCGComponent OriginalComponent) { return default; }
	///<summary>GetOriginalComponent</summary>
	public  UPCGComponent GetOriginalComponent(UPCGComponent LocalComponent) { return default; }
	///<summary>PCGGuid</summary>
	public FGuid PCGGuid;
	///<summary>LocalToOriginal</summary>
	public TMap<UPCGComponent,TSoftObjectPtr<UPCGComponent>> LocalToOriginal;
	///<summary>LocalToOriginalMap_DEPRECATED</summary>
	public TMap<UPCGComponent,TWeakObjectPtr<UPCGComponent>> LocalToOriginalMap_DEPRECATED;
	///<summary>PCGGridSize</summary>
	public uint PCGGridSize;
	///<summary>bUse2DGrid</summary>
	public bool bUse2DGrid;
	///<summary>Box component to draw the Partition actor bounds in the Editor viewport</summary>
	public UBoxComponent BoundsComponent;
}
