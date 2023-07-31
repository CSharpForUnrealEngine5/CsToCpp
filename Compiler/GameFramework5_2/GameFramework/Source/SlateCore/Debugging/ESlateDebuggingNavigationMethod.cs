#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Debugging/SlateDebugging.h")]
public enum ESlateDebuggingNavigationMethod {
	Unknown=0,
	Explicit=1,
	CustomDelegateBound=2,
	CustomDelegateUnbound=3,
	NextOrPrevious=4,
	HitTestGrid=5,
}
