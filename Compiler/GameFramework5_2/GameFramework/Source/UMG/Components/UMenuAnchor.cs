#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/MenuAnchor.h")]
///<summary>The Menu Anchor allows you to specify an location that a popup menu should be anchored to,</summary>
public partial class UMenuAnchor : UContentWidget {
// MenuAnchor
	public UObject FGetUserWidget() { return default; }
	public UClass MenuClass;
	public FGetWidget OnGetMenuContentEvent;
	public FGetUserWidget OnGetUserMenuContentEvent;
	public byte Placement;
	public bool bFitInWindow;
	public bool ShouldDeferPaintingAfterWindowContent;
	public bool UseApplicationMenuStack;
	public FOnMenuOpenChangedEvent OnMenuOpenChanged;
	public void SetPlacement(EMenuPlacement InPlacement) {}
	public void FitInWindow(bool bFit) {}
	public void ToggleOpen(bool bFocusOnOpen) {}
	public void Open(bool bFocusMenu) {}
	public void Close() {}
	public bool IsOpen() { return default; }
	public bool ShouldOpenDueToClick() { return default; }
	public FVector2D GetMenuPosition() { return default; }
	public bool HasOpenSubMenus() { return default; }
}
