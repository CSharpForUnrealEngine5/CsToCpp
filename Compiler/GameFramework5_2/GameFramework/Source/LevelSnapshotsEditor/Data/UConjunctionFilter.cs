#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Returns the result of and-ing all child filters.</summary>
[CppInclude("Data/Filters/ConjunctionFilter.h")]
public partial class UConjunctionFilter : ULevelSnapshotFilter {
	public static UClass StaticClass() {return default;}
	///<summary>Children</summary>
	public TArray<UNegatableFilter> Children;
	///<summary>bIgnoreFilter</summary>
	public bool bIgnoreFilter;
}
