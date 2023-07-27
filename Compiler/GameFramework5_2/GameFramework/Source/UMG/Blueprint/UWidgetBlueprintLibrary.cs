#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetBlueprintLibrary.h")]
public partial class UWidgetBlueprintLibrary : UBlueprintFunctionLibrary {
// WidgetBlueprintLibrary
	public static UUserWidget Create(UObject WorldContextObject,UClass WidgetType,APlayerController OwningPlayer) { return default; }
	public static UDragDropOperation CreateDragDropOperation(UClass OperationClass) { return default; }
	public static void SetInputMode_UIOnlyEx(APlayerController PlayerController,UWidget InWidgetToFocus/*=nullptr*/,EMouseLockMode InMouseLockMode/*=EMouseLockMode.DoNotLock*/,bool bFlushInput/*=false*/) {}
	public static void SetInputMode_GameAndUIEx(APlayerController PlayerController,UWidget InWidgetToFocus/*=nullptr*/,EMouseLockMode InMouseLockMode/*=EMouseLockMode.DoNotLock*/,bool bHideCursorDuringCapture/*=true*/,bool bFlushInput/*=false*/) {}
	public static void SetInputMode_GameOnly(APlayerController PlayerController,bool bFlushInput/*=false*/) {}
	public static void SetFocusToGameViewport() {}
	public static void DrawBox(FPaintContext Context,FVector2D Position,FVector2D Size,USlateBrushAsset Brush,FLinearColor Tint/*=FLinearColor.White*/) {}
	public static void DrawSpline(FPaintContext Context,FVector2D Start,FVector2D StartDir,FVector2D End,FVector2D EndDir,FLinearColor Tint/*=FLinearColor.White*/,float Thickness/*=1.0f*/) {}
	public static void DrawLine(FPaintContext Context,FVector2D PositionA,FVector2D PositionB,FLinearColor Tint/*=FLinearColor.White*/,bool bAntiAlias/*=true*/,float Thickness/*=1.0f*/) {}
	public static void DrawLines(FPaintContext Context,TArray<FVector2D> Points,FLinearColor Tint/*=FLinearColor.White*/,bool bAntiAlias/*=true*/,float Thickness/*=1.0f*/) {}
	public static void DrawText(FPaintContext Context,string InString,FVector2D Position,FLinearColor Tint/*=FLinearColor.White*/) {}
	public static void DrawTextFormatted(FPaintContext Context,string Text,FVector2D Position,UFont Font,int FontSize/*=16*/,string FontTypeFace/*=new FName(TEXT("Regular"))*/,FLinearColor Tint/*=FLinearColor.White*/) {}
	public static FEventReply Handled() { return default; }
	public static FEventReply Unhandled() { return default; }
	public static FEventReply CaptureMouse(FEventReply Reply,UWidget CapturingWidget) { return default; }
	public static FEventReply ReleaseMouseCapture(FEventReply Reply) { return default; }
	public static FEventReply LockMouse(FEventReply Reply,UWidget CapturingWidget) { return default; }
	public static FEventReply UnlockMouse(FEventReply Reply) { return default; }
	public static FEventReply SetUserFocus(FEventReply Reply,UWidget FocusWidget,bool bInAllUsers/*=false*/) { return default; }
	public static FEventReply CaptureJoystick(FEventReply Reply,UWidget CapturingWidget,bool bInAllJoysticks/*=false*/) { return default; }
	public static FEventReply ClearUserFocus(FEventReply Reply,bool bInAllUsers/*=false*/) { return default; }
	public static FEventReply ReleaseJoystickCapture(FEventReply Reply,bool bInAllJoysticks/*=false*/) { return default; }
	public static FEventReply SetMousePosition(FEventReply Reply,FVector2D NewMousePosition) { return default; }
	public static FEventReply DetectDrag(FEventReply Reply,UWidget WidgetDetectingDrag,FKey DragKey) { return default; }
	public static FEventReply DetectDragIfPressed(FPointerEvent PointerEvent,UWidget WidgetDetectingDrag,FKey DragKey) { return default; }
	public static FEventReply EndDragDrop(FEventReply Reply) { return default; }
	public static bool IsDragDropping() { return default; }
	public static UDragDropOperation GetDragDroppingContent() { return default; }
	public static void CancelDragDrop() {}
	public static FSlateBrush MakeBrushFromAsset(USlateBrushAsset BrushAsset) { return default; }
	public static FSlateBrush MakeBrushFromTexture(UTexture2D Texture,int Width/*=0*/,int Height/*=0*/) { return default; }
	public static FSlateBrush MakeBrushFromMaterial(UMaterialInterface Material,int Width/*=32*/,int Height/*=32*/) { return default; }
	public static UObject GetBrushResource(FSlateBrush Brush) { return default; }
	public static UTexture2D GetBrushResourceAsTexture2D(FSlateBrush Brush) { return default; }
	public static UMaterialInterface GetBrushResourceAsMaterial(FSlateBrush Brush) { return default; }
	public static void SetBrushResourceToTexture(FSlateBrush Brush,UTexture2D Texture) {}
	public static void SetBrushResourceToMaterial(FSlateBrush Brush,UMaterialInterface Material) {}
	public static FSlateBrush NoResourceBrush() { return default; }
	public static UMaterialInstanceDynamic GetDynamicMaterial(FSlateBrush Brush) { return default; }
	public static void DismissAllMenus() {}
	public static void GetAllWidgetsOfClass(UObject WorldContextObject,TArray<UUserWidget> FoundWidgets,UClass WidgetClass,bool TopLevelOnly/*=true*/) {}
	public static void GetAllWidgetsWithInterface(UObject WorldContextObject,TArray<UUserWidget> FoundWidgets,UClass Interface,bool TopLevelOnly) {}
	public static FInputEvent GetInputEventFromKeyEvent(FKeyEvent Event) { return default; }
	public static FKeyEvent GetKeyEventFromAnalogInputEvent(FAnalogInputEvent Event) { return default; }
	public static FInputEvent GetInputEventFromCharacterEvent(FCharacterEvent Event) { return default; }
	public static FInputEvent GetInputEventFromPointerEvent(FPointerEvent Event) { return default; }
	public static FInputEvent GetInputEventFromNavigationEvent(FNavigationEvent Event) { return default; }
	public static void GetSafeZonePadding(UObject WorldContextObject,FVector4 SafePadding,FVector2D SafePaddingScale,FVector4 SpillOverPadding) {}
	public static void SetColorVisionDeficiencyType(EColorVisionDeficiency Type,float Severity,bool CorrectDeficiency,bool ShowCorrectionWithDeficiency) {}
	public static bool SetHardwareCursor(UObject WorldContextObject,EMouseCursor CursorShape,string CursorName,FVector2D HotSpot) { return default; }
	public static void SetWindowTitleBarState(UWidget TitleBarContent,EWindowTitleBarMode Mode,bool bTitleBarDragEnabled,bool bWindowButtonsVisible,bool bTitleBarVisible) {}
	public static void RestorePreviousWindowTitleBarState() {}
	public  void FOnGameWindowCloseButtonClickedDelegate() {}
	public static void SetWindowTitleBarOnCloseClickedDelegate(FOnGameWindowCloseButtonClickedDelegate Delegate) {}
	public static void SetWindowTitleBarCloseButtonActive(bool bActive) {}
}
