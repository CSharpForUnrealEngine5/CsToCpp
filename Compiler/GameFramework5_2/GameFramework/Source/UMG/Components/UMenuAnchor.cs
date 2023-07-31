#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Menu Anchor allows you to specify an location that a popup menu should be anchored to,</summary>
[CppInclude("Components/MenuAnchor.h")]
public partial class UMenuAnchor : UContentWidget {
	///<summary>FGetUserWidget</summary>
	public  UUserWidget FGetUserWidget() { return default; }
	///<summary>The widget class to spawn when the menu is required.  Creates the widget freshly each time.</summary>
	public UClass MenuClass;
	///<summary>OnGetMenuContentEvent</summary>
	public FGetWidget OnGetMenuContentEvent;
	///<summary>Called when the menu content is requested to allow a more customized handling over what to display</summary>
	public FGetUserWidget OnGetUserMenuContentEvent;
	///<summary>The placement location of the summoned widget.</summary>
	public EMenuPlacement Placement;
	///<summary>Should the menu anchor attempt to fit the menu inside the window.</summary>
	public bool bFitInWindow;
	///<summary>ShouldDeferPaintingAfterWindowContent</summary>
	public bool ShouldDeferPaintingAfterWindowContent;
	///<summary>Does this menu behave like a normal stacked menu? Set it to false to control the menu&#39;s lifetime yourself.</summary>
	public bool UseApplicationMenuStack;
	///<summary>Called when the opened state of the menu changes</summary>
	public FOnMenuOpenChangedEvent OnMenuOpenChanged;
	///<summary>TODO UMG Add Set MenuClass</summary>
	public  void SetPlacement(EMenuPlacement InPlacement) {}
	///<summary>FitInWindow</summary>
	public  void FitInWindow(bool bFit) {}
	///<summary>Toggles the menus open state.</summary>
	public  void ToggleOpen(bool bFocusOnOpen) {}
	///<summary>Opens the menu if it is not already open</summary>
	public  void Open(bool bFocusMenu) {}
	///<summary>Closes the menu if it is currently open.</summary>
	public  void Close() {}
	///<summary>Returns true if the popup is open; false otherwise.</summary>
	public  bool IsOpen() { return default; }
	///<summary>Returns true if we should open the menu due to a click. Sometimes we should not, if</summary>
	public  bool ShouldOpenDueToClick() { return default; }
	///<summary>Returns the current menu position</summary>
	public  FVector2D GetMenuPosition() { return default; }
	///<summary>Returns whether this menu has open submenus</summary>
	public  bool HasOpenSubMenus() { return default; }
}
