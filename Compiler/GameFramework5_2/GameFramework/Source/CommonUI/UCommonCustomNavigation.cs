#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonCustomNavigation.h")]
///<summary>Exposes a bindable event that can be used to stomp default border navigation with custom behaviors.</summary>
public partial class UCommonCustomNavigation : UBorder {
// CommonCustomNavigation
	public bool FOnCustomNavigationEvent(EUINavigation NavigationType) { return default; }
	public FOnCustomNavigationEvent OnNavigationEvent;
}
