namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A wrapper for MeshDescription, customized for static meshes</summary>
[CppInclude("StaticMeshDescription.h")]
public partial class UStaticMeshDescription : UMeshDescriptionBase {
	public static UClass StaticClass() {return default;}
	///<summary>GetVertexInstanceUV</summary>
	public FVector2D GetVertexInstanceUV(FVertexInstanceID VertexInstanceID,int UVIndex/*=0*/) { return default; }
	///<summary>SetVertexInstanceUV</summary>
	public void SetVertexInstanceUV(FVertexInstanceID VertexInstanceID,FVector2D UV,int UVIndex/*=0*/) {}
	///<summary>CreateCube</summary>
	public void CreateCube(FVector Center,FVector HalfExtents,FPolygonGroupID PolygonGroup,FPolygonID PolygonID_PlusX,FPolygonID PolygonID_MinusX,FPolygonID PolygonID_PlusY,FPolygonID PolygonID_MinusY,FPolygonID PolygonID_PlusZ,FPolygonID PolygonID_MinusZ) {}
	///<summary>SetPolygonGroupMaterialSlotName</summary>
	public void SetPolygonGroupMaterialSlotName(FPolygonGroupID PolygonGroupID,string SlotName) {}
}
