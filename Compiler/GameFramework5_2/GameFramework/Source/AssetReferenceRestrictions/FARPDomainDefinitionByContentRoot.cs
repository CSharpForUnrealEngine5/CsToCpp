namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AssetReferencingPolicySettings.h")]
public partial struct FARPDomainDefinitionByContentRoot {
	public string DomainName;
	public FText DomainDisplayName;
	public FText ErrorMessageIfUsedElsewhere;
	public TArray<FDirectoryPath> ContentRoots;
	public TArray<string> SpecificAssets;
	public EARPDomainAllowedToReferenceMode ReferenceMode;
	public TArray<string> CanReferenceTheseDomains;
}
