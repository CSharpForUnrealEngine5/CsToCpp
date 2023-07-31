#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/Navigation/NavigationTypes.h")]
[CppEnumInNamespace]
public enum ENavPathEvent {
	Cleared=0,
	NewPath=1,
	UpdatedDueToGoalMoved=2,
	UpdatedDueToNavigationChanged=3,
	Invalidated=4,
	RePathFailed=5,
	MetaPathUpdate=6,
	Custom=7,
}
