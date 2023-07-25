#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosTrailingEventFilter.h")]
///<summary>Enumeration defining how to sort trailing results</summary>
public enum EChaosTrailingSortMethod {
	SortNone=0,
	SortByHighestMass=1,
	SortByHighestSpeed=2,
	SortByNearestFirst=3,
	Count=4,
}
