#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableInstancePrivateData.h")]
public partial class UCustomizableInstancePrivateData : UObject {
// CustomizableInstancePrivateData
	public TArray<FGeneratedMaterial> GeneratedMaterials;
	public TArray<FGeneratedTexture> GeneratedTextures;
	public TArray<FParameterDecorations> ParameterDecorations;
	public TMap<string,TWeakObjectPtr<UTexture2D>> TextureReuseCache;
	public TArray<FCustomizableInstanceComponentData> ComponentsData;
	public TArray<UMaterialInterface> ReferencedMaterials;
	public TArray<UPhysicsAsset> ClothingPhysicsAssets;
	public TArray<UClass> GatheredAnimBPs;
	public FGameplayTagContainer AnimBPGameplayTags;
}
