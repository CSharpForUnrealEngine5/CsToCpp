#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material output expression for writing advanced volumetric material properties.</summary>
[CppInclude("Materials/MaterialExpressionVolumetricAdvancedMaterialOutput.h")]
public partial class UMaterialExpressionVolumetricAdvancedMaterialOutput : UMaterialExpressionCustomOutput {
	///<summary>Parameter &#39;g&#39; input to the phase function  describing how much forward(g&lt;0) or backward (g&gt;0) light scatter around. Valid range is [-1,1]. Defaults to ConstPhaseG from properties panel if not specified. Evaluated per sample if EvaluatePhaseOncePerSample is true.</summary>
	public FExpressionInput PhaseG;
	///<summary>Parameter &#39;g&#39; input to the second phase function  describing how much forward(g&lt;0) or backward (g&gt;0) light scatter around. Valid range is [-1,1]. Defaults to ConstPhaseG2 from properties panel if not specified. Evaluated per sample if EvaluatePhaseOncePerSample is true.</summary>
	public FExpressionInput PhaseG2;
	///<summary>Lerp factor when blending the two phase functions parameterized by G and G2. Valid range is [0,1] Defaults to ConstPhaseBlend from properties panel if not specified. Evaluated per sample if EvaluatePhaseOncePerSample is true.</summary>
	public FExpressionInput PhaseBlend;
	///<summary>Multi-scattering approximation: represents how much contribution each successive octave will add. Evaluated per pixel. Valid range is [0,1], from low to high contribution. Defaults to ConstMultiScatteringContribution from properties panel if not specified. Evaluated per pixel (globally).</summary>
	public FExpressionInput MultiScatteringContribution;
	///<summary>Multi-scattering approximation: represents how much occlusion will be reduced for each successive octave. Evaluated per pixel. Valid range is [0,1], from low to high occlusion. Defaults to ConstMultiScatteringOcclusion from properties panel if not specified. Evaluated per pixel (globally).</summary>
	public FExpressionInput MultiScatteringOcclusion;
	///<summary>Multi-scattering approximation: represents how much the phase will become isotropic for each successive octave. Evaluated per pixel. Valid range is [0,1], from anisotropic to isotropic phase. Defaults to ConstMultiScatteringEccentricity from properties panel if not specified. Evaluated per pixel (globally).</summary>
	public FExpressionInput MultiScatteringEccentricity;
	///<summary>This is a 3-components float vector. The X component must represent the participating medium conservative density. This is used to accelerate the ray marching by early skipping expensive material evaluation. For example, a simple top down 2D density texture would be enough to help by not evaluating the material in empty regions. The Y and Z components can contain parameters that can be recovered during the material evaluation using the VolumetricAdvancedMaterialInput node. Evaluated per sample.</summary>
	public FExpressionInput ConservativeDensity;
	///<summary>Only used if PhaseG is not hooked up. Parameter &#39;g&#39; input to the phase function  describing how much forward(g&lt;0) or backward (g&gt;0) light scatter around.</summary>
	public float ConstPhaseG;
	///<summary>Only used if PhaseG2 is not hooked up. Parameter &#39;g&#39; input to the second phase function  describing how much forward(g&lt;0) or backward (g&gt;0) light scatter around. Valid range is [-1,1].</summary>
	public float ConstPhaseG2;
	///<summary>Only used if PhaseBlend is not hooked up. Lerp factor when blending the two phase functions parameterized by G and G2. Valid range is [0,1].</summary>
	public float ConstPhaseBlend;
	///<summary>Set this to true to force the phase function to be evaluated per sample, instead once per pixel (globally). Per sample evaluation is slower.</summary>
	public bool PerSamplePhaseEvaluation;
	///<summary>How many octave to use for the multiple-scattering approximation. This makes the shader more expensive so you should only use 0 or 1 for better performance, and tweak multiple scattering parameters accordingly. 0 means single scattering only. The maximum value is 2 (expenssive).</summary>
	public uint MultiScatteringApproximationOctaveCount;
	///<summary>Only used if MultiScatteringContribution is not hooked up. Multi-scattering approximation: represents how much contribution each successive octave will add. Valid range is [0,1], from low to high contribution</summary>
	public float ConstMultiScatteringContribution;
	///<summary>Only used if MultiScatteringOcclusion is not hooked up. Multi-scattering approximation: represents how much occlusion will be reduced for each successive octave. Valid range is [0,1], from low to high occlusion.</summary>
	public float ConstMultiScatteringOcclusion;
	///<summary>Only used if MultiScatteringEccentricity is not hooked up. Multi-scattering approximation: represents how much the phase will become isotropic for each successive octave. Valid range is [0,1], from anisotropic to isotropic phase.</summary>
	public float ConstMultiScatteringEccentricity;
	///<summary>Sample the shadowed lighting contribution from the ground onto the medium (single scattering). This adds some costs to the tracing when enabled.</summary>
	public bool bGroundContribution;
	///<summary>Set this for the material to only be considered grey scale, only using the R chanel of the input parameters internally. The lighting will still be colored. This is an optimisation.</summary>
	public bool bGrayScaleMaterial;
	///<summary>Disable this to use the cloud shadow map instead of secondary raymarching. This is usually enough for clouds viewed from the ground and it result in a performance boost. Shadow now have infinite length but also becomes less accurate and gray scale.</summary>
	public bool bRayMarchVolumeShadow;
	///<summary>Set whether multiple scattering contribution entry is clamped in [0,1] or not. When disabled, the artist is in charge for ensuring the visual remain in a reasonable brighness range.</summary>
	public bool bClampMultiScatteringContribution;
}
