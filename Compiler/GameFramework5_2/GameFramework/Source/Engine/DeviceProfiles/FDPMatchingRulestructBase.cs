#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DeviceProfiles/DeviceProfileMatching.h")]
public partial struct FDPMatchingRulestructBase {
	public string RuleName;
	public TArray<FDPMatchingIfCondition> IfConditions;
	public string AppendFragments;
	public string SetUserVar;
}
