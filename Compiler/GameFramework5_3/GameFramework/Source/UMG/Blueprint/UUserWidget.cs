namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A widget that enables UI extensibility through WidgetBlueprint.</summary>
[CppInclude("Blueprint/UserWidget.h")]
public partial class UUserWidget : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Adds it to the game&#39;s viewport and fills the entire screen, unless SetDesiredSizeInViewport is called</summary>
	public void AddToViewport(int ZOrder/*=0*/) {}
	///<summary>Adds the widget to the game&#39;s viewport in a section dedicated to the player.  This is valuable in a split screen</summary>
	public bool AddToPlayerScreen(int ZOrder/*=0*/) { return default; }
	///<summary>RemoveFromViewport</summary>
	public void RemoveFromViewport() {}
	///<summary>Sets the widgets position in the viewport.</summary>
	public void SetPositionInViewport(FVector2D Position,bool bRemoveDPIScale/*=true*/) {}
	///<summary>SetDesiredSizeInViewport</summary>
	public void SetDesiredSizeInViewport(FVector2D Size) {}
	///<summary>SetAnchorsInViewport</summary>
	public void SetAnchorsInViewport(FAnchors Anchors) {}
	///<summary>SetAlignmentInViewport</summary>
	public void SetAlignmentInViewport(FVector2D Alignment) {}
	///<summary>GetAnchorsInViewport</summary>
	public FAnchors GetAnchorsInViewport() { return default; }
	///<summary>GetAlignmentInViewport</summary>
	public FVector2D GetAlignmentInViewport() { return default; }
	///<summary>GetIsVisible</summary>
	public bool GetIsVisible() { return default; }
	///<summary>Sets the local player associated with this UI via PlayerController reference.</summary>
	public void SetOwningPlayer(APlayerController LocalPlayerController) {}
	///<summary>Gets the player pawn associated with this UI.</summary>
	public APawn GetOwningPlayerPawn() { return default; }
	///<summary>Gets the player camera manager associated with this UI.</summary>
	public APlayerCameraManager GetOwningPlayerCameraManager() { return default; }
	///<summary>Called once only at game time on non-template instances.</summary>
	public void OnInitialized() {}
	///<summary>Called by both the game and the editor.  Allows users to run initial setup for their widgets to better preview</summary>
	public void PreConstruct(bool IsDesignTime) {}
	///<summary>Called after the underlying slate widget is constructed.  Depending on how the slate object is used</summary>
	public void Construct() {}
	///<summary>Called when a widget is no longer referenced causing the slate resource to destroyed.  Just like</summary>
	public void Destruct() {}
	///<summary>Ticks this widget.  Override in derived classes, but always call the parent implementation.</summary>
	public void Tick(FGeometry MyGeometry,float InDeltaTime) {}
	///<summary>OnPaint</summary>
	public void OnPaint(FPaintContext Context) {}
	///<summary>Gets a value indicating if the widget is interactive.</summary>
	public bool IsInteractable() { return default; }
	///<summary>Called when keyboard focus is given to this widget.  This event does not bubble.</summary>
	public FEventReply OnFocusReceived(FGeometry MyGeometry,FFocusEvent InFocusEvent) { return default; }
	///<summary>Called when this widget loses focus.  This event does not bubble.</summary>
	public void OnFocusLost(FFocusEvent InFocusEvent) {}
	///<summary>If focus is gained on on this widget or on a child widget and this widget is added</summary>
	public void OnAddedToFocusPath(FFocusEvent InFocusEvent) {}
	///<summary>If focus is lost on on this widget or on a child widget and this widget is</summary>
	public void OnRemovedFromFocusPath(FFocusEvent InFocusEvent) {}
	///<summary>Called after a character is entered while this widget has focus</summary>
	public FEventReply OnKeyChar(FGeometry MyGeometry,FCharacterEvent InCharacterEvent) { return default; }
	///<summary>Called after a key (keyboard, controller, ...) is pressed when this widget or a child of this widget has focus</summary>
	public FEventReply OnPreviewKeyDown(FGeometry MyGeometry,FKeyEvent InKeyEvent) { return default; }
	///<summary>Called after a key (keyboard, controller, ...) is pressed when this widget has focus (this event bubbles if not handled)</summary>
	public FEventReply OnKeyDown(FGeometry MyGeometry,FKeyEvent InKeyEvent) { return default; }
	///<summary>Called after a key (keyboard, controller, ...) is released when this widget has focus</summary>
	public FEventReply OnKeyUp(FGeometry MyGeometry,FKeyEvent InKeyEvent) { return default; }
	///<summary>Called when an analog value changes on a button that supports analog</summary>
	public FEventReply OnAnalogValueChanged(FGeometry MyGeometry,FAnalogInputEvent InAnalogInputEvent) { return default; }
	///<summary>The system calls this method to notify the widget that a mouse button was pressed within it. This event is bubbled.</summary>
	public FEventReply OnMouseButtonDown(FGeometry MyGeometry,FPointerEvent MouseEvent) { return default; }
	///<summary>Just like OnMouseButtonDown, but tunnels instead of bubbling.</summary>
	public FEventReply OnPreviewMouseButtonDown(FGeometry MyGeometry,FPointerEvent MouseEvent) { return default; }
	///<summary>The system calls this method to notify the widget that a mouse button was release within it. This event is bubbled.</summary>
	public FEventReply OnMouseButtonUp(FGeometry MyGeometry,FPointerEvent MouseEvent) { return default; }
	///<summary>The system calls this method to notify the widget that a mouse moved within it. This event is bubbled.</summary>
	public FEventReply OnMouseMove(FGeometry MyGeometry,FPointerEvent MouseEvent) { return default; }
	///<summary>The system will use this event to notify a widget that the cursor has entered it. This event is NOT bubbled.</summary>
	public void OnMouseEnter(FGeometry MyGeometry,FPointerEvent MouseEvent) {}
	///<summary>The system will use this event to notify a widget that the cursor has left it. This event is NOT bubbled.</summary>
	public void OnMouseLeave(FPointerEvent MouseEvent) {}
	///<summary>Called when the mouse wheel is spun. This event is bubbled.</summary>
	public FEventReply OnMouseWheel(FGeometry MyGeometry,FPointerEvent MouseEvent) { return default; }
	///<summary>Called when a mouse button is double clicked.  Override this in derived classes.</summary>
	public FEventReply OnMouseButtonDoubleClick(FGeometry InMyGeometry,FPointerEvent InMouseEvent) { return default; }
	///<summary>Called when Slate detects that a widget started to be dragged.</summary>
	public void OnDragDetected(FGeometry MyGeometry,FPointerEvent PointerEvent,UDragDropOperation Operation) {}
	///<summary>Called when the user cancels the drag operation, typically when they simply release the mouse button after</summary>
	public void OnDragCancelled(FPointerEvent PointerEvent,UDragDropOperation Operation) {}
	///<summary>Called during drag and drop when the drag enters the widget.</summary>
	public void OnDragEnter(FGeometry MyGeometry,FPointerEvent PointerEvent,UDragDropOperation Operation) {}
	///<summary>Called during drag and drop when the drag leaves the widget.</summary>
	public void OnDragLeave(FPointerEvent PointerEvent,UDragDropOperation Operation) {}
	///<summary>Called during drag and drop when the the mouse is being dragged over a widget.</summary>
	public bool OnDragOver(FGeometry MyGeometry,FPointerEvent PointerEvent,UDragDropOperation Operation) { return default; }
	///<summary>Called when the user is dropping something onto a widget.  Ends the drag and drop operation, even if no widget handles this.</summary>
	public bool OnDrop(FGeometry MyGeometry,FPointerEvent PointerEvent,UDragDropOperation Operation) { return default; }
	///<summary>Called when the user performs a gesture on trackpad. This event is bubbled.</summary>
	public FEventReply OnTouchGesture(FGeometry MyGeometry,FPointerEvent GestureEvent) { return default; }
	///<summary>Called when a touchpad touch is started (finger down)</summary>
	public FEventReply OnTouchStarted(FGeometry MyGeometry,FPointerEvent InTouchEvent) { return default; }
	///<summary>Called when a touchpad touch is moved  (finger moved)</summary>
	public FEventReply OnTouchMoved(FGeometry MyGeometry,FPointerEvent InTouchEvent) { return default; }
	///<summary>Called when a touchpad touch is ended (finger lifted)</summary>
	public FEventReply OnTouchEnded(FGeometry MyGeometry,FPointerEvent InTouchEvent) { return default; }
	///<summary>Called when motion is detected (controller or device)</summary>
	public FEventReply OnMotionDetected(FGeometry MyGeometry,FMotionEvent InMotionEvent) { return default; }
	///<summary>Called when mouse capture is lost if it was owned by this widget.</summary>
	public void OnMouseCaptureLost() {}
	///<summary>Cancels any pending Delays or timer callbacks for this widget.</summary>
	public void CancelLatentActions() {}
	///<summary>Cancels any pending Delays or timer callbacks for this widget, and stops all active animations on the widget.</summary>
	public void StopAnimationsAndLatentActions() {}
	///<summary>Called when a touchpad force has changed (user pressed down harder or let up)</summary>
	public FEventReply OnTouchForceChanged(FGeometry MyGeometry,FPointerEvent InTouchEvent) { return default; }
	///<summary>Bind an animation started delegate.</summary>
	public void BindToAnimationStarted(UWidgetAnimation Animation,FWidgetAnimationDynamicEvent Delegate) {}
	///<summary>Unbind an animation started delegate.</summary>
	public void UnbindFromAnimationStarted(UWidgetAnimation Animation,FWidgetAnimationDynamicEvent Delegate) {}
	///<summary>UnbindAllFromAnimationStarted</summary>
	public void UnbindAllFromAnimationStarted(UWidgetAnimation Animation) {}
	///<summary>Bind an animation finished delegate.</summary>
	public void BindToAnimationFinished(UWidgetAnimation Animation,FWidgetAnimationDynamicEvent Delegate) {}
	///<summary>Unbind an animation finished delegate.</summary>
	public void UnbindFromAnimationFinished(UWidgetAnimation Animation,FWidgetAnimationDynamicEvent Delegate) {}
	///<summary>UnbindAllFromAnimationFinished</summary>
	public void UnbindAllFromAnimationFinished(UWidgetAnimation Animation) {}
	///<summary>Allows binding to a specific animation&#39;s event.</summary>
	public void BindToAnimationEvent(UWidgetAnimation Animation,FWidgetAnimationDynamicEvent Delegate,EWidgetAnimationEvent AnimationEvent,FName UserTag/*=NAME_None*/) {}
	///<summary>Called when an animation is started.</summary>
	public void OnAnimationStarted(UWidgetAnimation Animation) {}
	///<summary>Called when an animation has either played all the way through or is stopped</summary>
	public void OnAnimationFinished(UWidgetAnimation Animation) {}
	///<summary>The color and opacity of this widget.  Tints all child widgets.</summary>
	public FLinearColor ColorAndOpacity;
	///<summary>ColorAndOpacityDelegate</summary>
	public FGetLinearColor ColorAndOpacityDelegate;
	///<summary>The foreground color of the widget, this is inherited by sub widgets.  Any color property</summary>
	public FSlateColor ForegroundColor;
	///<summary>ForegroundColorDelegate</summary>
	public FGetSlateColor ForegroundColorDelegate;
	///<summary>Called when the visibility has changed</summary>
	public FOnVisibilityChangedEvent OnVisibilityChanged;
	///<summary>The padding area around the content.</summary>
	public FMargin Padding;
	///<summary>Priority</summary>
	public int Priority;
	///<summary>Setting this flag to true, allows this widget to accept focus when clicked, or when navigated to.</summary>
	public bool bIsFocusable;
	///<summary>bStopAction</summary>
	public bool bStopAction;
	///<summary>Sets the tint of the widget, this affects all child widgets.</summary>
	public void SetColorAndOpacity(FLinearColor InColorAndOpacity) {}
	///<summary>Sets the foreground color of the widget, this is inherited by sub widgets.  Any color property</summary>
	public void SetForegroundColor(FSlateColor InForegroundColor) {}
	///<summary>Sets the padding for the user widget, putting a larger gap between the widget border and it&#39;s root widget.</summary>
	public void SetPadding(FMargin InPadding) {}
	///<summary>Plays an animation in this widget a specified number of times</summary>
	public UUMGSequencePlayer PlayAnimation(UWidgetAnimation InAnimation,float StartAtTime/*=0.0f*/,int NumLoopsToPlay/*=1*/,EUMGSequencePlayMode PlayMode/*=EUMGSequencePlayMode.Forward*/,float PlaybackSpeed/*=1.0f*/,bool bRestoreState/*=false*/) { return default; }
	///<summary>Plays an animation in this widget a specified number of times stopping at a specified time</summary>
	public UUMGSequencePlayer PlayAnimationTimeRange(UWidgetAnimation InAnimation,float StartAtTime/*=0.0f*/,float EndAtTime/*=0.0f*/,int NumLoopsToPlay/*=1*/,EUMGSequencePlayMode PlayMode/*=EUMGSequencePlayMode.Forward*/,float PlaybackSpeed/*=1.0f*/,bool bRestoreState/*=false*/) { return default; }
	///<summary>Plays an animation on this widget relative to it&#39;s current state forward.  You should use this version in situations where</summary>
	public UUMGSequencePlayer PlayAnimationForward(UWidgetAnimation InAnimation,float PlaybackSpeed/*=1.0f*/,bool bRestoreState/*=false*/) { return default; }
	///<summary>Plays an animation on this widget relative to it&#39;s current state in reverse.  You should use this version in situations where</summary>
	public UUMGSequencePlayer PlayAnimationReverse(UWidgetAnimation InAnimation,float PlaybackSpeed/*=1.0f*/,bool bRestoreState/*=false*/) { return default; }
	///<summary>Stops an already running animation in this widget</summary>
	public void StopAnimation(UWidgetAnimation InAnimation) {}
	///<summary>Stop All actively running animations.</summary>
	public void StopAllAnimations() {}
	///<summary>Pauses an already running animation in this widget</summary>
	public float PauseAnimation(UWidgetAnimation InAnimation) { return default; }
	///<summary>Gets the current time of the animation in this widget</summary>
	public float GetAnimationCurrentTime(UWidgetAnimation InAnimation) { return default; }
	///<summary>Sets the current time of the animation in this widget. Does not change state.</summary>
	public void SetAnimationCurrentTime(UWidgetAnimation InAnimation,float InTime) {}
	///<summary>Gets whether an animation is currently playing on this widget.</summary>
	public bool IsAnimationPlaying(UWidgetAnimation InAnimation) { return default; }
	///<summary>@return True if any animation is currently playing</summary>
	public bool IsAnyAnimationPlaying() { return default; }
	///<summary>Changes the number of loops to play given a playing animation</summary>
	public void SetNumLoopsToPlay(UWidgetAnimation InAnimation,int NumLoopsToPlay) {}
	///<summary>Changes the playback rate of a playing animation</summary>
	public void SetPlaybackSpeed(UWidgetAnimation InAnimation,float PlaybackSpeed/*=1.0f*/) {}
	///<summary>If an animation is playing, this function will reverse the playback.</summary>
	public void ReverseAnimation(UWidgetAnimation InAnimation) {}
	///<summary>returns true if the animation is currently playing forward, false otherwise.</summary>
	public bool IsAnimationPlayingForward(UWidgetAnimation InAnimation) { return default; }
	///<summary>Flushes all animations on all widgets to guarantee that any queued updates are processed before this call returns</summary>
	public void FlushAnimations() {}
	///<summary>Find the first extension of the requested type.</summary>
	public UUserWidgetExtension GetExtension(UClass ExtensionType) { return default; }
	///<summary>Find the extensions of the requested type.</summary>
	public TArray<UUserWidgetExtension> GetExtensions(UClass ExtensionType) { return default; }
	///<summary>Add the extension of the requested type.</summary>
	public UUserWidgetExtension AddExtension(UClass InExtensionType) { return default; }
	///<summary>Remove the extension.</summary>
	public void RemoveExtension(UUserWidgetExtension InExtension) {}
	///<summary>Remove all extensions of the requested type.</summary>
	public void RemoveExtensions(UClass InExtensionType) {}
	///<summary>Plays a sound through the UI</summary>
	public void PlaySound(USoundBase SoundToPlay) {}
	///<summary>Are we currently playing any animations?</summary>
	public bool IsPlayingAnimation() { return default; }
	///<summary>All the sequence players currently playing</summary>
	public TArray<UUMGSequencePlayer> ActiveSequencePlayers;
	///<summary>AnimationTickManager</summary>
	public UUMGSequenceTickManager AnimationTickManager;
	///<summary>List of sequence players to cache and clean up when safe</summary>
	public TArray<UUMGSequencePlayer> StoppedSequencePlayers;
	///<summary>Stores the widgets being assigned to named slots</summary>
	public TArray<FNamedSlotBinding> NamedSlotBindings;
	///<summary>The UserWidget extensions</summary>
	public TArray<UUserWidgetExtension> Extensions;
	///<summary>The widget tree contained inside this user widget initialized by the blueprint</summary>
	public UWidgetTree WidgetTree;
	///<summary>Stores the design time desired size of the user widget</summary>
	public FVector2D DesignTimeSize;
	///<summary>DesignSizeMode</summary>
	public EDesignPreviewSizeMode DesignSizeMode;
	///<summary>The category this widget appears in the palette.</summary>
	public FText PaletteCategory;
	///<summary>A preview background that you can use when designing the UI to get a sense of scale on the screen.  Use</summary>
	public UTexture2D PreviewBackground;
	///<summary>If a widget has an implemented tick blueprint function</summary>
	public bool bHasScriptImplementedTick;
	///<summary>If a widget has an implemented paint blueprint function</summary>
	public bool bHasScriptImplementedPaint;
	///<summary>Listens for a particular Player Input Action by name.  This requires that those actions are being executed, and</summary>
	public void ListenForInputAction(FName ActionName,EInputEvent EventType,bool bConsume,FOnInputAction Callback) {}
	///<summary>Removes the binding for a particular action&#39;s callback.</summary>
	public void StopListeningForInputAction(FName ActionName,EInputEvent EventType) {}
	///<summary>Stops listening to all input actions, and unregisters the input component with the player controller.</summary>
	public void StopListeningForAllInputActions() {}
	///<summary>ListenForInputAction will automatically Register an Input Component with the player input system.</summary>
	public void RegisterInputComponent() {}
	///<summary>StopListeningForAllInputActions will automatically Register an Input Component with the player input system.</summary>
	public void UnregisterInputComponent() {}
	///<summary>Checks if the action has a registered callback with the input component.</summary>
	public bool IsListeningForInputAction(FName ActionName) { return default; }
	///<summary>SetInputActionPriority</summary>
	public void SetInputActionPriority(int NewPriority) {}
	///<summary>SetInputActionBlocking</summary>
	public void SetInputActionBlocking(bool bShouldBlock) {}
	///<summary>This widget is allowed to tick. If this is unchecked tick will never be called, animations will not play correctly, and latent actions will not execute.</summary>
	public EWidgetTickFrequency TickFrequency;
	///<summary>DesiredFocusWidget</summary>
	public FWidgetChild DesiredFocusWidget;
	///<summary>InputComponent</summary>
	public UInputComponent InputComponent;
	///<summary>AnimationCallbacks</summary>
	public TArray<FAnimationEventBinding> AnimationCallbacks;
}
