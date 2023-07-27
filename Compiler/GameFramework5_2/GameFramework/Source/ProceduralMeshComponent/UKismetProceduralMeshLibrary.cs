#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KismetProceduralMeshLibrary.h")]
public partial class UKismetProceduralMeshLibrary : UBlueprintFunctionLibrary {
// KismetProceduralMeshLibrary
	public static void GenerateBoxMesh(FVector BoxRadius,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<FVector2D> UVs,TArray<FProcMeshTangent> Tangents) {}
	public static void CalculateTangentsForMesh(TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector2D> UVs,TArray<FVector> Normals,TArray<FProcMeshTangent> Tangents) {}
	public static void ConvertQuadToTriangles(TArray<int> Triangles,int Vert0,int Vert1,int Vert2,int Vert3) {}
	public static void CreateGridMeshTriangles(int NumX,int NumY,bool bWinding,TArray<int> Triangles) {}
	public static void CreateGridMeshWelded(int NumX,int NumY,TArray<int> Triangles,TArray<FVector> Vertices,TArray<FVector2D> UVs,float GridSpacing/*=16.0f*/) {}
	public static void CreateGridMeshSplit(int NumX,int NumY,TArray<int> Triangles,TArray<FVector> Vertices,TArray<FVector2D> UVs,TArray<FVector2D> UV1s,float GridSpacing/*=16.0f*/) {}
	public static void GetSectionFromStaticMesh(UStaticMesh InMesh,int LODIndex,int SectionIndex,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<FVector2D> UVs,TArray<FProcMeshTangent> Tangents) {}
	public static void CopyProceduralMeshFromStaticMeshComponent(UStaticMeshComponent StaticMeshComponent,int LODIndex,UProceduralMeshComponent ProcMeshComponent,bool bCreateCollision) {}
	public static void GetSectionFromProceduralMesh(UProceduralMeshComponent InProcMesh,int SectionIndex,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<FVector2D> UVs,TArray<FProcMeshTangent> Tangents) {}
	public static void SliceProceduralMesh(UProceduralMeshComponent InProcMesh,FVector PlanePosition,FVector PlaneNormal,bool bCreateOtherHalf,UProceduralMeshComponent OutOtherHalfProcMesh,EProcMeshSliceCapOption CapOption,UMaterialInterface CapMaterial) {}
}
