namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information to create an NxDestructibleAsset</summary>
[CppInclude("DestructibleFractureSettings.h")]
public partial class UDestructibleFractureSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The number of voronoi cell sites.</summary>
	public int CellSiteCount;
	///<summary>Stored interior material data.  Just need one as we only support Voronoi splitting.</summary>
	public FFractureMaterial FractureMaterialDesc;
	///<summary>Random seed for reproducibility</summary>
	public int RandomSeed;
	///<summary>Stored Voronoi sites</summary>
	public TArray<FVector> VoronoiSites;
	///<summary>The mesh&#39;s original number of submeshes.  APEX needs to store this in the authoring.</summary>
	public int OriginalSubmeshCount;
	///<summary>APEX references materials by name, but we&#39;ll bypass that mechanism and use of UE materials instead.</summary>
	public TArray<UMaterialInterface> Materials;
	///<summary>Per-chunk authoring parameters, which should be made writable when a chunk selection GUI is in place.</summary>
	public TArray<FDestructibleChunkParameters> ChunkParameters;
}
