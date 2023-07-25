#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProceduralFoliageComponent.h")]
public partial class UProceduralFoliageComponent : UActorComponent {
// ProceduralFoliageComponent
	public UProceduralFoliageSpawner FoliageSpawner;
	public float TileOverlap;
	public bool bAllowLandscape;
	public bool bAllowBSP;
	public bool bAllowStaticMesh;
	public bool bAllowTranslucent;
	public bool bAllowFoliage;
	public bool bShowDebugTiles;
	public AVolume SpawningVolume;
	public FGuid ProceduralGuid;
}
