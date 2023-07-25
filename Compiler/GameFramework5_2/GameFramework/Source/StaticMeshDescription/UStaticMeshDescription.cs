#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StaticMeshDescription.h")]
///<summary>A wrapper for MeshDescription, customized for static meshes</summary>
public partial class UStaticMeshDescription : UMeshDescriptionBase {
// StaticMeshDescription
	public FVector2D GetVertexInstanceUV(FVertexInstanceID VertexInstanceID,int UVIndex/*=0*/) { return default; }
	public void SetVertexInstanceUV(FVertexInstanceID VertexInstanceID,FVector2D UV,int UVIndex/*=0*/) {}
	public void CreateCube(FVector Center,FVector HalfExtents,FPolygonGroupID PolygonGroup,FPolygonID PolygonID_PlusX,FPolygonID PolygonID_MinusX,FPolygonID PolygonID_PlusY,FPolygonID PolygonID_MinusY,FPolygonID PolygonID_PlusZ,FPolygonID PolygonID_MinusZ) {}
	public void SetPolygonGroupMaterialSlotName(FPolygonGroupID PolygonGroupID,string SlotName) {}
}
