#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/StaticMeshImportTestFunctions.h")]
public partial class UStaticMeshImportTestFunctions : UImportTestFunctionsBase {
// StaticMeshImportTestFunctions
	public static FInterchangeTestFunctionResult CheckImportedStaticMeshCount(TArray<UStaticMesh> Meshes,int ExpectedNumberOfImportedStaticMeshes) { return default; }
	public static FInterchangeTestFunctionResult CheckLodCount(UStaticMesh Mesh,int ExpectedNumberOfLods) { return default; }
	public static FInterchangeTestFunctionResult CheckSectionCount(UStaticMesh Mesh,int LodIndex,int ExpectedNumberOfSections) { return default; }
	public static FInterchangeTestFunctionResult CheckMaterialSlotCount(UStaticMesh Mesh,int ExpectedNumberOfMaterialSlots) { return default; }
	public static FInterchangeTestFunctionResult CheckImportedMaterialSlotName(UStaticMesh Mesh,int MaterialIndex,string ExpectedImportedMaterialSlotName) { return default; }
	public static FInterchangeTestFunctionResult CheckPolygonGroupCount(UStaticMesh Mesh,int LodIndex,int ExpectedNumberOfPolygonGroups) { return default; }
	public static FInterchangeTestFunctionResult CheckPolygonGroupImportedMaterialSlotName(UStaticMesh Mesh,int LodIndex,int PolygonGroupIndex,string ExpectedImportedMaterialSlotName) { return default; }
	public static FInterchangeTestFunctionResult CheckSectionMaterialIndex(UStaticMesh Mesh,int LodIndex,int SectionIndex,int ExpectedMaterialIndex) { return default; }
	public static FInterchangeTestFunctionResult CheckSectionMaterialName(UStaticMesh Mesh,int LodIndex,int SectionIndex,string ExpectedMaterialName) { return default; }
	public static FInterchangeTestFunctionResult CheckSectionImportedMaterialSlotName(UStaticMesh Mesh,int LodIndex,int SectionIndex,string ExpectedImportedMaterialSlotName) { return default; }
	public static FInterchangeTestFunctionResult CheckVertexCount(UStaticMesh Mesh,int LodIndex,int ExpectedNumberOfVertices) { return default; }
	public static FInterchangeTestFunctionResult CheckRenderVertexCount(UStaticMesh Mesh,int LodIndex,int ExpectedNumberOfRenderVertices) { return default; }
	public static FInterchangeTestFunctionResult CheckVertexIndexPosition(UStaticMesh Mesh,int LodIndex,int VertexIndex,FVector ExpectedVertexPosition) { return default; }
	public static FInterchangeTestFunctionResult CheckRenderVertexIndexNormal(UStaticMesh Mesh,int LodIndex,int VertexIndex,FVector4f ExpectedVertexNormal) { return default; }
	public static FInterchangeTestFunctionResult CheckRenderVertexIndexColor(UStaticMesh Mesh,int LodIndex,int VertexIndex,FColor ExpectedVertexColor) { return default; }
	public static FInterchangeTestFunctionResult CheckRenderHasVertexColors(UStaticMesh Mesh,int LodIndex,bool bExpectedHasVertexColors) { return default; }
	public static FInterchangeTestFunctionResult CheckTriangleCount(UStaticMesh Mesh,int LodIndex,int ExpectedTotalNumberOfTriangles) { return default; }
	public static FInterchangeTestFunctionResult CheckRenderTriangleCount(UStaticMesh Mesh,int LodIndex,int ExpectedTotalNumberOfTriangles) { return default; }
	public static FInterchangeTestFunctionResult CheckPolygonCount(UStaticMesh Mesh,int LodIndex,int ExpectedNumberOfPolygons) { return default; }
	public static FInterchangeTestFunctionResult CheckThatMeshHasQuadsOrNgons(UStaticMesh Mesh,int LodIndex,bool bMeshHasQuadsOrNgons) { return default; }
	public static FInterchangeTestFunctionResult CheckTriangleCountInPolygonGroup(UStaticMesh Mesh,int LodIndex,int PolygonGroupIndex,int ExpectedNumberOfTriangles) { return default; }
	public static FInterchangeTestFunctionResult CheckPolygonCountInPolygonGroup(UStaticMesh Mesh,int LodIndex,int PolygonGroupIndex,int ExpectedNumberOfPolygons) { return default; }
	public static FInterchangeTestFunctionResult CheckUVChannelCount(UStaticMesh Mesh,int LodIndex,int ExpectedNumberOfUVChannels) { return default; }
	public static FInterchangeTestFunctionResult CheckRenderUVChannelCount(UStaticMesh Mesh,int LodIndex,int ExpectedNumberOfUVChannels) { return default; }
	public static FInterchangeTestFunctionResult CheckSimpleCollisionPrimitiveCount(UStaticMesh Mesh,int ExpectedSphereElementCount,int ExpectedBoxElementCount,int ExpectedCapsuleElementCount,int ExpectedConvexElementCount,int ExpectedTaperedCapsuleElementCount) { return default; }
	public static FInterchangeTestFunctionResult CheckSocketCount(UStaticMesh Mesh,int ExpectedSocketCount) { return default; }
	public static FInterchangeTestFunctionResult CheckSocketName(UStaticMesh Mesh,int SocketIndex,string ExpectedSocketName) { return default; }
	public static FInterchangeTestFunctionResult CheckSocketLocation(UStaticMesh Mesh,int SocketIndex,FVector ExpectedSocketLocation) { return default; }
	public static FInterchangeTestFunctionResult CheckAgainstGroundTruth(UStaticMesh Mesh,TSoftObjectPtr<UStaticMesh> MeshToCompare,bool bCheckVertexCountEqual/*=true*/,bool bCheckTriangleCountEqual/*=true*/,bool bCheckUVChannelCountEqual/*=true*/,bool bCheckCollisionPrimitiveCountEqual/*=true*/,bool bCheckVertexPositionsEqual/*=true*/,bool bCheckNormalsEqual/*=true*/) { return default; }
	public static FInterchangeTestFunctionResult CheckBuildSettings(UStaticMesh Mesh,int LodIndex,FMeshBuildSettings ExpectedBuildSettings) { return default; }
	public static FInterchangeTestFunctionResult CheckNaniteSettings(UStaticMesh Mesh,FMeshNaniteSettings ExpectedNaniteSettings) { return default; }
}
