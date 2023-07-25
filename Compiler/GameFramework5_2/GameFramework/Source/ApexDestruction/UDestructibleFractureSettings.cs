#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DestructibleFractureSettings.h")]
///<summary>Information to create an NxDestructibleAsset</summary>
public partial class UDestructibleFractureSettings : UObject {
// DestructibleFractureSettings
	public int CellSiteCount;
	public FFractureMaterial FractureMaterialDesc;
	public int RandomSeed;
	public TArray<FVector> VoronoiSites;
	public int OriginalSubmeshCount;
	public TArray<UMaterialInterface> Materials;
	public TArray<FDestructibleChunkParameters> ChunkParameters;
}
