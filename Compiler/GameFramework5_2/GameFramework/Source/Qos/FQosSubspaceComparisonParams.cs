#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("QosRegionManager.h")]
///<summary>Parameters to control the rules-based comparison of subspace vs non-subspace datacenter QoS results.</summary>
public partial struct FQosSubspaceComparisonParams {
// QosSubspaceComparisonParams
	public int MaxNonSubspacePingMs;
	public int MinSubspacePingMs;
	public int ConstantMaxToleranceMs;
	public float ScaledMaxTolerancePct;
}
