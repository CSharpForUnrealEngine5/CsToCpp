namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertSyncSessionTypes.h")]
///<summary>Types of activity events</summary>
public enum EConcertSyncActivityEventType {
	None=0,
	Connection=1,
	Lock=2,
	Transaction=3,
	Package=4,
}
