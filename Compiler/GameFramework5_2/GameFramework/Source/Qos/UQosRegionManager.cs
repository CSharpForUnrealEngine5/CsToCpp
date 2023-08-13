namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Main Qos interface for actions related to server quality of service</summary>
[CppInclude("QosRegionManager.h")]
public partial class UQosRegionManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Number of times to ping a given region using random sampling of available servers</summary>
	public int NumTestsPerRegion;
	///<summary>Timeout value for each ping request</summary>
	public float PingTimeout;
	///<summary>Global switch to enable/disable sorting of QoS datacenter results using rules-based comparison,</summary>
	public bool bEnableSubspaceBiasOrder;
	///<summary>Delimiter string that identifies a subspace datacenter ID.</summary>
	public string SubspaceDelimiter;
	///<summary>Metadata about existing regions</summary>
	public TArray<FQosRegionInfo> RegionDefinitions;
	///<summary>Metadata about datacenters within existing regions</summary>
	public TArray<FQosDatacenterInfo> DatacenterDefinitions;
	///<summary>LastCheckTimestamp</summary>
	public FDateTime LastCheckTimestamp;
	///<summary>Reference to the evaluator for making datacenter determinations (null when not active)</summary>
	public UQosEvaluator Evaluator;
	///<summary>Result of the last datacenter test</summary>
	public EQosCompletionResult QosEvalResult;
	///<summary>Array of all known regions and the datacenters in them</summary>
	public TArray<FRegionQosInstance> RegionOptions;
	///<summary>Value forced to be the region (development)</summary>
	public string ForceRegionId;
	///<summary>Was the region forced via commandline</summary>
	public bool bRegionForcedViaCommandline;
	///<summary>Value set by the game to be the current region</summary>
	public string SelectedRegionId;
}
