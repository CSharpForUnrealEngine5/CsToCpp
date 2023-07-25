#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassEntityTestFarmPlot.h")]
public partial class AMassEntityTestFarmPlot : AActor {
// MassEntityTestFarmPlot
	public float GridCellWidth;
	public float GridCellHeight;
	public float HarvestIconScale;
	public TArray<FFarmVisualDataRow> VisualDataTable;
	public TArray<UHierarchicalInstancedStaticMeshComponent> VisualDataISMCs;
	public TArray<UMassProcessor> PerFrameSystems;
	public TArray<UMassProcessor> PerSecondSystems;
	public TArray<ushort> TestDataFlowerIndicies;
	public TArray<ushort> TestDataCropIndicies;
	public uint VisualNearCullDistance;
	public uint VisualFarCullDistance;
	public uint IconNearCullDistance;
	public uint IconFarCullDistance;
	public UHierarchicalInstancedStaticMeshComponent HarvestIconISMC;
}
