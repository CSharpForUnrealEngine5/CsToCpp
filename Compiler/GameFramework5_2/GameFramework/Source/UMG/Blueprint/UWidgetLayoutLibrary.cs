#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetLayoutLibrary.h")]
public partial class UWidgetLayoutLibrary : UBlueprintFunctionLibrary {
// WidgetLayoutLibrary
	public bool ProjectWorldLocationToWidgetPosition(UObject PlayerController,FVector WorldLocation,FVector2D ScreenPosition,bool bPlayerViewportRelative) { return default; }
	public float GetViewportScale(UObject WorldContextObject) { return default; }
	public FVector2D GetViewportSize(UObject WorldContextObject) { return default; }
	public FGeometry GetViewportWidgetGeometry(UObject WorldContextObject) { return default; }
	public FGeometry GetPlayerScreenWidgetGeometry(UObject PlayerController) { return default; }
	public FVector2D GetMousePositionOnPlatform() { return default; }
	public FVector2D GetMousePositionOnViewport(UObject WorldContextObject) { return default; }
	public bool GetMousePositionScaledByDPI(UObject Player,float LocationX,float LocationY) { return default; }
	public UObject SlotAsBorderSlot(UObject Widget) { return default; }
	public UObject SlotAsCanvasSlot(UObject Widget) { return default; }
	public UObject SlotAsGridSlot(UObject Widget) { return default; }
	public UObject SlotAsHorizontalBoxSlot(UObject Widget) { return default; }
	public UObject SlotAsOverlaySlot(UObject Widget) { return default; }
	public UObject SlotAsUniformGridSlot(UObject Widget) { return default; }
	public UObject SlotAsVerticalBoxSlot(UObject Widget) { return default; }
	public UObject SlotAsScrollBoxSlot(UObject Widget) { return default; }
	public UObject SlotAsSafeBoxSlot(UObject Widget) { return default; }
	public UObject SlotAsScaleBoxSlot(UObject Widget) { return default; }
	public UObject SlotAsSizeBoxSlot(UObject Widget) { return default; }
	public UObject SlotAsWrapBoxSlot(UObject Widget) { return default; }
	public UObject SlotAsWidgetSwitcherSlot(UObject Widget) { return default; }
	public void RemoveAllWidgets(UObject WorldContextObject) {}
}
