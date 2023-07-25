#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/Filters/ConjunctionFilter.h")]
///<summary>* Returns the result of and-ing all child filters.</summary>
public partial class UConjunctionFilter : ULevelSnapshotFilter {
// ConjunctionFilter
	public TArray<UNegatableFilter> Children;
	public bool bIgnoreFilter;
}
