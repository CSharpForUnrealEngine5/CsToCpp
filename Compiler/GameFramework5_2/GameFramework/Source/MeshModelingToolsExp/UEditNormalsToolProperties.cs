#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditNormalsTool.h")]
///<summary>Standard properties</summary>
public partial class UEditNormalsToolProperties : UInteractiveToolPropertySet {
// EditNormalsToolProperties
	public bool bRecomputeNormals;
	public ENormalCalculationMethod NormalCalculationMethod;
	public bool bFixInconsistentNormals;
	public bool bInvertNormals;
	public ESplitNormalMethod SplitNormalMethod;
	public float SharpEdgeAngleThreshold;
	public bool bAllowSharpVertices;
}
