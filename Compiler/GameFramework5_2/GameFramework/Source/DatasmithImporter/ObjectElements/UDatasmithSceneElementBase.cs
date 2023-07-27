#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectElements/DatasmithUSceneElement.h")]
public partial class UDatasmithSceneElementBase : UObject {
// DatasmithSceneElementBase
	public  string GetHost() { return default; }
	public  string GetExporterVersion() { return default; }
	public  string GetVendor() { return default; }
	public  string GetProductName() { return default; }
	public  string GetProductVersion() { return default; }
	public  string GetUserID() { return default; }
	public  string GetUserOS() { return default; }
	public  int GetExportDuration() { return default; }
	public  bool GetUsePhysicalSky() { return default; }
	public  UDatasmithMeshElement CreateMesh(string InElementName) { return default; }
	public  TArray<UDatasmithMeshElement> GetMeshes() { return default; }
	public  UDatasmithMeshElement GetMeshByPathName(string MeshPathName) { return default; }
	public  void RemoveMesh(UDatasmithMeshElement InMesh) {}
	public  UDatasmithMeshActorElement CreateMeshActor(string InElementName) { return default; }
	public  TArray<UDatasmithMeshActorElement> GetMeshActors() { return default; }
	public  TArray<UDatasmithMeshActorElement> GetAllMeshActors() { return default; }
	public  void RemoveMeshActor(UDatasmithMeshActorElement InMeshActor,EDatasmithActorRemovalRule RemoveRule/*=EDatasmithActorRemovalRule.RemoveChildren*/) {}
	public  TArray<UDatasmithLightActorElement> GetLightActors() { return default; }
	public  TArray<UDatasmithLightActorElement> GetAllLightActors() { return default; }
	public  void RemoveLightActor(UDatasmithLightActorElement InLightActor,EDatasmithActorRemovalRule RemoveRule/*=EDatasmithActorRemovalRule.RemoveChildren*/) {}
	public  UDatasmithCameraActorElement CreateCameraActor(string InElementName) { return default; }
	public  TArray<UDatasmithCameraActorElement> GetCameraActors() { return default; }
	public  TArray<UDatasmithCameraActorElement> GetAllCameraActors() { return default; }
	public  void RemoveCameraActor(UDatasmithCameraActorElement InMeshActor,EDatasmithActorRemovalRule RemoveRule/*=EDatasmithActorRemovalRule.RemoveChildren*/) {}
	public  TArray<UDatasmithCustomActorElement> GetCustomActors() { return default; }
	public  TArray<UDatasmithCustomActorElement> GetAllCustomActors() { return default; }
	public  void RemoveCustomActor(UDatasmithCustomActorElement InCustomActor,EDatasmithActorRemovalRule RemoveRule/*=EDatasmithActorRemovalRule.RemoveChildren*/) {}
	public  UDatasmithTextureElement CreateTexture(string InElementName) { return default; }
	public  TArray<UDatasmithTextureElement> GetTextures() { return default; }
	public  void RemoveTexture(UDatasmithTextureElement InElement) {}
	public  TArray<UDatasmithBaseMaterialElement> GetAllMaterials() { return default; }
	public  void RemoveMaterial(UDatasmithBaseMaterialElement InElement) {}
	public  UDatasmithPostProcessElement GetPostProcess() { return default; }
	public  UDatasmithMetaDataElement GetMetaDataForObject(UDatasmithObjectElement Object) { return default; }
	public  string GetMetaDataValueForKey(UDatasmithObjectElement Object,string Key) { return default; }
	public  void GetMetaDataKeysAndValuesForValue(UDatasmithObjectElement Object,string StringToMatch,TArray<string> OutKeys,TArray<string> OutValues) {}
	public  void GetAllMetaData(UClass ObjectClass,TArray<UDatasmithMetaDataElement> OutMetadatas) {}
	public  void GetAllObjectsAndValuesForKey(string Key,UClass ObjectClass,TArray<UDatasmithObjectElement> OutObjects,TArray<string> OutValues) {}
	public  UDatasmithLevelVariantSetsElement CreateLevelVariantSets(string InElementName) { return default; }
	public  TArray<UDatasmithLevelVariantSetsElement> GetAllLevelVariantSets() { return default; }
	public  void RemoveLevelVariantSets(UDatasmithLevelVariantSetsElement InElement) {}
	public  void AttachActor(UDatasmithActorElement NewParent,UDatasmithActorElement Child,EDatasmithActorAttachmentRule AttachmentRule) {}
	public  void AttachActorToSceneRoot(UDatasmithActorElement NewParent,EDatasmithActorAttachmentRule AttachmentRule) {}
}
