#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetLayoutLibrary.h")]
public partial class UWidgetLayoutLibrary : UBlueprintFunctionLibrary {
// WidgetLayoutLibrary
	public static bool ProjectWorldLocationToWidgetPosition(APlayerController PlayerController,FVector WorldLocation,FVector2D ScreenPosition,bool bPlayerViewportRelative) { return default; }
	public static float GetViewportScale(UObject WorldContextObject) { return default; }
	public static FVector2D GetViewportSize(UObject WorldContextObject) { return default; }
	public static FGeometry GetViewportWidgetGeometry(UObject WorldContextObject) { return default; }
	public static FGeometry GetPlayerScreenWidgetGeometry(APlayerController PlayerController) { return default; }
	public static FVector2D GetMousePositionOnPlatform() { return default; }
	public static FVector2D GetMousePositionOnViewport(UObject WorldContextObject) { return default; }
	public static bool GetMousePositionScaledByDPI(APlayerController Player,float LocationX,float LocationY) { return default; }
	public static UBorderSlot SlotAsBorderSlot(UWidget Widget) { return default; }
	public static UCanvasPanelSlot SlotAsCanvasSlot(UWidget Widget) { return default; }
	public static UGridSlot SlotAsGridSlot(UWidget Widget) { return default; }
	public static UHorizontalBoxSlot SlotAsHorizontalBoxSlot(UWidget Widget) { return default; }
	public static UOverlaySlot SlotAsOverlaySlot(UWidget Widget) { return default; }
	public static UUniformGridSlot SlotAsUniformGridSlot(UWidget Widget) { return default; }
	public static UVerticalBoxSlot SlotAsVerticalBoxSlot(UWidget Widget) { return default; }
	public static UScrollBoxSlot SlotAsScrollBoxSlot(UWidget Widget) { return default; }
	public static USafeZoneSlot SlotAsSafeBoxSlot(UWidget Widget) { return default; }
	public static UScaleBoxSlot SlotAsScaleBoxSlot(UWidget Widget) { return default; }
	public static USizeBoxSlot SlotAsSizeBoxSlot(UWidget Widget) { return default; }
	public static UWrapBoxSlot SlotAsWrapBoxSlot(UWidget Widget) { return default; }
	public static UWidgetSwitcherSlot SlotAsWidgetSwitcherSlot(UWidget Widget) { return default; }
	public static void RemoveAllWidgets(UObject WorldContextObject) {}
}
