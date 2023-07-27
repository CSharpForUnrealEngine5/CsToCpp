#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonActivatableWidget.h")]
///<summary>The base for widgets that are capable of being "activated" and "deactivated" during their lifetime without being otherwise modified or destroyed.</summary>
public partial class UCommonActivatableWidget : UCommonUserWidget {
// CommonActivatableWidget
	public  bool IsActivated() { return default; }
	public  void ActivateWidget() {}
	public  void DeactivateWidget() {}
	public  void SetBindVisibilities(ESlateVisibility OnActivatedVisibility,ESlateVisibility OnDeactivatedVisibility,bool bInAllActive) {}
	public  void BindVisibilityToActivation(UCommonActivatableWidget ActivatableWidget) {}
	public  UWidget GetDesiredFocusTarget() { return default; }
	public  UWidget BP_GetDesiredFocusTarget() { return default; }
	public  void BP_OnActivated() {}
	public  void BP_OnDeactivated() {}
	public  bool BP_OnHandleBackAction() { return default; }
	public bool bIsBackHandler;
	public bool bIsBackActionDisplayedInActionBar;
	public bool bAutoActivate;
	public bool bSupportsActivationFocus;
	public bool bIsModal;
	public bool bAutoRestoreFocus;
	public bool bOverrideActionDomain;
	public UInputMappingContext InputMapping;
	public int InputMappingPriority;
	public TSoftObjectPtr<UCommonInputActionDomain> ActionDomainOverride;
	public FOnWidgetActivationChanged BP_OnWidgetActivated;
	public FOnWidgetActivationChanged BP_OnWidgetDeactivated;
	public bool bIsActive;
	public TArray<TWeakObjectPtr<UCommonActivatableWidget>> VisibilityBoundWidgets;
	public bool bSetVisibilityOnActivated;
	public ESlateVisibility ActivatedVisibility;
	public bool bSetVisibilityOnDeactivated;
	public ESlateVisibility DeactivatedVisibility;
}
