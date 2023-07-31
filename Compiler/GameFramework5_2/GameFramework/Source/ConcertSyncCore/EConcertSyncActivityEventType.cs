#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
