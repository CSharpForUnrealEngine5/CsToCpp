namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Button that disables itself when not active. Also updates actions for CommonActionWidget if bound to display platform-specific icons.</summary>
[CppInclude("CommonButtonBase.h")]
public partial class UCommonButtonBase : UCommonUserWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Disables this button with a reason (use instead of SetIsEnabled)</summary>
	public void DisableButtonWithReason(FText DisabledReason) {}
	///<summary>Change whether this widget is selectable at all. If false and currently selected, will deselect.</summary>
	public void SetIsInteractionEnabled(bool bInIsInteractionEnabled) {}
	///<summary>SetHideInputAction</summary>
	public void SetHideInputAction(bool bInHideInputAction) {}
	///<summary>Is this button currently interactable? (use instead of GetIsEnabled)</summary>
	public bool IsInteractionEnabled() { return default; }
	///<summary>Is this button currently pressed?</summary>
	public bool IsPressed() { return default; }
	///<summary>Set the click method for mouse interaction</summary>
	public void SetClickMethod(EButtonClickMethod InClickMethod) {}
	///<summary>Set the click method for touch interaction</summary>
	public void SetTouchMethod(EButtonTouchMethod InTouchMethod) {}
	///<summary>Set the click method for keyboard/gamepad button press interaction</summary>
	public void SetPressMethod(EButtonPressMethod InPressMethod) {}
	///<summary>Change whether this widget is selectable at all. If false and currently selected, will deselect.</summary>
	public void SetIsSelectable(bool bInIsSelectable) {}
	///<summary>Change whether this widget is selectable at all. If false and currently selected, will deselect.</summary>
	public void SetIsInteractableWhenSelected(bool bInInteractableWhenSelected) {}
	///<summary>Change whether this widget is toggleable. If toggleable, clicking when selected will deselect.</summary>
	public void SetIsToggleable(bool bInIsToggleable) {}
	///<summary>Change whether this widget should use the fallback default input action.</summary>
	public void SetShouldUseFallbackDefaultInputAction(bool bInShouldUseFallbackDefaultInputAction) {}
	///<summary>Change the selected state manually.</summary>
	public void SetIsSelected(bool InSelected,bool bGiveClickFeedback/*=true*/) {}
	///<summary>Change whether this widget is locked. If locked, the button can be focusable and responsive to mouse input but will not broadcast OnClicked events.</summary>
	public void SetIsLocked(bool bInIsLocked) {}
	///<summary>@returns True if the button is currently in a selected state, False otherwise</summary>
	public bool GetSelected() { return default; }
	///<summary>@returns True if the button is currently locked, False otherwise</summary>
	public bool GetLocked() { return default; }
	///<summary>ClearSelection</summary>
	public void ClearSelection() {}
	///<summary>Set whether the button should become selected upon receiving focus or not; Only settable for buttons that are selectable</summary>
	public void SetShouldSelectUponReceivingFocus(bool bInShouldSelectUponReceivingFocus) {}
	///<summary>Get whether the button should become selected upon receiving focus or not</summary>
	public bool GetShouldSelectUponReceivingFocus() { return default; }
	///<summary>Sets the style of this button, rebuilds the internal styling</summary>
	public void SetStyle(UClass InStyle/*=nullptr*/) {}
	///<summary>@Returns Current button style</summary>
	public UCommonButtonStyle GetStyle() { return default; }
	///<summary>@return The current button padding that corresponds to the current size and selection state</summary>
	public void GetCurrentButtonPadding(FMargin OutButtonPadding) {}
	///<summary>@return The custom padding that corresponds to the current size and selection state</summary>
	public void GetCurrentCustomPadding(FMargin OutCustomPadding) {}
	///<summary>@return The text style that corresponds to the current size and selection state</summary>
	public UCommonTextStyle GetCurrentTextStyle() { return default; }
	///<summary>@return The class of the text style that corresponds to the current size and selection state</summary>
	public UClass GetCurrentTextStyleClass() { return default; }
	///<summary>Sets the minimum dimensions of this button</summary>
	public void SetMinDimensions(int InMinWidth,int InMinHeight) {}
	///<summary>Updates the current triggered action</summary>
	public void SetTriggeredInputAction(FDataTableRowHandle InputActionRow) {}
	///<summary>Updates the current triggering action</summary>
	public void SetTriggeringInputAction(FDataTableRowHandle InputActionRow) {}
	///<summary>Updates the current triggering enhanced input action, requires enhanced input enabled in CommonUI settings</summary>
	public void SetTriggeringEnhancedInputAction(UInputAction InInputAction) {}
	///<summary>Gets the appropriate input action that is set</summary>
	public bool GetInputAction(FDataTableRowHandle InputActionRow) { return default; }
	///<summary>Gets the appropriate enhanced input action that is set</summary>
	public UInputAction GetEnhancedInputAction() { return default; }
	///<summary>Updates the bIsFocusable flag</summary>
	public void SetIsFocusable(bool bInIsFocusable) {}
	///<summary>Gets the bIsFocusable flag</summary>
	public bool GetIsFocusable() { return default; }
	///<summary>Returns the dynamic instance of the material being used for this button, if it is using a single material style.</summary>
	public UMaterialInstanceDynamic GetSingleMaterialStyleMID() { return default; }
	///<summary>SetInputActionProgressMaterial</summary>
	public void SetInputActionProgressMaterial(FSlateBrush InProgressMaterialBrush,string InProgressMaterialParam) {}
	///<summary>SetPressedSoundOverride</summary>
	public void SetPressedSoundOverride(USoundBase Sound) {}
	///<summary>SetHoveredSoundOverride</summary>
	public void SetHoveredSoundOverride(USoundBase Sound) {}
	///<summary>SetSelectedPressedSoundOverride</summary>
	public void SetSelectedPressedSoundOverride(USoundBase Sound) {}
	///<summary>SetSelectedHoveredSoundOverride</summary>
	public void SetSelectedHoveredSoundOverride(USoundBase Sound) {}
	///<summary>SetLockedPressedSoundOverride</summary>
	public void SetLockedPressedSoundOverride(USoundBase Sound) {}
	///<summary>SetLockedHoveredSoundOverride</summary>
	public void SetLockedHoveredSoundOverride(USoundBase Sound) {}
	///<summary>Called via delegate when the input method changes</summary>
	public virtual void OnInputMethodChanged(ECommonInputType CurrentInputType) {}
	///<summary>HandleTriggeringActionCommited</summary>
	public virtual void HandleTriggeringActionCommited(bool bPassthrough) {}
	///<summary>Handler function registered to the underlying button&#39;s click.</summary>
	public void HandleButtonClicked() {}
	///<summary>Helper function registered to the underlying button receiving focus</summary>
	public virtual void HandleFocusReceived() {}
	///<summary>Helper function registered to the underlying button losing focus</summary>
	public virtual void HandleFocusLost() {}
	///<summary>Helper function registered to the underlying button when pressed</summary>
	public void HandleButtonPressed() {}
	///<summary>Helper function registered to the underlying button when released</summary>
	public void HandleButtonReleased() {}
	///<summary>BP_OnSelected</summary>
	public void BP_OnSelected() {}
	///<summary>BP_OnDeselected</summary>
	public void BP_OnDeselected() {}
	///<summary>BP_OnHovered</summary>
	public void BP_OnHovered() {}
	///<summary>BP_OnUnhovered</summary>
	public void BP_OnUnhovered() {}
	///<summary>BP_OnFocusReceived</summary>
	public void BP_OnFocusReceived() {}
	///<summary>BP_OnFocusLost</summary>
	public void BP_OnFocusLost() {}
	///<summary>BP_OnLockedChanged</summary>
	public void BP_OnLockedChanged(bool bIsLocked) {}
	///<summary>BP_OnLockClicked</summary>
	public void BP_OnLockClicked() {}
	///<summary>BP_OnLockDoubleClicked</summary>
	public void BP_OnLockDoubleClicked() {}
	///<summary>BP_OnClicked</summary>
	public void BP_OnClicked() {}
	///<summary>BP_OnDoubleClicked</summary>
	public void BP_OnDoubleClicked() {}
	///<summary>Unless this is called, we will assume the double click should be converted into a normal click.</summary>
	public void StopDoubleClickPropagation() {}
	///<summary>BP_OnPressed</summary>
	public void BP_OnPressed() {}
	///<summary>BP_OnReleased</summary>
	public void BP_OnReleased() {}
	///<summary>BP_OnEnabled</summary>
	public void BP_OnEnabled() {}
	///<summary>BP_OnDisabled</summary>
	public void BP_OnDisabled() {}
	///<summary>BP_OnInputMethodChanged</summary>
	public void BP_OnInputMethodChanged(ECommonInputType CurrentInputType) {}
	///<summary>Allows derived classes to take action when the current text style has changed</summary>
	public void OnCurrentTextStyleChanged() {}
	///<summary>Internal method to allow the selected state to be set regardless of selectability or toggleability</summary>
	public void SetSelectedInternal(bool bInSelected,bool bAllowSound/*=true*/,bool bBroadcast/*=true*/) {}
	///<summary>Callback fired when input action datatable row changes</summary>
	public void OnTriggeredInputActionChanged(FDataTableRowHandle NewTriggeredAction) {}
	///<summary>Callback fired when triggered input action datatable row changes</summary>
	public void OnTriggeringInputActionChanged(FDataTableRowHandle NewTriggeredAction) {}
	///<summary>Callback fired when enhanced input action changes</summary>
	public void OnTriggeringEnhancedInputActionChanged(UInputAction InInputAction) {}
	///<summary>Callback fired continously during hold interactions</summary>
	public void OnActionProgress(float HeldPercent) {}
	///<summary>NativeOnActionProgress</summary>
	public virtual void NativeOnActionProgress(float HeldPercent) {}
	///<summary>Callback fired when hold events complete</summary>
	public void OnActionComplete() {}
	///<summary>NativeOnActionComplete</summary>
	public virtual void NativeOnActionComplete() {}
	///<summary>The minimum width of the button (only used if greater than the style&#39;s minimum)</summary>
	public int MinWidth;
	///<summary>The minimum height of the button (only used if greater than the style&#39;s minimum)</summary>
	public int MinHeight;
	///<summary>References the button style asset that defines a style in multiple sizes</summary>
	public UClass Style;
	///<summary>Whether to hide the input action widget at all times (useful for textless small buttons)</summary>
	public bool bHideInputAction;
	///<summary>Optional override for the sound to play when this button is pressed.</summary>
	public FSlateSound PressedSlateSoundOverride;
	///<summary>Optional override for the sound to play when this button is hovered.</summary>
	public FSlateSound HoveredSlateSoundOverride;
	///<summary>Optional override for the sound to play when this button is pressed while Selected</summary>
	public FSlateSound SelectedPressedSlateSoundOverride;
	///<summary>Optional override for the sound to play when this button is hovered while Selected</summary>
	public FSlateSound SelectedHoveredSlateSoundOverride;
	///<summary>Optional override for the sound to play when this button is pressed while Locked</summary>
	public FSlateSound LockedPressedSlateSoundOverride;
	///<summary>Optional override for the sound to play when this button is hovered while Locked</summary>
	public FSlateSound LockedHoveredSlateSoundOverride;
	///<summary>The type of mouse action required by the user to trigger the button&#39;s &#39;Click&#39;</summary>
	public bool bApplyAlphaOnDisable;
	///<summary>True if this button is currently locked.</summary>
	public bool bLocked;
	///<summary>True if the button supports being in a &quot;selected&quot; state, which will update the style accordingly</summary>
	public bool bSelectable;
	///<summary>If true, the button will be selected when it receives focus.</summary>
	public bool bShouldSelectUponReceivingFocus;
	///<summary>If true, the button may be clicked while selected. Otherwise, interaction is disabled in the selected state.</summary>
	public bool bInteractableWhenSelected;
	///<summary>True if the button can be deselected by clicking it when selected</summary>
	public bool bToggleable;
	///<summary>bTriggerClickedAfterSelection</summary>
	public bool bTriggerClickedAfterSelection;
	///<summary>True if the input action should be displayed when the button is not interactable</summary>
	public bool bDisplayInputActionWhenNotInteractable;
	///<summary>True if the input action should be hidden while the user is using a keyboard</summary>
	public bool bHideInputActionWithKeyboard;
	///<summary>True if this button should use the default fallback input action (bool is useful for buttons that shouldn&#39;t because they are never directly hit via controller)</summary>
	public bool bShouldUseFallbackDefaultInputAction;
	///<summary>The type of mouse action required by the user to trigger the button&#39;s &#39;Click&#39;</summary>
	public EButtonClickMethod ClickMethod;
	///<summary>TouchMethod</summary>
	public EButtonTouchMethod TouchMethod;
	///<summary>PressMethod</summary>
	public EButtonPressMethod PressMethod;
	///<summary>This is the priority for the TriggeringInputAction.  The first, HIGHEST PRIORITY widget will handle the input action, and no other widgets will be considered.</summary>
	public int InputPriority;
	///<summary>The input action that is bound to this button. The common input manager will trigger this button to</summary>
	public FDataTableRowHandle TriggeringInputAction;
	///<summary>The enhanced input action that is bound to this button. The common input manager will trigger this button to</summary>
	public UInputAction TriggeringEnhancedInputAction;
	///<summary>Used to track widgets that were created before changing the default style pointer to null</summary>
	public bool bStyleNoLongerNeedsConversion;
	///<summary>OnSelectedChangedBase</summary>
	public FCommonSelectedStateChangedBase OnSelectedChangedBase;
	///<summary>OnButtonBaseClicked</summary>
	public FCommonButtonBaseClicked OnButtonBaseClicked;
	///<summary>OnButtonBaseDoubleClicked</summary>
	public FCommonButtonBaseClicked OnButtonBaseDoubleClicked;
	///<summary>OnButtonBaseHovered</summary>
	public FCommonButtonBaseClicked OnButtonBaseHovered;
	///<summary>OnButtonBaseUnhovered</summary>
	public FCommonButtonBaseClicked OnButtonBaseUnhovered;
	///<summary>DANGER! Be very, very careful with this. Unless you absolutely know what you&#39;re doing, this is not the property you&#39;re looking for.</summary>
	public bool bIsPersistentBinding;
	///<summary>Set this to Game for special cases where an input action needs to be set for an in-game button.</summary>
	public ECommonInputMode InputModeOverride;
	///<summary>The dynamic material instance of the material set by the single material style, if specified.</summary>
	public UMaterialInstanceDynamic SingleMaterialStyleMID;
	///<summary>Internally managed and applied style to use when not selected</summary>
	public FButtonStyle NormalStyle;
	///<summary>Internally managed and applied style to use when selected</summary>
	public FButtonStyle SelectedStyle;
	///<summary>Internally managed and applied style to use when disabled</summary>
	public FButtonStyle DisabledStyle;
	///<summary>Internally managed and applied style to use when locked</summary>
	public FButtonStyle LockedStyle;
	///<summary>bStopDoubleClickPropagation</summary>
	public bool bStopDoubleClickPropagation;
	///<summary>Optionally bound widget for visualization behavior of an input action;</summary>
	public UCommonActionWidget InputActionWidget;
}
