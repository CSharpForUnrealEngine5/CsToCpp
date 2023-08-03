#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KismetProceduralMeshLibrary.h")]
public partial class UKismetProceduralMeshLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Generate vertex and index buffer for a simple box, given the supplied dimensions. Normals, UVs and tangents are also generated for each vertex.</summary>
	public static void GenerateBoxMesh(FVector BoxRadius,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<FVector2D> UVs,TArray<FProcMeshTangent> Tangents) {}
	///<summary>Automatically generate normals and tangent vectors for a mesh</summary>
	public static void CalculateTangentsForMesh(TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector2D> UVs,TArray<FVector> Normals,TArray<FProcMeshTangent> Tangents) {}
	///<summary>Add a quad, specified by four indices, to a triangle index buffer as two triangles.</summary>
	public static void ConvertQuadToTriangles(TArray<int> Triangles,int Vert0,int Vert1,int Vert2,int Vert3) {}
	///<summary>Generate an index buffer for a grid of quads.</summary>
	public static void CreateGridMeshTriangles(int NumX,int NumY,bool bWinding,TArray<int> Triangles) {}
	///<summary>Generate a vertex buffer, index buffer and UVs for a tessellated grid mesh.</summary>
	public static void CreateGridMeshWelded(int NumX,int NumY,TArray<int> Triangles,TArray<FVector> Vertices,TArray<FVector2D> UVs,float GridSpacing/*=16.0f*/) {}
	///<summary>Generate a vertex buffer, index buffer and UVs for a grid mesh where each quad is split, with standard 0-1 UVs on UV0 and point sampled texel center UVs for UV1.</summary>
	public static void CreateGridMeshSplit(int NumX,int NumY,TArray<int> Triangles,TArray<FVector> Vertices,TArray<FVector2D> UVs,TArray<FVector2D> UV1s,float GridSpacing/*=16.0f*/) {}
	///<summary>Grab geometry data from a StaticMesh asset.</summary>
	public static void GetSectionFromStaticMesh(UStaticMesh InMesh,int LODIndex,int SectionIndex,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<FVector2D> UVs,TArray<FProcMeshTangent> Tangents) {}
	///<summary>Copy materials from StaticMeshComponent to ProceduralMeshComponent.</summary>
	public static void CopyProceduralMeshFromStaticMeshComponent(UStaticMeshComponent StaticMeshComponent,int LODIndex,UProceduralMeshComponent ProcMeshComponent,bool bCreateCollision) {}
	///<summary>Grab geometry data from a ProceduralMeshComponent.</summary>
	public static void GetSectionFromProceduralMesh(UProceduralMeshComponent InProcMesh,int SectionIndex,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<FVector2D> UVs,TArray<FProcMeshTangent> Tangents) {}
	///<summary>Slice the ProceduralMeshComponent (including simple convex collision) using a plane. Optionally create &#39;cap&#39; geometry.</summary>
	public static void SliceProceduralMesh(UProceduralMeshComponent InProcMesh,FVector PlanePosition,FVector PlaneNormal,bool bCreateOtherHalf,UProceduralMeshComponent OutOtherHalfProcMesh,EProcMeshSliceCapOption CapOption,UMaterialInterface CapMaterial) {}
}
