#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UOctreeDynamicMeshComponent is a mesh component similar to UProceduralMeshComponent,</summary>
[CppInclude("Components/OctreeDynamicMeshComponent.h")]
public partial class UOctreeDynamicMeshComponent : UBaseDynamicMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>MeshObject</summary>
	public UDynamicMesh MeshObject;
	///<summary>SetDynamicMesh</summary>
	public  void SetDynamicMesh(UDynamicMesh NewMesh) {}
}
