#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UDatasmithMeshActorElement</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithMeshActorElement : UDatasmithActorElement {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new material to the Actor Element</summary>
	public  void AddMaterialOverride(UDatasmithMaterialIDElement Material) {}
	///<summary>Get the amount of materials on this mesh</summary>
	public  int GetMaterialOverridesCount() { return default; }
	///<summary>Get the i-th material of this actor</summary>
	public  TArray<UDatasmithMaterialIDElement> GetMaterials() { return default; }
	///<summary>Get the amount of materials on this mesh</summary>
	public  void RemoveMaterialOverride(UDatasmithMaterialIDElement Material) {}
	///<summary>Get the path name of the StaticMesh associated with the actor</summary>
	public  string GetStaticMeshPathName() { return default; }
	///<summary>Set the path name of the StaticMesh that the actor is using</summary>
	public  void SetStaticMeshPathName(string InStaticMeshName) {}
	///<summary>Get the Datasmith MeshElement associated with the actor. The Mesh can be a direct reference to an Unreal Mesh. If it&#39;s the case it will return an invalid MeshElement.</summary>
	public  UDatasmithMeshElement GetMeshElement() { return default; }
	///<summary>Get the Bounding Box of the Actor as a Vector. X is Width, Y is Height, Z is Depth.</summary>
	public  FVector GetBoundingBoxSize() { return default; }
}
