namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ImportTestFunctions/StaticMeshImportTestFunctions.h")]
public partial class UStaticMeshImportTestFunctions : UImportTestFunctionsBase {
	public static UClass StaticClass() {return default;}
	///<summary>Check whether the expected number of static meshes are imported</summary>
	public static FInterchangeTestFunctionResult CheckImportedStaticMeshCount(TArray<UStaticMesh> Meshes,int ExpectedNumberOfImportedStaticMeshes) { return default; }
	///<summary>Check whether the static mesh has the expected number of LODs</summary>
	public static FInterchangeTestFunctionResult CheckLodCount(UStaticMesh Mesh,int ExpectedNumberOfLods) { return default; }
	///<summary>Check whether the render data for the given mesh LOD has the expected number of sections</summary>
	public static FInterchangeTestFunctionResult CheckSectionCount(UStaticMesh Mesh,int LodIndex,int ExpectedNumberOfSections) { return default; }
	///<summary>Check whether the static mesh has the expected number of material slots</summary>
	public static FInterchangeTestFunctionResult CheckMaterialSlotCount(UStaticMesh Mesh,int ExpectedNumberOfMaterialSlots) { return default; }
	///<summary>Check whether the static mesh imported material slot name for the given material index is as expected</summary>
	public static FInterchangeTestFunctionResult CheckImportedMaterialSlotName(UStaticMesh Mesh,int MaterialIndex,string ExpectedImportedMaterialSlotName) { return default; }
	///<summary>Check whether the mesh description has the expected number of polygon groups for the given LOD</summary>
	public static FInterchangeTestFunctionResult CheckPolygonGroupCount(UStaticMesh Mesh,int LodIndex,int ExpectedNumberOfPolygonGroups) { return default; }
	///<summary>Check whether the mesh description material slot name for the given polygon group in the given LOD is as expected</summary>
	public static FInterchangeTestFunctionResult CheckPolygonGroupImportedMaterialSlotName(UStaticMesh Mesh,int LodIndex,int PolygonGroupIndex,string ExpectedImportedMaterialSlotName) { return default; }
	///<summary>Check whether the section index in the built render data for the given LOD is referencing the expected material index</summary>
	public static FInterchangeTestFunctionResult CheckSectionMaterialIndex(UStaticMesh Mesh,int LodIndex,int SectionIndex,int ExpectedMaterialIndex) { return default; }
	///<summary>Check whether the section index in the built render data for the given LOD is referencing the expected material</summary>
	public static FInterchangeTestFunctionResult CheckSectionMaterialName(UStaticMesh Mesh,int LodIndex,int SectionIndex,string ExpectedMaterialName) { return default; }
	///<summary>Check whether the section index in the built render data for the given LOD is referencing the expected imported material slot name</summary>
	public static FInterchangeTestFunctionResult CheckSectionImportedMaterialSlotName(UStaticMesh Mesh,int LodIndex,int SectionIndex,string ExpectedImportedMaterialSlotName) { return default; }
	///<summary>Check whether the mesh description vertex count for the given LOD is as expected</summary>
	public static FInterchangeTestFunctionResult CheckVertexCount(UStaticMesh Mesh,int LodIndex,int ExpectedNumberOfVertices) { return default; }
	///<summary>Check whether the render data vertex count for the given LOD is as expected</summary>
	public static FInterchangeTestFunctionResult CheckRenderVertexCount(UStaticMesh Mesh,int LodIndex,int ExpectedNumberOfRenderVertices) { return default; }
	///<summary>Check whether the mesh description vertex of the given index is at the expected position</summary>
	public static FInterchangeTestFunctionResult CheckVertexIndexPosition(UStaticMesh Mesh,int LodIndex,int VertexIndex,FVector ExpectedVertexPosition) { return default; }
	///<summary>Check whether the render data vertex index of the given LOD has the expected vertex normal</summary>
	public static FInterchangeTestFunctionResult CheckRenderVertexIndexNormal(UStaticMesh Mesh,int LodIndex,int VertexIndex,FVector4f ExpectedVertexNormal) { return default; }
	///<summary>Check whether the render data vertex index of the given LOD has the expected vertex color</summary>
	public static FInterchangeTestFunctionResult CheckRenderVertexIndexColor(UStaticMesh Mesh,int LodIndex,int VertexIndex,FColor ExpectedVertexColor) { return default; }
	///<summary>Check whether the render data contains any vertex colors of the given LOD</summary>
	public static FInterchangeTestFunctionResult CheckRenderHasVertexColors(UStaticMesh Mesh,int LodIndex,bool bExpectedHasVertexColors) { return default; }
	///<summary>Check whether the mesh description has the expected number of triangles for the given LOD</summary>
	public static FInterchangeTestFunctionResult CheckTriangleCount(UStaticMesh Mesh,int LodIndex,int ExpectedTotalNumberOfTriangles) { return default; }
	///<summary>Check whether the render data has the expected number of triangles for the given LOD</summary>
	public static FInterchangeTestFunctionResult CheckRenderTriangleCount(UStaticMesh Mesh,int LodIndex,int ExpectedTotalNumberOfTriangles) { return default; }
	///<summary>Check whether the mesh description has the expected number of polygons for the given LOD</summary>
	public static FInterchangeTestFunctionResult CheckPolygonCount(UStaticMesh Mesh,int LodIndex,int ExpectedNumberOfPolygons) { return default; }
	///<summary>Check whether the mesh description contains any quads or ngons</summary>
	public static FInterchangeTestFunctionResult CheckThatMeshHasQuadsOrNgons(UStaticMesh Mesh,int LodIndex,bool bMeshHasQuadsOrNgons) { return default; }
	///<summary>Check whether the given mesh description polygon group of the given LOD has the expected number of triangles</summary>
	public static FInterchangeTestFunctionResult CheckTriangleCountInPolygonGroup(UStaticMesh Mesh,int LodIndex,int PolygonGroupIndex,int ExpectedNumberOfTriangles) { return default; }
	///<summary>Check whether the given mesh description polygon group of the given LOD has the expected number of polygons</summary>
	public static FInterchangeTestFunctionResult CheckPolygonCountInPolygonGroup(UStaticMesh Mesh,int LodIndex,int PolygonGroupIndex,int ExpectedNumberOfPolygons) { return default; }
	///<summary>Check whether the mesh description has the expected number of UV channels</summary>
	public static FInterchangeTestFunctionResult CheckUVChannelCount(UStaticMesh Mesh,int LodIndex,int ExpectedNumberOfUVChannels) { return default; }
	///<summary>Check whether the render data has the expected number of UV channels</summary>
	public static FInterchangeTestFunctionResult CheckRenderUVChannelCount(UStaticMesh Mesh,int LodIndex,int ExpectedNumberOfUVChannels) { return default; }
	///<summary>Check whether the static mesh expected number of simple collision primitives were imported</summary>
	public static FInterchangeTestFunctionResult CheckSimpleCollisionPrimitiveCount(UStaticMesh Mesh,int ExpectedSphereElementCount,int ExpectedBoxElementCount,int ExpectedCapsuleElementCount,int ExpectedConvexElementCount,int ExpectedTaperedCapsuleElementCount) { return default; }
	///<summary>Check whether the static mesh expected number of sockets were imported</summary>
	public static FInterchangeTestFunctionResult CheckSocketCount(UStaticMesh Mesh,int ExpectedSocketCount) { return default; }
	///<summary>Check whether the static mesh given socket index has the expected name</summary>
	public static FInterchangeTestFunctionResult CheckSocketName(UStaticMesh Mesh,int SocketIndex,string ExpectedSocketName) { return default; }
	///<summary>Check whether the static mesh given socket index has the expected location</summary>
	public static FInterchangeTestFunctionResult CheckSocketLocation(UStaticMesh Mesh,int SocketIndex,FVector ExpectedSocketLocation) { return default; }
	///<summary>Check whether the static mesh is equivalent to a ground truth asset</summary>
	public static FInterchangeTestFunctionResult CheckAgainstGroundTruth(UStaticMesh Mesh,TSoftObjectPtr<UStaticMesh> MeshToCompare,bool bCheckVertexCountEqual/*=true*/,bool bCheckTriangleCountEqual/*=true*/,bool bCheckUVChannelCountEqual/*=true*/,bool bCheckCollisionPrimitiveCountEqual/*=true*/,bool bCheckVertexPositionsEqual/*=true*/,bool bCheckNormalsEqual/*=true*/) { return default; }
	///<summary>Check whether the static mesh source model has the expected build settings</summary>
	public static FInterchangeTestFunctionResult CheckBuildSettings(UStaticMesh Mesh,int LodIndex,FMeshBuildSettings ExpectedBuildSettings) { return default; }
	///<summary>Check whether the static mesh has the expected Nanite settings</summary>
	public static FInterchangeTestFunctionResult CheckNaniteSettings(UStaticMesh Mesh,FMeshNaniteSettings ExpectedNaniteSettings) { return default; }
}
