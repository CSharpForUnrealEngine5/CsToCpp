#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/MeshComponent.h")]
///<summary>MeshComponent is an abstract base for any component that is an instance of a renderable collection of triangles.</summary>
public partial class UMeshComponent : UPrimitiveComponent {
// MeshComponent
	public TArray<UMaterialInterface> OverrideMaterials;
	public  TArray<UMaterialInterface> GetMaterials() { return default; }
	public  int GetMaterialIndex(string MaterialSlotName) { return default; }
	public  TArray<string> GetMaterialSlotNames() { return default; }
	public  bool IsMaterialSlotNameValid(string MaterialSlotName) { return default; }
	public UMaterialInterface OverlayMaterial;
	public float OverlayMaterialMaxDrawDistance;
	public  UMaterialInterface GetOverlayMaterial() { return default; }
	public  void SetOverlayMaterial(UMaterialInterface NewOverlayMaterial) {}
	public  void SetOverlayMaterialMaxDrawDistance(float InMaxDrawDistance) {}
	public  void PrestreamTextures(float Seconds,bool bPrioritizeCharacterTextures,int CinematicTextureGroups/*=0*/) {}
	public  void SetScalarParameterValueOnMaterials(string ParameterName,float ParameterValue) {}
	public  void SetVectorParameterValueOnMaterials(string ParameterName,FVector ParameterValue) {}
	public bool bEnableMaterialParameterCaching;
}
