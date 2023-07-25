#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetBlueprintLibrary.h")]
public partial class UWidgetBlueprintLibrary : UBlueprintFunctionLibrary {
// WidgetBlueprintLibrary
	public UObject Create(UObject WorldContextObject,UClass WidgetType,UObject OwningPlayer) { return default; }
	public UObject CreateDragDropOperation(UClass OperationClass) { return default; }
	public void SetInputMode_UIOnlyEx(UObject PlayerController,UObject InWidgetToFocus/*=nullptr*/,EMouseLockMode InMouseLockMode/*=EMouseLockMode.DoNotLock*/,bool bFlushInput/*=false*/) {}
	public void SetInputMode_GameAndUIEx(UObject PlayerController,UObject InWidgetToFocus/*=nullptr*/,EMouseLockMode InMouseLockMode/*=EMouseLockMode.DoNotLock*/,bool bHideCursorDuringCapture/*=true*/,bool bFlushInput/*=false*/) {}
	public void SetInputMode_GameOnly(UObject PlayerController,bool bFlushInput/*=false*/) {}
	public void SetFocusToGameViewport() {}
	public void DrawBox(FPaintContext Context,FVector2D Position,FVector2D Size,UObject Brush,FLinearColor Tint/*=FLinearColor.White*/) {}
	public void DrawSpline(FPaintContext Context,FVector2D Start,FVector2D StartDir,FVector2D End,FVector2D EndDir,FLinearColor Tint/*=FLinearColor.White*/,float Thickness/*=1.0f*/) {}
	public void DrawLine(FPaintContext Context,FVector2D PositionA,FVector2D PositionB,FLinearColor Tint/*=FLinearColor.White*/,bool bAntiAlias/*=true*/,float Thickness/*=1.0f*/) {}
	public void DrawLines(FPaintContext Context,TArray<FVector2D> Points,FLinearColor Tint/*=FLinearColor.White*/,bool bAntiAlias/*=true*/,float Thickness/*=1.0f*/) {}
	public void DrawText(FPaintContext Context,string InString,FVector2D Position,FLinearColor Tint/*=FLinearColor.White*/) {}
	public void DrawTextFormatted(FPaintContext Context,string Text,FVector2D Position,UObject Font,int FontSize/*=16*/,string FontTypeFace/*=new FName(TEXT("Regular"))*/,FLinearColor Tint/*=FLinearColor.White*/) {}
	public FEventReply Handled() { return default; }
	public FEventReply Unhandled() { return default; }
	public FEventReply CaptureMouse(FEventReply Reply,UObject CapturingWidget) { return default; }
	public FEventReply ReleaseMouseCapture(FEventReply Reply) { return default; }
	public FEventReply LockMouse(FEventReply Reply,UObject CapturingWidget) { return default; }
	public FEventReply UnlockMouse(FEventReply Reply) { return default; }
	public FEventReply SetUserFocus(FEventReply Reply,UObject FocusWidget,bool bInAllUsers/*=false*/) { return default; }
	public FEventReply CaptureJoystick(FEventReply Reply,UObject CapturingWidget,bool bInAllJoysticks/*=false*/) { return default; }
	public FEventReply ClearUserFocus(FEventReply Reply,bool bInAllUsers/*=false*/) { return default; }
	public FEventReply ReleaseJoystickCapture(FEventReply Reply,bool bInAllJoysticks/*=false*/) { return default; }
	public FEventReply SetMousePosition(FEventReply Reply,FVector2D NewMousePosition) { return default; }
	public FEventReply DetectDrag(FEventReply Reply,UObject WidgetDetectingDrag,FKey DragKey) { return default; }
	public FEventReply DetectDragIfPressed(FPointerEvent PointerEvent,UObject WidgetDetectingDrag,FKey DragKey) { return default; }
	public FEventReply EndDragDrop(FEventReply Reply) { return default; }
	public bool IsDragDropping() { return default; }
	public UObject GetDragDroppingContent() { return default; }
	public void CancelDragDrop() {}
	public FSlateBrush MakeBrushFromAsset(UObject BrushAsset) { return default; }
	public FSlateBrush MakeBrushFromTexture(UObject Texture,int Width/*=0*/,int Height/*=0*/) { return default; }
	public FSlateBrush MakeBrushFromMaterial(UObject Material,int Width/*=32*/,int Height/*=32*/) { return default; }
	public UObject GetBrushResource(FSlateBrush Brush) { return default; }
	public UObject GetBrushResourceAsTexture2D(FSlateBrush Brush) { return default; }
	public UObject GetBrushResourceAsMaterial(FSlateBrush Brush) { return default; }
	public void SetBrushResourceToTexture(FSlateBrush Brush,UObject Texture) {}
	public void SetBrushResourceToMaterial(FSlateBrush Brush,UObject Material) {}
	public FSlateBrush NoResourceBrush() { return default; }
	public UObject GetDynamicMaterial(FSlateBrush Brush) { return default; }
	public void DismissAllMenus() {}
	public void GetAllWidgetsOfClass(UObject WorldContextObject,TArray<UObject> FoundWidgets,UClass WidgetClass,bool TopLevelOnly/*=true*/) {}
	public void GetAllWidgetsWithInterface(UObject WorldContextObject,TArray<UObject> FoundWidgets,UClass Interface,bool TopLevelOnly) {}
	public FInputEvent GetInputEventFromKeyEvent(FKeyEvent Event) { return default; }
	public FKeyEvent GetKeyEventFromAnalogInputEvent(FAnalogInputEvent Event) { return default; }
	public FInputEvent GetInputEventFromCharacterEvent(FCharacterEvent Event) { return default; }
	public FInputEvent GetInputEventFromPointerEvent(FPointerEvent Event) { return default; }
	public FInputEvent GetInputEventFromNavigationEvent(FNavigationEvent Event) { return default; }
	public void GetSafeZonePadding(UObject WorldContextObject,FVector4 SafePadding,FVector2D SafePaddingScale,FVector4 SpillOverPadding) {}
	public void SetColorVisionDeficiencyType(EColorVisionDeficiency Type,float Severity,bool CorrectDeficiency,bool ShowCorrectionWithDeficiency) {}
	public bool SetHardwareCursor(UObject WorldContextObject,EMouseCursor CursorShape,string CursorName,FVector2D HotSpot) { return default; }
	public void SetWindowTitleBarState(UObject TitleBarContent,EWindowTitleBarMode Mode,bool bTitleBarDragEnabled,bool bWindowButtonsVisible,bool bTitleBarVisible) {}
	public void RestorePreviousWindowTitleBarState() {}
	public void FOnGameWindowCloseButtonClickedDelegate() {}
	public void SetWindowTitleBarOnCloseClickedDelegate(FOnGameWindowCloseButtonClickedDelegate Delegate) {}
	public void SetWindowTitleBarCloseButtonActive(bool bActive) {}
}
