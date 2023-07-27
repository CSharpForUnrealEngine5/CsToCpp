#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/UserWidget.h")]
///<summary>The user widget is extensible by users through the WidgetBlueprint.</summary>
public partial class UUserWidget : UWidget {
// UserWidget
	public  void AddToViewport(int ZOrder/*=0*/) {}
	public  bool AddToPlayerScreen(int ZOrder/*=0*/) { return default; }
	public  void RemoveFromViewport() {}
	public  void SetPositionInViewport(FVector2D Position,bool bRemoveDPIScale/*=true*/) {}
	public  void SetDesiredSizeInViewport(FVector2D Size) {}
	public  void SetAnchorsInViewport(FAnchors Anchors) {}
	public  void SetAlignmentInViewport(FVector2D Alignment) {}
	public  FAnchors GetAnchorsInViewport() { return default; }
	public  FVector2D GetAlignmentInViewport() { return default; }
	public  bool GetIsVisible() { return default; }
	public  void SetOwningPlayer(APlayerController LocalPlayerController) {}
	public  APawn GetOwningPlayerPawn() { return default; }
	public  APlayerCameraManager GetOwningPlayerCameraManager() { return default; }
	public  void OnInitialized() {}
	public  void PreConstruct(bool IsDesignTime) {}
	public  void Construct() {}
	public  void Destruct() {}
	public  void Tick(FGeometry MyGeometry,float InDeltaTime) {}
	public  void OnPaint(FPaintContext Context) {}
	public  bool IsInteractable() { return default; }
	public  FEventReply OnFocusReceived(FGeometry MyGeometry,FFocusEvent InFocusEvent) { return default; }
	public  void OnFocusLost(FFocusEvent InFocusEvent) {}
	public  void OnAddedToFocusPath(FFocusEvent InFocusEvent) {}
	public  void OnRemovedFromFocusPath(FFocusEvent InFocusEvent) {}
	public  FEventReply OnKeyChar(FGeometry MyGeometry,FCharacterEvent InCharacterEvent) { return default; }
	public  FEventReply OnPreviewKeyDown(FGeometry MyGeometry,FKeyEvent InKeyEvent) { return default; }
	public  FEventReply OnKeyDown(FGeometry MyGeometry,FKeyEvent InKeyEvent) { return default; }
	public  FEventReply OnKeyUp(FGeometry MyGeometry,FKeyEvent InKeyEvent) { return default; }
	public  FEventReply OnAnalogValueChanged(FGeometry MyGeometry,FAnalogInputEvent InAnalogInputEvent) { return default; }
	public  FEventReply OnMouseButtonDown(FGeometry MyGeometry,FPointerEvent MouseEvent) { return default; }
	public  FEventReply OnPreviewMouseButtonDown(FGeometry MyGeometry,FPointerEvent MouseEvent) { return default; }
	public  FEventReply OnMouseButtonUp(FGeometry MyGeometry,FPointerEvent MouseEvent) { return default; }
	public  FEventReply OnMouseMove(FGeometry MyGeometry,FPointerEvent MouseEvent) { return default; }
	public  void OnMouseEnter(FGeometry MyGeometry,FPointerEvent MouseEvent) {}
	public  void OnMouseLeave(FPointerEvent MouseEvent) {}
	public  FEventReply OnMouseWheel(FGeometry MyGeometry,FPointerEvent MouseEvent) { return default; }
	public  FEventReply OnMouseButtonDoubleClick(FGeometry InMyGeometry,FPointerEvent InMouseEvent) { return default; }
	public  void OnDragDetected(FGeometry MyGeometry,FPointerEvent PointerEvent,UDragDropOperation Operation) {}
	public  void OnDragCancelled(FPointerEvent PointerEvent,UDragDropOperation Operation) {}
	public  void OnDragEnter(FGeometry MyGeometry,FPointerEvent PointerEvent,UDragDropOperation Operation) {}
	public  void OnDragLeave(FPointerEvent PointerEvent,UDragDropOperation Operation) {}
	public  bool OnDragOver(FGeometry MyGeometry,FPointerEvent PointerEvent,UDragDropOperation Operation) { return default; }
	public  bool OnDrop(FGeometry MyGeometry,FPointerEvent PointerEvent,UDragDropOperation Operation) { return default; }
	public  FEventReply OnTouchGesture(FGeometry MyGeometry,FPointerEvent GestureEvent) { return default; }
	public  FEventReply OnTouchStarted(FGeometry MyGeometry,FPointerEvent InTouchEvent) { return default; }
	public  FEventReply OnTouchMoved(FGeometry MyGeometry,FPointerEvent InTouchEvent) { return default; }
	public  FEventReply OnTouchEnded(FGeometry MyGeometry,FPointerEvent InTouchEvent) { return default; }
	public  FEventReply OnMotionDetected(FGeometry MyGeometry,FMotionEvent InMotionEvent) { return default; }
	public  void OnMouseCaptureLost() {}
	public  void CancelLatentActions() {}
	public  void StopAnimationsAndLatentActions() {}
	public  FEventReply OnTouchForceChanged(FGeometry MyGeometry,FPointerEvent InTouchEvent) { return default; }
	public  void BindToAnimationStarted(UWidgetAnimation Animation,FWidgetAnimationDynamicEvent Delegate) {}
	public  void UnbindFromAnimationStarted(UWidgetAnimation Animation,FWidgetAnimationDynamicEvent Delegate) {}
	public  void UnbindAllFromAnimationStarted(UWidgetAnimation Animation) {}
	public  void BindToAnimationFinished(UWidgetAnimation Animation,FWidgetAnimationDynamicEvent Delegate) {}
	public  void UnbindFromAnimationFinished(UWidgetAnimation Animation,FWidgetAnimationDynamicEvent Delegate) {}
	public  void UnbindAllFromAnimationFinished(UWidgetAnimation Animation) {}
	public  void BindToAnimationEvent(UWidgetAnimation Animation,FWidgetAnimationDynamicEvent Delegate,EWidgetAnimationEvent AnimationEvent,string UserTag/*=NAME_None*/) {}
	public  void OnAnimationStarted(UWidgetAnimation Animation) {}
	public  void OnAnimationFinished(UWidgetAnimation Animation) {}
	public FLinearColor ColorAndOpacity;
	public FGetLinearColor ColorAndOpacityDelegate;
	public FSlateColor ForegroundColor;
	public FGetSlateColor ForegroundColorDelegate;
	public FOnVisibilityChangedEvent OnVisibilityChanged;
	public FMargin Padding;
	public int Priority;
	public bool bIsFocusable;
	public bool bStopAction;
	public  void SetColorAndOpacity(FLinearColor InColorAndOpacity) {}
	public  void SetForegroundColor(FSlateColor InForegroundColor) {}
	public  void SetPadding(FMargin InPadding) {}
	public  UUMGSequencePlayer PlayAnimation(UWidgetAnimation InAnimation,float StartAtTime/*=0.0f*/,int NumLoopsToPlay/*=1*/,EUMGSequencePlayMode PlayMode/*=EUMGSequencePlayMode.Forward*/,float PlaybackSpeed/*=1.0f*/,bool bRestoreState/*=false*/) { return default; }
	public  UUMGSequencePlayer PlayAnimationTimeRange(UWidgetAnimation InAnimation,float StartAtTime/*=0.0f*/,float EndAtTime/*=0.0f*/,int NumLoopsToPlay/*=1*/,EUMGSequencePlayMode PlayMode/*=EUMGSequencePlayMode.Forward*/,float PlaybackSpeed/*=1.0f*/,bool bRestoreState/*=false*/) { return default; }
	public  UUMGSequencePlayer PlayAnimationForward(UWidgetAnimation InAnimation,float PlaybackSpeed/*=1.0f*/,bool bRestoreState/*=false*/) { return default; }
	public  UUMGSequencePlayer PlayAnimationReverse(UWidgetAnimation InAnimation,float PlaybackSpeed/*=1.0f*/,bool bRestoreState/*=false*/) { return default; }
	public  void StopAnimation(UWidgetAnimation InAnimation) {}
	public  void StopAllAnimations() {}
	public  float PauseAnimation(UWidgetAnimation InAnimation) { return default; }
	public  float GetAnimationCurrentTime(UWidgetAnimation InAnimation) { return default; }
	public  void SetAnimationCurrentTime(UWidgetAnimation InAnimation,float InTime) {}
	public  bool IsAnimationPlaying(UWidgetAnimation InAnimation) { return default; }
	public  bool IsAnyAnimationPlaying() { return default; }
	public  void SetNumLoopsToPlay(UWidgetAnimation InAnimation,int NumLoopsToPlay) {}
	public  void SetPlaybackSpeed(UWidgetAnimation InAnimation,float PlaybackSpeed/*=1.0f*/) {}
	public  void ReverseAnimation(UWidgetAnimation InAnimation) {}
	public  bool IsAnimationPlayingForward(UWidgetAnimation InAnimation) { return default; }
	public  void FlushAnimations() {}
	public  UUserWidgetExtension GetExtension(UClass ExtensionType) { return default; }
	public  TArray<UUserWidgetExtension> GetExtensions(UClass ExtensionType) { return default; }
	public  UUserWidgetExtension AddExtension(UClass InExtensionType) { return default; }
	public  void RemoveExtension(UUserWidgetExtension InExtension) {}
	public  void RemoveExtensions(UClass InExtensionType) {}
	public  void PlaySound(USoundBase SoundToPlay) {}
	public  bool IsPlayingAnimation() { return default; }
	public TArray<UUMGSequencePlayer> ActiveSequencePlayers;
	public UUMGSequenceTickManager AnimationTickManager;
	public TArray<UUMGSequencePlayer> StoppedSequencePlayers;
	public TArray<FNamedSlotBinding> NamedSlotBindings;
	public TArray<UUserWidgetExtension> Extensions;
	public UWidgetTree WidgetTree;
	public FVector2D DesignTimeSize;
	public EDesignPreviewSizeMode DesignSizeMode;
	public string PaletteCategory;
	public UTexture2D PreviewBackground;
	public bool bHasScriptImplementedTick;
	public bool bHasScriptImplementedPaint;
	public  void ListenForInputAction(string ActionName,EInputEvent EventType,bool bConsume,FOnInputAction Callback) {}
	public  void StopListeningForInputAction(string ActionName,EInputEvent EventType) {}
	public  void StopListeningForAllInputActions() {}
	public  void RegisterInputComponent() {}
	public  void UnregisterInputComponent() {}
	public  bool IsListeningForInputAction(string ActionName) { return default; }
	public  void SetInputActionPriority(int NewPriority) {}
	public  void SetInputActionBlocking(bool bShouldBlock) {}
	public EWidgetTickFrequency TickFrequency;
	public UInputComponent InputComponent;
	public TArray<FAnimationEventBinding> AnimationCallbacks;
}
