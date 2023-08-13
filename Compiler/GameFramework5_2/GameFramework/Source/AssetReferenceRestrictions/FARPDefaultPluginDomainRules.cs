namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetReferencingPolicySettings.h")]
public partial struct FARPDefaultPluginDomainRules {
	public TArray<string> CanReferenceTheseDomains;
	public bool bCanProjectAccessThesePlugins;
	public bool bCanBeSeenByOtherDomainsWithoutDependency;
}
