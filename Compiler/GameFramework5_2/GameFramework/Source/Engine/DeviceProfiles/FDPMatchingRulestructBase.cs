#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DeviceProfiles/DeviceProfileMatching.h")]
public partial struct FDPMatchingRulestructBase {
// DPMatchingRulestructBase
	public string RuleName;
	public TArray<FDPMatchingIfCondition> IfConditions;
	public string AppendFragments;
	public string SetUserVar;
}
