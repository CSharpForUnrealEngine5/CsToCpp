#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Exposes a bindable event that can be used to stomp default border navigation with custom behaviors.</summary>
[CppInclude("CommonCustomNavigation.h")]
public partial class UCommonCustomNavigation : UBorder {
	public static UClass StaticClass() {return default;}
	///<summary>FOnCustomNavigationEvent</summary>
	public  bool FOnCustomNavigationEvent(EUINavigation NavigationType) { return default; }
	///<summary>Return true if the Navigation has been handled</summary>
	public FOnCustomNavigationEvent OnNavigationEvent;
}
