#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectElements/DatasmithUSceneElement.h")]
public partial class UDatasmithSceneElementBase : UObject {
// DatasmithSceneElementBase
	public string GetHost() { return default; }
	public string GetExporterVersion() { return default; }
	public string GetVendor() { return default; }
	public string GetProductName() { return default; }
	public string GetProductVersion() { return default; }
	public string GetUserID() { return default; }
	public string GetUserOS() { return default; }
	public int GetExportDuration() { return default; }
	public bool GetUsePhysicalSky() { return default; }
	public UObject CreateMesh(string InElementName) { return default; }
	public TArray<UObject> GetMeshes() { return default; }
	public UObject GetMeshByPathName(string MeshPathName) { return default; }
	public void RemoveMesh(UObject InMesh) {}
	public UObject CreateMeshActor(string InElementName) { return default; }
	public TArray<UObject> GetMeshActors() { return default; }
	public TArray<UObject> GetAllMeshActors() { return default; }
	public void RemoveMeshActor(UObject InMeshActor,EDatasmithActorRemovalRule RemoveRule/*=EDatasmithActorRemovalRule.RemoveChildren*/) {}
	public TArray<UObject> GetLightActors() { return default; }
	public TArray<UObject> GetAllLightActors() { return default; }
	public void RemoveLightActor(UObject InLightActor,EDatasmithActorRemovalRule RemoveRule/*=EDatasmithActorRemovalRule.RemoveChildren*/) {}
	public UObject CreateCameraActor(string InElementName) { return default; }
	public TArray<UObject> GetCameraActors() { return default; }
	public TArray<UObject> GetAllCameraActors() { return default; }
	public void RemoveCameraActor(UObject InMeshActor,EDatasmithActorRemovalRule RemoveRule/*=EDatasmithActorRemovalRule.RemoveChildren*/) {}
	public TArray<UObject> GetCustomActors() { return default; }
	public TArray<UObject> GetAllCustomActors() { return default; }
	public void RemoveCustomActor(UObject InCustomActor,EDatasmithActorRemovalRule RemoveRule/*=EDatasmithActorRemovalRule.RemoveChildren*/) {}
	public UObject CreateTexture(string InElementName) { return default; }
	public TArray<UObject> GetTextures() { return default; }
	public void RemoveTexture(UObject InElement) {}
	public TArray<UObject> GetAllMaterials() { return default; }
	public void RemoveMaterial(UObject InElement) {}
	public UObject GetPostProcess() { return default; }
	public UObject GetMetaDataForObject(UObject Object) { return default; }
	public string GetMetaDataValueForKey(UObject Object,string Key) { return default; }
	public void GetMetaDataKeysAndValuesForValue(UObject Object,string StringToMatch,TArray<string> OutKeys,TArray<string> OutValues) {}
	public void GetAllMetaData(UClass ObjectClass,TArray<UObject> OutMetadatas) {}
	public void GetAllObjectsAndValuesForKey(string Key,UClass ObjectClass,TArray<UObject> OutObjects,TArray<string> OutValues) {}
	public UObject CreateLevelVariantSets(string InElementName) { return default; }
	public TArray<UObject> GetAllLevelVariantSets() { return default; }
	public void RemoveLevelVariantSets(UObject InElement) {}
	public void AttachActor(UObject NewParent,UObject Child,EDatasmithActorAttachmentRule AttachmentRule) {}
	public void AttachActorToSceneRoot(UObject NewParent,EDatasmithActorAttachmentRule AttachmentRule) {}
}
