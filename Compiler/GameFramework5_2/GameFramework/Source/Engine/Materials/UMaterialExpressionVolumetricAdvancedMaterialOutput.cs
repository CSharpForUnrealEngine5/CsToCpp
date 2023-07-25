#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionVolumetricAdvancedMaterialOutput.h")]
///<summary>Material output expression for writing advanced volumetric material properties.</summary>
public partial class UMaterialExpressionVolumetricAdvancedMaterialOutput : UMaterialExpressionCustomOutput {
// MaterialExpressionVolumetricAdvancedMaterialOutput
	public FExpressionInput PhaseG;
	public FExpressionInput PhaseG2;
	public FExpressionInput PhaseBlend;
	public FExpressionInput MultiScatteringContribution;
	public FExpressionInput MultiScatteringOcclusion;
	public FExpressionInput MultiScatteringEccentricity;
	public FExpressionInput ConservativeDensity;
	public float ConstPhaseG;
	public float ConstPhaseG2;
	public float ConstPhaseBlend;
	public bool PerSamplePhaseEvaluation;
	public uint MultiScatteringApproximationOctaveCount;
	public float ConstMultiScatteringContribution;
	public float ConstMultiScatteringOcclusion;
	public float ConstMultiScatteringEccentricity;
	public bool bGroundContribution;
	public bool bGrayScaleMaterial;
	public bool bRayMarchVolumeShadow;
	public bool bClampMultiScatteringContribution;
}
