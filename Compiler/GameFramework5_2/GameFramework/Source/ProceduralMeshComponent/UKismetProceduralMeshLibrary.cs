#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("KismetProceduralMeshLibrary.h")]
public partial class UKismetProceduralMeshLibrary : UBlueprintFunctionLibrary {
// KismetProceduralMeshLibrary
	public void GenerateBoxMesh(FVector BoxRadius,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<FVector2D> UVs,TArray<FProcMeshTangent> Tangents) {}
	public void CalculateTangentsForMesh(TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector2D> UVs,TArray<FVector> Normals,TArray<FProcMeshTangent> Tangents) {}
	public void ConvertQuadToTriangles(TArray<int> Triangles,int Vert0,int Vert1,int Vert2,int Vert3) {}
	public void CreateGridMeshTriangles(int NumX,int NumY,bool bWinding,TArray<int> Triangles) {}
	public void CreateGridMeshWelded(int NumX,int NumY,TArray<int> Triangles,TArray<FVector> Vertices,TArray<FVector2D> UVs,float GridSpacing/*=16.0f*/) {}
	public void CreateGridMeshSplit(int NumX,int NumY,TArray<int> Triangles,TArray<FVector> Vertices,TArray<FVector2D> UVs,TArray<FVector2D> UV1s,float GridSpacing/*=16.0f*/) {}
	public void GetSectionFromStaticMesh(UObject InMesh,int LODIndex,int SectionIndex,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<FVector2D> UVs,TArray<FProcMeshTangent> Tangents) {}
	public void CopyProceduralMeshFromStaticMeshComponent(UObject StaticMeshComponent,int LODIndex,UObject ProcMeshComponent,bool bCreateCollision) {}
	public void GetSectionFromProceduralMesh(UObject InProcMesh,int SectionIndex,TArray<FVector> Vertices,TArray<int> Triangles,TArray<FVector> Normals,TArray<FVector2D> UVs,TArray<FProcMeshTangent> Tangents) {}
	public void SliceProceduralMesh(UObject InProcMesh,FVector PlanePosition,FVector PlaneNormal,bool bCreateOtherHalf,UObject OutOtherHalfProcMesh,EProcMeshSliceCapOption CapOption,UObject CapMaterial) {}
}
