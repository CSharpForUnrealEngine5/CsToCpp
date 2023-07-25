#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
///<summary>* UDatasmithMeshActorElement</summary>
public partial class UDatasmithMeshActorElement : UDatasmithActorElement {
// DatasmithMeshActorElement
	public void AddMaterialOverride(UObject Material) {}
	public int GetMaterialOverridesCount() { return default; }
	public TArray<UObject> GetMaterials() { return default; }
	public void RemoveMaterialOverride(UObject Material) {}
	public string GetStaticMeshPathName() { return default; }
	public void SetStaticMeshPathName(string InStaticMeshName) {}
	public UObject GetMeshElement() { return default; }
	public FVector GetBoundingBoxSize() { return default; }
}
