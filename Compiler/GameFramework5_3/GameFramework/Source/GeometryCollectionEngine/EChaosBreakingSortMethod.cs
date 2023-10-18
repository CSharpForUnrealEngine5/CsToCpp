namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosBreakingEventFilter.h")]
///<summary>Enumeration defining how to sort breaking results</summary>
public enum EChaosBreakingSortMethod {
	SortNone=0,
	SortByHighestMass=1,
	SortByHighestSpeed=2,
	SortByNearestFirst=3,
	Count=4,
}
