#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassEntityTestFarmPlot.h")]
public partial class AMassEntityTestFarmPlot : AActor {
	///<summary>GridCellWidth</summary>
	public float GridCellWidth;
	///<summary>GridCellHeight</summary>
	public float GridCellHeight;
	///<summary>HarvestIconScale</summary>
	public float HarvestIconScale;
	///<summary>VisualDataTable</summary>
	public TArray<FFarmVisualDataRow> VisualDataTable;
	///<summary>VisualDataISMCs</summary>
	public TArray<UHierarchicalInstancedStaticMeshComponent> VisualDataISMCs;
	///<summary>PerFrameSystems</summary>
	public TArray<UMassProcessor> PerFrameSystems;
	///<summary>PerSecondSystems</summary>
	public TArray<UMassProcessor> PerSecondSystems;
	///<summary>Indices into VisualDataTable for flowers</summary>
	public TArray<ushort> TestDataFlowerIndicies;
	///<summary>Indices into VisualDataTable for crops</summary>
	public TArray<ushort> TestDataCropIndicies;
	///<summary>VisualNearCullDistance</summary>
	public uint VisualNearCullDistance;
	///<summary>VisualFarCullDistance</summary>
	public uint VisualFarCullDistance;
	///<summary>IconNearCullDistance</summary>
	public uint IconNearCullDistance;
	///<summary>IconFarCullDistance</summary>
	public uint IconFarCullDistance;
	///<summary>HarvestIconISMC</summary>
	public UHierarchicalInstancedStaticMeshComponent HarvestIconISMC;
}
