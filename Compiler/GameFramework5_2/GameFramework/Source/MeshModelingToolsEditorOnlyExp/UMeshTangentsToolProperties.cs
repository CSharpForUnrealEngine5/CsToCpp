#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshTangentsTool.h")]
public partial class UMeshTangentsToolProperties : UInteractiveToolPropertySet {
// MeshTangentsToolProperties
	public EMeshTangentsType CalculationMethod;
	public bool bShowTangents;
	public bool bShowNormals;
	public float LineLength;
	public float LineThickness;
	public bool bShowDegenerates;
	public bool bCompareWithMikkt;
	public float CompareWithMikktThreshold;
}
