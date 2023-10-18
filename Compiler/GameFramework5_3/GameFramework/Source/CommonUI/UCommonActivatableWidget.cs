namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base for widgets that are capable of being &quot;activated&quot; and &quot;deactivated&quot; during their lifetime without being otherwise modified or destroyed.</summary>
[CppInclude("CommonActivatableWidget.h")]
public partial class UCommonActivatableWidget : UCommonUserWidget {
	public static UClass StaticClass() {return default;}
	///<summary>IsActivated</summary>
	public bool IsActivated() { return default; }
	///<summary>ActivateWidget</summary>
	public void ActivateWidget() {}
	///<summary>DeactivateWidget</summary>
	public void DeactivateWidget() {}
	///<summary>Visibilities to use for when bound widgets in BindVisibilityToActivation are activated.</summary>
	public void SetBindVisibilities(ESlateVisibility OnActivatedVisibility,ESlateVisibility OnDeactivatedVisibility,bool bInAllActive) {}
	///<summary>Bind our visibility to the activation of another widget, useful for making mouse collisions behave similiar to console navigation w.r.t activation</summary>
	public void BindVisibilityToActivation(UCommonActivatableWidget ActivatableWidget) {}
	///<summary>Returns the desired widget to focus when this Widget Activates.</summary>
	public UWidget GetDesiredFocusTarget() { return default; }
	///<summary>Implement to provide the desired widget to focus if/when this activatable becomes the primary active widget.</summary>
	public UWidget BP_GetDesiredFocusTarget() { return default; }
	///<summary>Implement to provide the input config to use when this widget is activated. Keep in mind when all widgets</summary>
	public FUIInputConfig BP_GetDesiredInputConfig() { return default; }
	///<summary>BP_OnActivated</summary>
	public void BP_OnActivated() {}
	///<summary>BP_OnDeactivated</summary>
	public void BP_OnDeactivated() {}
	///<summary>Override in BP implementations to provide custom behavior when receiving a back action</summary>
	public bool BP_OnHandleBackAction() { return default; }
	///<summary>True to receive &quot;Back&quot; actions automatically. Custom back handler behavior can be provided, default is to deactivate.</summary>
	public bool bIsBackHandler;
	///<summary>True to receive &quot;Back&quot; actions automatically. Custom back handler behavior can be provided, default is to deactivate.</summary>
	public bool bIsBackActionDisplayedInActionBar;
	///<summary>True to automatically activate upon construction</summary>
	public bool bAutoActivate;
	///<summary>True if this widget is a candidate to receive/route focus or specify a desired UIInputConfig when active.</summary>
	public bool bSupportsActivationFocus;
	///<summary>True to have this widget be treated as a root node for input routing, regardless of its actual parentage.</summary>
	public bool bIsModal;
	///<summary>True to prefer automatically restoring focus to the widget that was focused when this widget last became the non-leafmost-active-widget.</summary>
	public bool bAutoRestoreFocus;
	///<summary>bOverrideActionDomain</summary>
	public bool bOverrideActionDomain;
	///<summary>Optional mapping context to be applied &amp; removed on activation &amp; deactivation respectfully.</summary>
	public UInputMappingContext InputMapping;
	///<summary>Enhanced Input priority. Higher priority input mappings will be prioritized over mappings with a lower priority.</summary>
	public int InputMappingPriority;
	///<summary>Enable to override the inherited ActionDomain from owning CommonActivatableWidget.</summary>
	public TSoftObjectPtr<UCommonInputActionDomain> ActionDomainOverride;
	///<summary>Fires when the widget is activated.</summary>
	public FOnWidgetActivationChanged BP_OnWidgetActivated;
	///<summary>Fires when the widget is deactivated.</summary>
	public FOnWidgetActivationChanged BP_OnWidgetDeactivated;
	///<summary>bIsActive</summary>
	public bool bIsActive;
	///<summary>List of widgets whose collective activation controls our visibility.</summary>
	public TArray<TWeakObjectPtr<UCommonActivatableWidget>> VisibilityBoundWidgets;
	///<summary>bSetVisibilityOnActivated</summary>
	public bool bSetVisibilityOnActivated;
	///<summary>ActivatedVisibility</summary>
	public ESlateVisibility ActivatedVisibility;
	///<summary>bSetVisibilityOnDeactivated</summary>
	public bool bSetVisibilityOnDeactivated;
	///<summary>DeactivatedVisibility</summary>
	public ESlateVisibility DeactivatedVisibility;
}
