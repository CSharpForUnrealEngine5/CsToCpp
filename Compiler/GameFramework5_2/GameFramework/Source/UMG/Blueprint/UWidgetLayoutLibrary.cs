#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetLayoutLibrary.h")]
public partial class UWidgetLayoutLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Gets the projected world to screen position for a player, then converts it into a widget</summary>
	public static bool ProjectWorldLocationToWidgetPosition(APlayerController PlayerController,FVector WorldLocation,FVector2D ScreenPosition,bool bPlayerViewportRelative) { return default; }
	///<summary>Gets the current DPI Scale being applied to the viewport and all the Widgets.</summary>
	public static float GetViewportScale(UObject WorldContextObject) { return default; }
	///<summary>Gets the size of the game viewport.</summary>
	public static FVector2D GetViewportSize(UObject WorldContextObject) { return default; }
	///<summary>Gets the geometry of the widget holding all widgets added to the &quot;Viewport&quot;.  You</summary>
	public static FGeometry GetViewportWidgetGeometry(UObject WorldContextObject) { return default; }
	///<summary>Gets the geometry of the widget holding all widgets added to the &quot;Player Screen&quot;. You</summary>
	public static FGeometry GetPlayerScreenWidgetGeometry(APlayerController PlayerController) { return default; }
	///<summary>Gets the platform&#39;s mouse cursor position.  This is the &#39;absolute&#39; desktop location of the mouse.</summary>
	public static FVector2D GetMousePositionOnPlatform() { return default; }
	///<summary>Gets the platform&#39;s mouse cursor position in the local space of the viewport widget.</summary>
	public static FVector2D GetMousePositionOnViewport(UObject WorldContextObject) { return default; }
	///<summary>Gets the mouse position of the player controller, scaled by the DPI.  If you&#39;re trying to go from raw mouse screenspace coordinates</summary>
	public static bool GetMousePositionScaledByDPI(APlayerController Player,float LocationX,float LocationY) { return default; }
	///<summary>Gets the slot object on the child widget as a Border Slot, allowing you to manipulate layout information.</summary>
	public static UBorderSlot SlotAsBorderSlot(UWidget Widget) { return default; }
	///<summary>Gets the slot object on the child widget as a Canvas Slot, allowing you to manipulate layout information.</summary>
	public static UCanvasPanelSlot SlotAsCanvasSlot(UWidget Widget) { return default; }
	///<summary>Gets the slot object on the child widget as a Grid Slot, allowing you to manipulate layout information.</summary>
	public static UGridSlot SlotAsGridSlot(UWidget Widget) { return default; }
	///<summary>Gets the slot object on the child widget as a Horizontal Box Slot, allowing you to manipulate its information.</summary>
	public static UHorizontalBoxSlot SlotAsHorizontalBoxSlot(UWidget Widget) { return default; }
	///<summary>Gets the slot object on the child widget as a Overlay Slot, allowing you to manipulate layout information.</summary>
	public static UOverlaySlot SlotAsOverlaySlot(UWidget Widget) { return default; }
	///<summary>Gets the slot object on the child widget as a Uniform Grid Slot, allowing you to manipulate layout information.</summary>
	public static UUniformGridSlot SlotAsUniformGridSlot(UWidget Widget) { return default; }
	///<summary>Gets the slot object on the child widget as a Vertical Box Slot, allowing you to manipulate its information.</summary>
	public static UVerticalBoxSlot SlotAsVerticalBoxSlot(UWidget Widget) { return default; }
	///<summary>Gets the slot object on the child widget as a Scroll Box Slot, allowing you to manipulate its information.</summary>
	public static UScrollBoxSlot SlotAsScrollBoxSlot(UWidget Widget) { return default; }
	///<summary>Gets the slot object on the child widget as a Safe Box Slot, allowing you to manipulate its information.</summary>
	public static USafeZoneSlot SlotAsSafeBoxSlot(UWidget Widget) { return default; }
	///<summary>Gets the slot object on the child widget as a Scale Box Slot, allowing you to manipulate its information.</summary>
	public static UScaleBoxSlot SlotAsScaleBoxSlot(UWidget Widget) { return default; }
	///<summary>Gets the slot object on the child widget as a Size Box Slot, allowing you to manipulate its information.</summary>
	public static USizeBoxSlot SlotAsSizeBoxSlot(UWidget Widget) { return default; }
	///<summary>Gets the slot object on the child widget as a Wrap Box Slot, allowing you to manipulate its information.</summary>
	public static UWrapBoxSlot SlotAsWrapBoxSlot(UWidget Widget) { return default; }
	///<summary>Gets the slot object on the child widget as a Widget Switcher Slot, allowing you to manipulate its information.</summary>
	public static UWidgetSwitcherSlot SlotAsWidgetSwitcherSlot(UWidget Widget) { return default; }
	///<summary>Removes all widgets from the viewport.</summary>
	public static void RemoveAllWidgets(UObject WorldContextObject) {}
}
