#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SourceFilterCollection.h")]
public partial class USourceFilterCollection : UDataAsset {
// SourceFilterCollection
	public TArray<UDataSourceFilter> Filters;
	public TArray<FActorClassFilter> ClassFilters;
	public TArray<string> FilterClasses;
	public TMap<UDataSourceFilter,UDataSourceFilterSet> ChildToParent;
}
