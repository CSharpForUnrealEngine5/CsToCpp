#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TraceSourceFilteringProjectSettings.h")]
public partial class UTraceSourceFilteringProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>CookedSourceFilterClasses</summary>
	public TArray<TSoftObjectPtr<UClass>> CookedSourceFilterClasses;
	///<summary>DefaultFilterPreset</summary>
	public TSoftObjectPtr<USourceFilterCollection> DefaultFilterPreset;
}
