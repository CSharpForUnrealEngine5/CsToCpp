#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Calls a child filter and possibly negates its results.</summary>
[CppInclude("Data/Filters/NegatableFilter.h")]
public partial class UNegatableFilter : ULevelSnapshotFilter {
	///<summary>Display name in editor. Defaults to class name if left empty.</summary>
	public string Name;
	///<summary>Whether to pass on the result of the filter, negate it, or ignore it.</summary>
	public EFilterBehavior FilterBehavior;
	///<summary>Whether this filter should be ignored</summary>
	public bool bIgnoreFilter;
	///<summary>ChildFilter</summary>
	public ULevelSnapshotFilter ChildFilter;
}
