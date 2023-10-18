namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>namespace UE::AssetRegistry</summary>
[CppInclude("AssetRegistry/IAssetRegistry.h")]
public partial struct FAssetRegistryDependencyOptions {
	public bool bIncludeSoftPackageReferences;
	public bool bIncludeHardPackageReferences;
	public bool bIncludeSearchableNames;
	public bool bIncludeSoftManagementReferences;
	public bool bIncludeHardManagementReferences;
}
