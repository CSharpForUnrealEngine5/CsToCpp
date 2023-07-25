#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/StaticMeshImportTestFunctions.h")]
public partial class UStaticMeshImportTestFunctions : UImportTestFunctionsBase {
// StaticMeshImportTestFunctions
	public FInterchangeTestFunctionResult CheckImportedStaticMeshCount(TArray<UObject> Meshes,int ExpectedNumberOfImportedStaticMeshes) { return default; }
	public FInterchangeTestFunctionResult CheckLodCount(UObject Mesh,int ExpectedNumberOfLods) { return default; }
	public FInterchangeTestFunctionResult CheckSectionCount(UObject Mesh,int LodIndex,int ExpectedNumberOfSections) { return default; }
	public FInterchangeTestFunctionResult CheckMaterialSlotCount(UObject Mesh,int ExpectedNumberOfMaterialSlots) { return default; }
	public FInterchangeTestFunctionResult CheckImportedMaterialSlotName(UObject Mesh,int MaterialIndex,string ExpectedImportedMaterialSlotName) { return default; }
	public FInterchangeTestFunctionResult CheckPolygonGroupCount(UObject Mesh,int LodIndex,int ExpectedNumberOfPolygonGroups) { return default; }
	public FInterchangeTestFunctionResult CheckPolygonGroupImportedMaterialSlotName(UObject Mesh,int LodIndex,int PolygonGroupIndex,string ExpectedImportedMaterialSlotName) { return default; }
	public FInterchangeTestFunctionResult CheckSectionMaterialIndex(UObject Mesh,int LodIndex,int SectionIndex,int ExpectedMaterialIndex) { return default; }
	public FInterchangeTestFunctionResult CheckSectionMaterialName(UObject Mesh,int LodIndex,int SectionIndex,string ExpectedMaterialName) { return default; }
	public FInterchangeTestFunctionResult CheckSectionImportedMaterialSlotName(UObject Mesh,int LodIndex,int SectionIndex,string ExpectedImportedMaterialSlotName) { return default; }
	public FInterchangeTestFunctionResult CheckVertexCount(UObject Mesh,int LodIndex,int ExpectedNumberOfVertices) { return default; }
	public FInterchangeTestFunctionResult CheckRenderVertexCount(UObject Mesh,int LodIndex,int ExpectedNumberOfRenderVertices) { return default; }
	public FInterchangeTestFunctionResult CheckVertexIndexPosition(UObject Mesh,int LodIndex,int VertexIndex,FVector ExpectedVertexPosition) { return default; }
	public FInterchangeTestFunctionResult CheckRenderVertexIndexNormal(UObject Mesh,int LodIndex,int VertexIndex,FVector4f ExpectedVertexNormal) { return default; }
	public FInterchangeTestFunctionResult CheckRenderVertexIndexColor(UObject Mesh,int LodIndex,int VertexIndex,FColor ExpectedVertexColor) { return default; }
	public FInterchangeTestFunctionResult CheckRenderHasVertexColors(UObject Mesh,int LodIndex,bool bExpectedHasVertexColors) { return default; }
	public FInterchangeTestFunctionResult CheckTriangleCount(UObject Mesh,int LodIndex,int ExpectedTotalNumberOfTriangles) { return default; }
	public FInterchangeTestFunctionResult CheckRenderTriangleCount(UObject Mesh,int LodIndex,int ExpectedTotalNumberOfTriangles) { return default; }
	public FInterchangeTestFunctionResult CheckPolygonCount(UObject Mesh,int LodIndex,int ExpectedNumberOfPolygons) { return default; }
	public FInterchangeTestFunctionResult CheckThatMeshHasQuadsOrNgons(UObject Mesh,int LodIndex,bool bMeshHasQuadsOrNgons) { return default; }
	public FInterchangeTestFunctionResult CheckTriangleCountInPolygonGroup(UObject Mesh,int LodIndex,int PolygonGroupIndex,int ExpectedNumberOfTriangles) { return default; }
	public FInterchangeTestFunctionResult CheckPolygonCountInPolygonGroup(UObject Mesh,int LodIndex,int PolygonGroupIndex,int ExpectedNumberOfPolygons) { return default; }
	public FInterchangeTestFunctionResult CheckUVChannelCount(UObject Mesh,int LodIndex,int ExpectedNumberOfUVChannels) { return default; }
	public FInterchangeTestFunctionResult CheckRenderUVChannelCount(UObject Mesh,int LodIndex,int ExpectedNumberOfUVChannels) { return default; }
	public FInterchangeTestFunctionResult CheckSimpleCollisionPrimitiveCount(UObject Mesh,int ExpectedSphereElementCount,int ExpectedBoxElementCount,int ExpectedCapsuleElementCount,int ExpectedConvexElementCount,int ExpectedTaperedCapsuleElementCount) { return default; }
	public FInterchangeTestFunctionResult CheckSocketCount(UObject Mesh,int ExpectedSocketCount) { return default; }
	public FInterchangeTestFunctionResult CheckSocketName(UObject Mesh,int SocketIndex,string ExpectedSocketName) { return default; }
	public FInterchangeTestFunctionResult CheckSocketLocation(UObject Mesh,int SocketIndex,FVector ExpectedSocketLocation) { return default; }
	public FInterchangeTestFunctionResult CheckAgainstGroundTruth(UObject Mesh,TSoftObjectPtr<UStaticMesh> MeshToCompare,bool bCheckVertexCountEqual/*=true*/,bool bCheckTriangleCountEqual/*=true*/,bool bCheckUVChannelCountEqual/*=true*/,bool bCheckCollisionPrimitiveCountEqual/*=true*/,bool bCheckVertexPositionsEqual/*=true*/,bool bCheckNormalsEqual/*=true*/) { return default; }
	public FInterchangeTestFunctionResult CheckBuildSettings(UObject Mesh,int LodIndex,FMeshBuildSettings ExpectedBuildSettings) { return default; }
	public FInterchangeTestFunctionResult CheckNaniteSettings(UObject Mesh,FMeshNaniteSettings ExpectedNaniteSettings) { return default; }
}
