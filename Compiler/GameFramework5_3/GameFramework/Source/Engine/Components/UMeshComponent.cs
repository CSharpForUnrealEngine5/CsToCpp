namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MeshComponent is an abstract base for any component that is an instance of a renderable collection of triangles.</summary>
[CppInclude("Components/MeshComponent.h")]
public partial class UMeshComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Material overrides.</summary>
	public TArray<UMaterialInterface> OverrideMaterials;
	///<summary>GetMaterials</summary>
	public virtual TArray<UMaterialInterface> GetMaterials() { return default; }
	///<summary>GetMaterialIndex</summary>
	public virtual int GetMaterialIndex(FName MaterialSlotName) { return default; }
	///<summary>GetMaterialSlotNames</summary>
	public virtual TArray<FName> GetMaterialSlotNames() { return default; }
	///<summary>IsMaterialSlotNameValid</summary>
	public virtual bool IsMaterialSlotNameValid(FName MaterialSlotName) { return default; }
	///<summary>Translucent material to blend on top of this mesh. Mesh will be rendered twice - once with a base material and once with overlay material</summary>
	public UMaterialInterface OverlayMaterial;
	///<summary>The max draw distance for overlay material. A distance of 0 indicates that overlay will be culled using primitive max distance.</summary>
	public float OverlayMaterialMaxDrawDistance;
	///<summary>Get the overlay material used by this instance</summary>
	public UMaterialInterface GetOverlayMaterial() { return default; }
	///<summary>Change the overlay material used by this instance</summary>
	public void SetOverlayMaterial(UMaterialInterface NewOverlayMaterial) {}
	///<summary>Get the overlay material used by this instance</summary>
	public float GetOverlayMaterialMaxDrawDistance() { return default; }
	///<summary>Change the overlay material max draw distance used by this instance</summary>
	public void SetOverlayMaterialMaxDrawDistance(float InMaxDrawDistance) {}
	///<summary>Tell the streaming system to start loading all textures with all mip-levels.</summary>
	public virtual void PrestreamTextures(float Seconds,bool bPrioritizeCharacterTextures,int CinematicTextureGroups/*=0*/) {}
	///<summary>Set all occurrences of Scalar Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue</summary>
	public void SetScalarParameterValueOnMaterials(FName ParameterName,float ParameterValue) {}
	///<summary>Set all occurrences of Vector Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue</summary>
	public void SetVectorParameterValueOnMaterials(FName ParameterName,FVector ParameterValue) {}
	///<summary>bEnableMaterialParameterCaching</summary>
	public bool bEnableMaterialParameterCaching;
}
