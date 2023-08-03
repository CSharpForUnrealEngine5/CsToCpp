#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceFilterCollection.h")]
public partial class USourceFilterCollection : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Root-level filter instances</summary>
	public TArray<UDataSourceFilter> Filters;
	///<summary>Class filters, used for high-level filtering of AActor instances inside of a UWorld</summary>
	public TArray<FActorClassFilter> ClassFilters;
	///<summary>Flat version of the Filter classes contained by this collection, stored according to Filters ordering, with child filters inline</summary>
	public TArray<string> FilterClasses;
	///<summary>Child / Parent mapping for Filter (sets)</summary>
	public TMap<UDataSourceFilter,UDataSourceFilterSet> ChildToParent;
}
