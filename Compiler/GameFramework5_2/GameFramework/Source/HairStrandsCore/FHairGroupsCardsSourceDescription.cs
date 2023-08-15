namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAssetCards.h")]
public partial struct FHairGroupsCardsSourceDescription {
	public UMaterialInterface Material;
	public FName MaterialSlotName;
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
