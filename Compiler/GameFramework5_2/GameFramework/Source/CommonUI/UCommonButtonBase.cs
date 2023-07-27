#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonButtonBase.h")]
///<summary>Button that disables itself when not active. Also updates actions for CommonActionWidget if bound to display platform-specific icons.</summary>
public partial class UCommonButtonBase : UCommonUserWidget {
// CommonButtonBase
	public  void DisableButtonWithReason(string DisabledReason) {}
	public  void SetIsInteractionEnabled(bool bInIsInteractionEnabled) {}
	public  void SetHideInputAction(bool bInHideInputAction) {}
	public  bool IsInteractionEnabled() { return default; }
	public  bool IsPressed() { return default; }
	public  void SetClickMethod(EButtonClickMethod InClickMethod) {}
	public  void SetTouchMethod(EButtonTouchMethod InTouchMethod) {}
	public  void SetPressMethod(EButtonPressMethod InPressMethod) {}
	public  void SetIsSelectable(bool bInIsSelectable) {}
	public  void SetIsInteractableWhenSelected(bool bInInteractableWhenSelected) {}
	public  void SetIsToggleable(bool bInIsToggleable) {}
	public  void SetShouldUseFallbackDefaultInputAction(bool bInShouldUseFallbackDefaultInputAction) {}
	public  void SetIsSelected(bool InSelected,bool bGiveClickFeedback/*=true*/) {}
	public  void SetIsLocked(bool bInIsLocked) {}
	public  bool GetSelected() { return default; }
	public  bool GetLocked() { return default; }
	public  void ClearSelection() {}
	public  void SetShouldSelectUponReceivingFocus(bool bInShouldSelectUponReceivingFocus) {}
	public  bool GetShouldSelectUponReceivingFocus() { return default; }
	public  void SetStyle(UClass InStyle/*=nullptr*/) {}
	public  UCommonButtonStyle GetStyle() { return default; }
	public  void GetCurrentButtonPadding(FMargin OutButtonPadding) {}
	public  void GetCurrentCustomPadding(FMargin OutCustomPadding) {}
	public  UCommonTextStyle GetCurrentTextStyle() { return default; }
	public  UClass GetCurrentTextStyleClass() { return default; }
	public  void SetMinDimensions(int InMinWidth,int InMinHeight) {}
	public  void SetTriggeredInputAction(FDataTableRowHandle InputActionRow) {}
	public  void SetTriggeringInputAction(FDataTableRowHandle InputActionRow) {}
	public  void SetTriggeringEnhancedInputAction(UInputAction InInputAction) {}
	public  bool GetInputAction(FDataTableRowHandle InputActionRow) { return default; }
	public  UInputAction GetEnhancedInputAction() { return default; }
	public  void SetIsFocusable(bool bInIsFocusable) {}
	public  bool GetIsFocusable() { return default; }
	public  UMaterialInstanceDynamic GetSingleMaterialStyleMID() { return default; }
	public  void SetInputActionProgressMaterial(FSlateBrush InProgressMaterialBrush,string InProgressMaterialParam) {}
	public  void SetPressedSoundOverride(USoundBase Sound) {}
	public  void SetHoveredSoundOverride(USoundBase Sound) {}
	public  void SetSelectedPressedSoundOverride(USoundBase Sound) {}
	public  void SetSelectedHoveredSoundOverride(USoundBase Sound) {}
	public  void SetLockedPressedSoundOverride(USoundBase Sound) {}
	public  void SetLockedHoveredSoundOverride(USoundBase Sound) {}
	public  void OnInputMethodChanged(ECommonInputType CurrentInputType) {}
	public  void HandleTriggeringActionCommited(bool bPassthrough) {}
	public  void HandleButtonClicked() {}
	public  void HandleFocusReceived() {}
	public  void HandleFocusLost() {}
	public  void HandleButtonPressed() {}
	public  void HandleButtonReleased() {}
	public  void BP_OnSelected() {}
	public  void BP_OnDeselected() {}
	public  void BP_OnHovered() {}
	public  void BP_OnUnhovered() {}
	public  void BP_OnFocusReceived() {}
	public  void BP_OnFocusLost() {}
	public  void BP_OnLockedChanged(bool bIsLocked) {}
	public  void BP_OnLockClicked() {}
	public  void BP_OnLockDoubleClicked() {}
	public  void BP_OnClicked() {}
	public  void BP_OnDoubleClicked() {}
	public  void StopDoubleClickPropagation() {}
	public  void BP_OnPressed() {}
	public  void BP_OnReleased() {}
	public  void BP_OnEnabled() {}
	public  void BP_OnDisabled() {}
	public  void BP_OnInputMethodChanged(ECommonInputType CurrentInputType) {}
	public  void OnCurrentTextStyleChanged() {}
	public  void SetSelectedInternal(bool bInSelected,bool bAllowSound/*=true*/,bool bBroadcast/*=true*/) {}
	public  void OnTriggeredInputActionChanged(FDataTableRowHandle NewTriggeredAction) {}
	public  void OnTriggeringInputActionChanged(FDataTableRowHandle NewTriggeredAction) {}
	public  void OnTriggeringEnhancedInputActionChanged(UInputAction InInputAction) {}
	public  void OnActionProgress(float HeldPercent) {}
	public  void NativeOnActionProgress(float HeldPercent) {}
	public  void OnActionComplete() {}
	public  void NativeOnActionComplete() {}
	public int MinWidth;
	public int MinHeight;
	public UClass Style;
	public bool bHideInputAction;
	public FSlateSound PressedSlateSoundOverride;
	public FSlateSound HoveredSlateSoundOverride;
	public FSlateSound SelectedPressedSlateSoundOverride;
	public FSlateSound SelectedHoveredSlateSoundOverride;
	public FSlateSound LockedPressedSlateSoundOverride;
	public FSlateSound LockedHoveredSlateSoundOverride;
	public bool bApplyAlphaOnDisable;
	public bool bLocked;
	public bool bSelectable;
	public bool bShouldSelectUponReceivingFocus;
	public bool bInteractableWhenSelected;
	public bool bToggleable;
	public bool bTriggerClickedAfterSelection;
	public bool bDisplayInputActionWhenNotInteractable;
	public bool bHideInputActionWithKeyboard;
	public bool bShouldUseFallbackDefaultInputAction;
	public byte ClickMethod;
	public byte TouchMethod;
	public byte PressMethod;
	public int InputPriority;
	public FDataTableRowHandle TriggeringInputAction;
	public UInputAction TriggeringEnhancedInputAction;
	public bool bStyleNoLongerNeedsConversion;
	public FCommonSelectedStateChangedBase OnSelectedChangedBase;
	public FCommonButtonBaseClicked OnButtonBaseClicked;
	public FCommonButtonBaseClicked OnButtonBaseDoubleClicked;
	public FCommonButtonBaseClicked OnButtonBaseHovered;
	public FCommonButtonBaseClicked OnButtonBaseUnhovered;
	public bool bIsPersistentBinding;
	public ECommonInputMode InputModeOverride;
	public UMaterialInstanceDynamic SingleMaterialStyleMID;
	public FButtonStyle NormalStyle;
	public FButtonStyle SelectedStyle;
	public FButtonStyle DisabledStyle;
	public FButtonStyle LockedStyle;
	public bool bStopDoubleClickPropagation;
	public UCommonActionWidget InputActionWidget;
}
