namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filter settings used live and also load/saved to ini config</summary>
[CppInclude("Widgets/SDataProviderActivityFilter.h")]
public partial struct FDataProviderActivityFilterSettings {
	public TArray<UScriptStruct> ExistingPeriodicTypes;
	public TArray<UScriptStruct> RestrictedTypes;
	public TArray<FName> RestrictedProviders;
	public TArray<FName> RestrictedRoles;
	public TArray<FName> RestrictedSources;
	public bool bEnableCriticalStateFilter;
	public bool bEnableTimeFilter;
	public uint MaxMessageAgeInMinutes;
}
