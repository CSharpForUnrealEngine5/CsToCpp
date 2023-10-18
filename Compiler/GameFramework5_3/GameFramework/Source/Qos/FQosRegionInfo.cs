namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Metadata about regions made up of datacenters</summary>
[CppInclude("QosRegionManager.h")]
public partial struct FQosRegionInfo {
	public FText DisplayName;
	public string RegionId;
	public bool bEnabled;
	public bool bVisible;
	public bool bAutoAssignable;
	public bool bAllowSubspaceBias;
	public FQosSubspaceComparisonParams SubspaceBiasParams;
}
