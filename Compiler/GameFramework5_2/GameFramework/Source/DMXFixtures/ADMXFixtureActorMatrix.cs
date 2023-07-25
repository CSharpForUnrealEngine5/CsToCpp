#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXFixtureActorMatrix.h")]
public partial class ADMXFixtureActorMatrix : ADMXFixtureActor {
// DMXFixtureActorMatrix
	public UProceduralMeshComponent MatrixHead;
	public float MatrixWidth;
	public float MatrixHeight;
	public float MatrixDepth;
	public bool bIgnorePixelMappingDistributionOfFixturePatch;
	public void PushFixtureMatrixCellData(TArray<FDMXCell> MatrixPixelData) {}
	public void InitializeMatrixFixture() {}
	public void GenerateEditorMatrixMesh() {}
}
