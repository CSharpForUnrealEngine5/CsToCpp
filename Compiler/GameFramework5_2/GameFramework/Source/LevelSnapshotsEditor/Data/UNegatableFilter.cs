#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/Filters/NegatableFilter.h")]
///<summary>* Calls a child filter and possibly negates its results.</summary>
public partial class UNegatableFilter : ULevelSnapshotFilter {
// NegatableFilter
	public string Name;
	public EFilterBehavior FilterBehavior;
	public bool bIgnoreFilter;
	public ULevelSnapshotFilter ChildFilter;
}
