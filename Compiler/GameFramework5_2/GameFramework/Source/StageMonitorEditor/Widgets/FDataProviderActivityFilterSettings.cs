#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Filter settings used live and also load/saved to ini config</summary>
[CppInclude("Widgets/SDataProviderActivityFilter.h")]
public partial struct FDataProviderActivityFilterSettings {
	public TArray<UScriptStruct> ExistingPeriodicTypes;
	public TArray<UScriptStruct> RestrictedTypes;
	public TArray<string> RestrictedProviders;
	public TArray<string> RestrictedRoles;
	public TArray<string> RestrictedSources;
	public bool bEnableCriticalStateFilter;
	public bool bEnableTimeFilter;
	public uint MaxMessageAgeInMinutes;
}
