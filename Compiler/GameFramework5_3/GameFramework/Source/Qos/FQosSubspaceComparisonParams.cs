namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters to control the rules-based comparison of subspace vs non-subspace datacenter QoS results.</summary>
[CppInclude("QosRegionManager.h")]
public partial struct FQosSubspaceComparisonParams {
	public int MaxNonSubspacePingMs;
	public int MinSubspacePingMs;
	public int ConstantMaxToleranceMs;
	public float ScaledMaxTolerancePct;
}
