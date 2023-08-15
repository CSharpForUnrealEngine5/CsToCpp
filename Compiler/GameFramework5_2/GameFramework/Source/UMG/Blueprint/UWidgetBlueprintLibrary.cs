namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/WidgetBlueprintLibrary.h")]
public partial class UWidgetBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Creates a widget</summary>
	public static UUserWidget Create(UObject WorldContextObject,UClass WidgetType,APlayerController OwningPlayer) { return default; }
	///<summary>Creates a new drag and drop operation that can be returned from a drag begin to inform the UI what i</summary>
	public static UDragDropOperation CreateDragDropOperation(UClass OperationClass) { return default; }
	///<summary>Setup an input mode that allows only the UI to respond to user input.</summary>
	public static void SetInputMode_UIOnlyEx(APlayerController PlayerController,UWidget InWidgetToFocus/*=nullptr*/,EMouseLockMode InMouseLockMode/*=EMouseLockMode.DoNotLock*/,bool bFlushInput/*=false*/) {}
	///<summary>Setup an input mode that allows only the UI to respond to user input, and if the UI doesn&#39;t handle it player input / player controller gets a chance.</summary>
	public static void SetInputMode_GameAndUIEx(APlayerController PlayerController,UWidget InWidgetToFocus/*=nullptr*/,EMouseLockMode InMouseLockMode/*=EMouseLockMode.DoNotLock*/,bool bHideCursorDuringCapture/*=true*/,bool bFlushInput/*=false*/) {}
	///<summary>Setup an input mode that allows only player input / player controller to respond to user input.</summary>
	public static void SetInputMode_GameOnly(APlayerController PlayerController,bool bFlushInput/*=false*/) {}
	///<summary>SetFocusToGameViewport</summary>
	public static void SetFocusToGameViewport() {}
	///<summary>Draws a box</summary>
	public static void DrawBox(FPaintContext Context,FVector2D Position,FVector2D Size,USlateBrushAsset Brush,FLinearColor Tint/*=FLinearColor.White*/) {}
	///<summary>Draws a hermite spline.</summary>
	public static void DrawSpline(FPaintContext Context,FVector2D Start,FVector2D StartDir,FVector2D End,FVector2D EndDir,FLinearColor Tint/*=FLinearColor.White*/,float Thickness/*=1.0f*/) {}
	///<summary>Draws a line.</summary>
	public static void DrawLine(FPaintContext Context,FVector2D PositionA,FVector2D PositionB,FLinearColor Tint/*=FLinearColor.White*/,bool bAntiAlias/*=true*/,float Thickness/*=1.0f*/) {}
	///<summary>Draws several line segments.</summary>
	public static void DrawLines(FPaintContext Context,TArray<FVector2D> Points,FLinearColor Tint/*=FLinearColor.White*/,bool bAntiAlias/*=true*/,float Thickness/*=1.0f*/) {}
	///<summary>Draws text.</summary>
	public static void DrawText(FPaintContext Context,string InString,FVector2D Position,FLinearColor Tint/*=FLinearColor.White*/) {}
	///<summary>Draws text.</summary>
	public static void DrawTextFormatted(FPaintContext Context,FText Text,FVector2D Position,UFont Font,int FontSize/*=16*/,FName FontTypeFace/*=new FName(TEXT("Regular"))*/,FLinearColor Tint/*=FLinearColor.White*/) {}
	///<summary>The event reply to use when you choose to handle an event.  This will prevent the event</summary>
	public static FEventReply Handled() { return default; }
	///<summary>The event reply to use when you choose not to handle an event.</summary>
	public static FEventReply Unhandled() { return default; }
	///<summary>CaptureMouse</summary>
	public static FEventReply CaptureMouse(FEventReply Reply,UWidget CapturingWidget) { return default; }
	///<summary>ReleaseMouseCapture</summary>
	public static FEventReply ReleaseMouseCapture(FEventReply Reply) { return default; }
	///<summary>LockMouse</summary>
	public static FEventReply LockMouse(FEventReply Reply,UWidget CapturingWidget) { return default; }
	///<summary>UnlockMouse</summary>
	public static FEventReply UnlockMouse(FEventReply Reply) { return default; }
	///<summary>SetUserFocus</summary>
	public static FEventReply SetUserFocus(FEventReply Reply,UWidget FocusWidget,bool bInAllUsers/*=false*/) { return default; }
	///<summary>CaptureJoystick</summary>
	public static FEventReply CaptureJoystick(FEventReply Reply,UWidget CapturingWidget,bool bInAllJoysticks/*=false*/) { return default; }
	///<summary>ClearUserFocus</summary>
	public static FEventReply ClearUserFocus(FEventReply Reply,bool bInAllUsers/*=false*/) { return default; }
	///<summary>ReleaseJoystickCapture</summary>
	public static FEventReply ReleaseJoystickCapture(FEventReply Reply,bool bInAllJoysticks/*=false*/) { return default; }
	///<summary>SetMousePosition</summary>
	public static FEventReply SetMousePosition(FEventReply Reply,FVector2D NewMousePosition) { return default; }
	///<summary>Ask Slate to detect if a user starts dragging in this widget later.  Slate internally tracks the movement</summary>
	public static FEventReply DetectDrag(FEventReply Reply,UWidget WidgetDetectingDrag,FKey DragKey) { return default; }
	///<summary>Given the pointer event, emit the DetectDrag reply if the provided key was pressed.</summary>
	public static FEventReply DetectDragIfPressed(FPointerEvent PointerEvent,UWidget WidgetDetectingDrag,FKey DragKey) { return default; }
	///<summary>An event should return FReply::Handled().EndDragDrop() to request that the current drag/drop operation be terminated.</summary>
	public static FEventReply EndDragDrop(FEventReply Reply) { return default; }
	///<summary>Returns true if a drag/drop event is occurring that a widget can handle.</summary>
	public static bool IsDragDropping() { return default; }
	///<summary>Returns the drag and drop operation that is currently occurring if any, otherwise nothing.</summary>
	public static UDragDropOperation GetDragDroppingContent() { return default; }
	///<summary>Cancels any current drag drop operation.</summary>
	public static void CancelDragDrop() {}
	///<summary>Creates a Slate Brush from a Slate Brush Asset</summary>
	public static FSlateBrush MakeBrushFromAsset(USlateBrushAsset BrushAsset) { return default; }
	///<summary>Creates a Slate Brush from a Texture2D</summary>
	public static FSlateBrush MakeBrushFromTexture(UTexture2D Texture,int Width/*=0*/,int Height/*=0*/) { return default; }
	///<summary>Creates a Slate Brush from a Material.  Materials don&#39;t have an implicit size, so providing a widget and height</summary>
	public static FSlateBrush MakeBrushFromMaterial(UMaterialInterface Material,int Width/*=32*/,int Height/*=32*/) { return default; }
	///<summary>Gets the resource object on a brush.  This could be a UTexture2D or a UMaterialInterface.</summary>
	public static UObject GetBrushResource(FSlateBrush Brush) { return default; }
	///<summary>Gets the brush resource as a texture 2D.</summary>
	public static UTexture2D GetBrushResourceAsTexture2D(FSlateBrush Brush) { return default; }
	///<summary>Gets the brush resource as a material.</summary>
	public static UMaterialInterface GetBrushResourceAsMaterial(FSlateBrush Brush) { return default; }
	///<summary>Sets the resource on a brush to be a UTexture2D.</summary>
	public static void SetBrushResourceToTexture(FSlateBrush Brush,UTexture2D Texture) {}
	///<summary>Sets the resource on a brush to be a Material.</summary>
	public static void SetBrushResourceToMaterial(FSlateBrush Brush,UMaterialInterface Material) {}
	///<summary>Creates a Slate Brush that wont draw anything, the &quot;Null Brush&quot;.</summary>
	public static FSlateBrush NoResourceBrush() { return default; }
	///<summary>Gets the material that allows changes to parameters at runtime.  The brush must already have a material assigned to it,</summary>
	public static UMaterialInstanceDynamic GetDynamicMaterial(FSlateBrush Brush) { return default; }
	///<summary>Closes any popup menu</summary>
	public static void DismissAllMenus() {}
	///<summary>Find all widgets of a certain class.</summary>
	public static void GetAllWidgetsOfClass(UObject WorldContextObject,TArray<UUserWidget> FoundWidgets,UClass WidgetClass,bool TopLevelOnly/*=true*/) {}
	///<summary>Find all widgets in the world with the specified interface.</summary>
	public static void GetAllWidgetsWithInterface(UObject WorldContextObject,TArray<UUserWidget> FoundWidgets,UClass Interface,bool TopLevelOnly) {}
	///<summary>GetInputEventFromKeyEvent</summary>
	public static FInputEvent GetInputEventFromKeyEvent(FKeyEvent Event) { return default; }
	///<summary>GetKeyEventFromAnalogInputEvent</summary>
	public static FKeyEvent GetKeyEventFromAnalogInputEvent(FAnalogInputEvent Event) { return default; }
	///<summary>GetInputEventFromCharacterEvent</summary>
	public static FInputEvent GetInputEventFromCharacterEvent(FCharacterEvent Event) { return default; }
	///<summary>GetInputEventFromPointerEvent</summary>
	public static FInputEvent GetInputEventFromPointerEvent(FPointerEvent Event) { return default; }
	///<summary>GetInputEventFromNavigationEvent</summary>
	public static FInputEvent GetInputEventFromNavigationEvent(FNavigationEvent Event) { return default; }
	///<summary>Gets the amount of padding that needs to be added when accounting for the safe zone on TVs.</summary>
	public static void GetSafeZonePadding(UObject WorldContextObject,FVector4 SafePadding,FVector2D SafePaddingScale,FVector4 SpillOverPadding) {}
	///<summary>Apply color deficiency correction settings to the game window</summary>
	public static void SetColorVisionDeficiencyType(EColorVisionDeficiency Type,float Severity,bool CorrectDeficiency,bool ShowCorrectionWithDeficiency) {}
	///<summary>Loads or sets a hardware cursor from the content directory in the game.</summary>
	public static bool SetHardwareCursor(UObject WorldContextObject,EMouseCursor CursorShape,FName CursorName,FVector2D HotSpot) { return default; }
	///<summary>SetWindowTitleBarState</summary>
	public static void SetWindowTitleBarState(UWidget TitleBarContent,EWindowTitleBarMode Mode,bool bTitleBarDragEnabled,bool bWindowButtonsVisible,bool bTitleBarVisible) {}
	///<summary>RestorePreviousWindowTitleBarState</summary>
	public static void RestorePreviousWindowTitleBarState() {}
	///<summary>FOnGameWindowCloseButtonClickedDelegate</summary>
	public void FOnGameWindowCloseButtonClickedDelegate() {}
	///<summary>SetWindowTitleBarOnCloseClickedDelegate</summary>
	public static void SetWindowTitleBarOnCloseClickedDelegate(FOnGameWindowCloseButtonClickedDelegate Delegate) {}
	///<summary>SetWindowTitleBarCloseButtonActive</summary>
	public static void SetWindowTitleBarCloseButtonActive(bool bActive) {}
}
