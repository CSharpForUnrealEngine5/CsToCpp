namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprints/MPCDIGeometryData.h")]
public partial struct FMPCDIGeometryExportData {
	public TArray<FVector> Vertices;
	public TArray<FVector> Normal;
	public TArray<FVector2D> UV;
	public TArray<int> Triangles;
}
