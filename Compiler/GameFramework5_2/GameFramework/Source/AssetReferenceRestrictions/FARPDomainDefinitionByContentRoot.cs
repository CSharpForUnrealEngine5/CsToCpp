#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetReferencingPolicySettings.h")]
public partial struct FARPDomainDefinitionByContentRoot {
// ARPDomainDefinitionByContentRoot
	public string DomainName;
	public string DomainDisplayName;
	public string ErrorMessageIfUsedElsewhere;
	public TArray<FDirectoryPath> ContentRoots;
	public TArray<string> SpecificAssets;
	public EARPDomainAllowedToReferenceMode ReferenceMode;
	public TArray<string> CanReferenceTheseDomains;
}
