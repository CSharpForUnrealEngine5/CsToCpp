#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetNavigation.h")]
public partial class UWidgetNavigation : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Happens when the user presses up arrow, joystick, d-pad.</summary>
	public FWidgetNavigationData Up;
	///<summary>Happens when the user presses down arrow, joystick, d-pad.</summary>
	public FWidgetNavigationData Down;
	///<summary>Happens when the user presses left arrow, joystick, d-pad.</summary>
	public FWidgetNavigationData Left;
	///<summary>Happens when the user presses right arrow, joystick, d-pad.</summary>
	public FWidgetNavigationData Right;
	///<summary>Happens when the user presses Tab.</summary>
	public FWidgetNavigationData Next;
	///<summary>Happens when the user presses Shift+Tab.</summary>
	public FWidgetNavigationData Previous;
}
