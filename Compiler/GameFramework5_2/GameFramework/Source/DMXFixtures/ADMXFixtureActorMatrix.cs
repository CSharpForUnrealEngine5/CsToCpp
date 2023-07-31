#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXFixtureActorMatrix.h")]
public partial class ADMXFixtureActorMatrix : ADMXFixtureActor {
	///<summary>MatrixHead</summary>
	public UProceduralMeshComponent MatrixHead;
	///<summary>MatrixWidth</summary>
	public float MatrixWidth;
	///<summary>MatrixHeight</summary>
	public float MatrixHeight;
	///<summary>MatrixDepth</summary>
	public float MatrixDepth;
	///<summary>If set to true, ignores the distribution set in the patch (hence the distribution becomes visible when not left to right, top to bottom)</summary>
	public bool bIgnorePixelMappingDistributionOfFixturePatch;
	///<summary>PushFixtureMatrixCellData</summary>
	public  void PushFixtureMatrixCellData(TArray<FDMXCell> MatrixPixelData) {}
	///<summary>InitializeMatrixFixture</summary>
	public  void InitializeMatrixFixture() {}
	///<summary>GenerateEditorMatrixMesh</summary>
	public  void GenerateEditorMatrixMesh() {}
}
