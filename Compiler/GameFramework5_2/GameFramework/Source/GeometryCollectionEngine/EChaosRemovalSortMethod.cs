#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosRemovalEventFilter.h")]
///<summary>Enumeration defining how to sort removal results</summary>
public enum EChaosRemovalSortMethod {
	SortNone=0,
	SortByHighestMass=1,
	SortByNearestFirst=2,
	Count=3,
}
