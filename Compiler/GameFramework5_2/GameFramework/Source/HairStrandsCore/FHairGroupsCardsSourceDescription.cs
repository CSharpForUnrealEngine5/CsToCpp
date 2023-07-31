#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAssetCards.h")]
public partial struct FHairGroupsCardsSourceDescription {
	public UMaterialInterface Material;
	public string MaterialSlotName;
	public EHairCardsSourceType SourceType;
	public UStaticMesh ProceduralMesh;
	public string ProceduralMeshKey;
	public UStaticMesh ImportedMesh;
	public FHairGroupsProceduralCards ProceduralSettings;
	public FHairGroupCardsTextures Textures;
	public int GroupIndex;
	public int LODIndex;
	public UHairCardGenerationSettings GenerationSettings;
	public FHairGroupCardsInfo CardsInfo;
	public string ImportedMeshKey;
}
