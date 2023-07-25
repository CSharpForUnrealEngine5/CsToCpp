#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/NavigationSystemConfig.h")]
public partial class UNavigationSystemConfig : UObject {
// NavigationSystemConfig
	public FSoftClassPath NavigationSystemClass;
	public FNavAgentSelector SupportedAgentsMask;
	public string DefaultAgentName;
	public bool bIsOverriden;
}
