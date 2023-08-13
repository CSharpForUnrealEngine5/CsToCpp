namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectElements/DatasmithUSceneElement.h")]
public partial class UDatasmithSceneElementBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the name of the host application which created the scene</summary>
	public string GetHost() { return default; }
	///<summary>Returns the Datasmith version used to export the scene</summary>
	public string GetExporterVersion() { return default; }
	///<summary>Returns the vendor name of the application used to export the scene</summary>
	public string GetVendor() { return default; }
	///<summary>Returns the product name of the application used to export the scene</summary>
	public string GetProductName() { return default; }
	///<summary>Returns the product version of the application used to export the scene</summary>
	public string GetProductVersion() { return default; }
	///<summary>Returns the user identifier who exported the scene</summary>
	public string GetUserID() { return default; }
	///<summary>Returns the OS name used by user who exported the scene</summary>
	public string GetUserOS() { return default; }
	///<summary>Returns the time taken to export the scene</summary>
	public int GetExportDuration() { return default; }
	///<summary>Physical Sky could be generated in a large amount of modes, like material, lights etc</summary>
	public bool GetUsePhysicalSky() { return default; }
	///<summary>Create a new Mesh and add it to the Datasmith scene</summary>
	public UDatasmithMeshElement CreateMesh(string InElementName) { return default; }
	///<summary>Create an array with all the Mesh in the Datasmith scene. Use CreateMesh -or- RemoveMesh to modify the Datasmith scene.</summary>
	public TArray<UDatasmithMeshElement> GetMeshes() { return default; }
	///<summary>Find in the Datasmith scene the MeshElement that correspond to the mesh path name.</summary>
	public UDatasmithMeshElement GetMeshByPathName(string MeshPathName) { return default; }
	///<summary>Remove the mesh from the Datasmith scene</summary>
	public void RemoveMesh(UDatasmithMeshElement InMesh) {}
	///<summary>Create a new MeshActor and add it to the Datasmith scene</summary>
	public UDatasmithMeshActorElement CreateMeshActor(string InElementName) { return default; }
	///<summary>Create an array with the MeshActor in the Datasmith scene that are at the root level of the hierarchy.</summary>
	public TArray<UDatasmithMeshActorElement> GetMeshActors() { return default; }
	///<summary>Create an array with all the MeshActor in the Datasmith scene without taking into account the hierarchy.</summary>
	public TArray<UDatasmithMeshActorElement> GetAllMeshActors() { return default; }
	///<summary>Remove the MeshActor from the Datasmith scene</summary>
	public void RemoveMeshActor(UDatasmithMeshActorElement InMeshActor,EDatasmithActorRemovalRule RemoveRule/*=EDatasmithActorRemovalRule.RemoveChildren*/) {}
	///<summary>Create an array with the LightActor in the Datasmith scene that are at the root level of the hierarchy.</summary>
	public TArray<UDatasmithLightActorElement> GetLightActors() { return default; }
	///<summary>Create an array with all the LightActor in the Datasmith scene without taking into account the hierarchy.</summary>
	public TArray<UDatasmithLightActorElement> GetAllLightActors() { return default; }
	///<summary>Remove the LightActor from the Datasmith scene</summary>
	public void RemoveLightActor(UDatasmithLightActorElement InLightActor,EDatasmithActorRemovalRule RemoveRule/*=EDatasmithActorRemovalRule.RemoveChildren*/) {}
	///<summary>Create a new Camera Actor and add it to the Datasmith scene</summary>
	public UDatasmithCameraActorElement CreateCameraActor(string InElementName) { return default; }
	///<summary>Create an array with the CameraActor in the Datasmith scene that are at the root level of the hierarchy.</summary>
	public TArray<UDatasmithCameraActorElement> GetCameraActors() { return default; }
	///<summary>Create an array with all the CameraActor in the Datasmith scene without taking into account the hierarchy.</summary>
	public TArray<UDatasmithCameraActorElement> GetAllCameraActors() { return default; }
	///<summary>Remove the Camera actor from the Datasmith scene</summary>
	public void RemoveCameraActor(UDatasmithCameraActorElement InMeshActor,EDatasmithActorRemovalRule RemoveRule/*=EDatasmithActorRemovalRule.RemoveChildren*/) {}
	///<summary>Create an array with the CustomActor in the Datasmith scene that are at the root level of the hierarchy.</summary>
	public TArray<UDatasmithCustomActorElement> GetCustomActors() { return default; }
	///<summary>Create an array with all the CustomActor in the Datasmith scene without taking into account the hierarchy.</summary>
	public TArray<UDatasmithCustomActorElement> GetAllCustomActors() { return default; }
	///<summary>Remove the LightActor from the Datasmith scene</summary>
	public void RemoveCustomActor(UDatasmithCustomActorElement InCustomActor,EDatasmithActorRemovalRule RemoveRule/*=EDatasmithActorRemovalRule.RemoveChildren*/) {}
	///<summary>Create a new Texture and add it to the Datasmith scene</summary>
	public UDatasmithTextureElement CreateTexture(string InElementName) { return default; }
	///<summary>Create an array with all the Textures in the Datasmith scene. Call CreateTexture -or- RemoveTexture to modify the Datasmith scene.</summary>
	public TArray<UDatasmithTextureElement> GetTextures() { return default; }
	///<summary>Remove the Texture from the Datasmith scene</summary>
	public void RemoveTexture(UDatasmithTextureElement InElement) {}
	///<summary>Create an array with all the Materials in the Datasmith scene</summary>
	public TArray<UDatasmithBaseMaterialElement> GetAllMaterials() { return default; }
	///<summary>Remove the material from the Datasmith scene</summary>
	public void RemoveMaterial(UDatasmithBaseMaterialElement InElement) {}
	///<summary>Get the Postprocess used by the scene. Can be invalid.</summary>
	public UDatasmithPostProcessElement GetPostProcess() { return default; }
	///<summary>GetMetaDataForObject</summary>
	public UDatasmithMetaDataElement GetMetaDataForObject(UDatasmithObjectElement Object) { return default; }
	///<summary>Get the value associated with the given key of the metadata element associated with the given object.</summary>
	public string GetMetaDataValueForKey(UDatasmithObjectElement Object,string Key) { return default; }
	///<summary>Get the keys and values for which the associated value contains the string to match for the metadata element associated with the given object.</summary>
	public void GetMetaDataKeysAndValuesForValue(UDatasmithObjectElement Object,string StringToMatch,TArray<string> OutKeys,TArray<string> OutValues) {}
	///<summary>Find all metadata elements associated with objects of the given type.</summary>
	public void GetAllMetaData(UClass ObjectClass,TArray<UDatasmithMetaDataElement> OutMetadatas) {}
	///<summary>Find all objects of the given type that have a metadata element that contains the given key and their associated values.</summary>
	public void GetAllObjectsAndValuesForKey(string Key,UClass ObjectClass,TArray<UDatasmithObjectElement> OutObjects,TArray<string> OutValues) {}
	///<summary>Create a new level variant sets and add it to the Datasmith scene</summary>
	public UDatasmithLevelVariantSetsElement CreateLevelVariantSets(string InElementName) { return default; }
	///<summary>Create an array with all the level variants sets from the Datasmith scene</summary>
	public TArray<UDatasmithLevelVariantSetsElement> GetAllLevelVariantSets() { return default; }
	///<summary>Remove the level variant sets from the Datasmith scene</summary>
	public void RemoveLevelVariantSets(UDatasmithLevelVariantSetsElement InElement) {}
	///<summary>Attach the actor to its new parent. Detach the actor if it was already attached.</summary>
	public void AttachActor(UDatasmithActorElement NewParent,UDatasmithActorElement Child,EDatasmithActorAttachmentRule AttachmentRule) {}
	///<summary>Attach the actor to the scene root. Detach the actor if it was already attached.</summary>
	public void AttachActorToSceneRoot(UDatasmithActorElement NewParent,EDatasmithActorAttachmentRule AttachmentRule) {}
}
