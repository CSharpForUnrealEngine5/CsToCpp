namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosCollisionEventFilter.h")]
///<summary>Enumeration defining how to sort collision results</summary>
public enum EChaosCollisionSortMethod {
	SortNone=0,
	SortByHighestMass=1,
	SortByHighestSpeed=2,
	SortByHighestImpulse=3,
	SortByNearestFirst=4,
	Count=5,
}
