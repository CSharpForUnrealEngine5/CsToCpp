#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("QosRegionManager.h")]
///<summary>Main Qos interface for actions related to server quality of service</summary>
public partial class UQosRegionManager : UObject {
// QosRegionManager
	public int NumTestsPerRegion;
	public float PingTimeout;
	public bool bEnableSubspaceBiasOrder;
	public string SubspaceDelimiter;
	public TArray<FQosRegionInfo> RegionDefinitions;
	public TArray<FQosDatacenterInfo> DatacenterDefinitions;
	public FDateTime LastCheckTimestamp;
	public UQosEvaluator Evaluator;
	public EQosCompletionResult QosEvalResult;
	public TArray<FRegionQosInstance> RegionOptions;
	public string ForceRegionId;
	public bool bRegionForcedViaCommandline;
	public string SelectedRegionId;
}
