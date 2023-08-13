namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProceduralFoliageComponent.h")]
public partial class UProceduralFoliageComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The procedural foliage spawner used to generate foliage instances within this volume.</summary>
	public UProceduralFoliageSpawner FoliageSpawner;
	///<summary>The amount of overlap between simulation tiles (in cm).</summary>
	public float TileOverlap;
	///<summary>Whether to place foliage on landscape</summary>
	public bool bAllowLandscape;
	///<summary>Whether to place foliage on BSP</summary>
	public bool bAllowBSP;
	///<summary>Whether to place foliage on StaticMesh</summary>
	public bool bAllowStaticMesh;
	///<summary>Whether to place foliage on translucent geometry</summary>
	public bool bAllowTranslucent;
	///<summary>Whether to place foliage on other blocking foliage geometry</summary>
	public bool bAllowFoliage;
	///<summary>Whether to visualize the tiles used for the foliage spawner simulation</summary>
	public bool bShowDebugTiles;
	///<summary>SpawningVolume</summary>
	public AVolume SpawningVolume;
	///<summary>ProceduralGuid</summary>
	public FGuid ProceduralGuid;
}
