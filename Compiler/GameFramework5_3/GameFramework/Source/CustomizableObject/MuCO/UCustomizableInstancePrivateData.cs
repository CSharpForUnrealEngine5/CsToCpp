namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableInstancePrivateData.h")]
public partial class UCustomizableInstancePrivateData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GeneratedMaterials</summary>
	public TArray<FGeneratedMaterial> GeneratedMaterials;
	///<summary>GeneratedTextures</summary>
	public TArray<FGeneratedTexture> GeneratedTextures;
	///<summary>If Texture reuse is enabled, stores which texture is being used in a particular &lt;LODIndex, ComponentIndex, MeshSurfaceIndex, image&gt;</summary>
	public TMap<string,TWeakObjectPtr<UTexture2D>> TextureReuseCache;
	///<summary>ComponentsData</summary>
	public TArray<FCustomizableInstanceComponentData> ComponentsData;
	///<summary>ReferencedMaterials</summary>
	public TArray<UMaterialInterface> ReferencedMaterials;
	///<summary>ClothingPhysicsAssets</summary>
	public TArray<UPhysicsAsset> ClothingPhysicsAssets;
	///<summary>To keep loaded AnimBPs referenced and prevent GC</summary>
	public TArray<UClass> GatheredAnimBPs;
	///<summary>AnimBPGameplayTags</summary>
	public FGameplayTagContainer AnimBPGameplayTags;
	///<summary>AnimBpPhysicsAssets</summary>
	public TMap<UClass,FAnimBpGeneratedPhysicsAssets> AnimBpPhysicsAssets;
}
