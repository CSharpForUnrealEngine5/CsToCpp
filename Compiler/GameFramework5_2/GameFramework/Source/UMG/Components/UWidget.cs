namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the base class for all wrapped Slate controls that are exposed to UObjects.</summary>
[CppInclude("Components/Widget.h")]
public partial class UWidget : UVisual {
	public static UClass StaticClass() {return default;}
	///<summary>Common Bindings - If you add any new common binding, you must provide a UPropertyBinding for it.</summary>
	public bool FGetBool() { return default; }
	///<summary>FGetFloat</summary>
	public float FGetFloat() { return default; }
	///<summary>FGetInt32</summary>
	public int FGetInt32() { return default; }
	///<summary>FGetText</summary>
	public FText FGetText() { return default; }
	///<summary>FGetSlateColor</summary>
	public FSlateColor FGetSlateColor() { return default; }
	///<summary>FGetLinearColor</summary>
	public FLinearColor FGetLinearColor() { return default; }
	///<summary>FGetSlateBrush</summary>
	public FSlateBrush FGetSlateBrush() { return default; }
	///<summary>FGetSlateVisibility</summary>
	public ESlateVisibility FGetSlateVisibility() { return default; }
	///<summary>FGetMouseCursor</summary>
	public EMouseCursor FGetMouseCursor() { return default; }
	///<summary>FGetCheckBoxState</summary>
	public ECheckBoxState FGetCheckBoxState() { return default; }
	///<summary>FGetWidget</summary>
	public UWidget FGetWidget() { return default; }
	///<summary>Events</summary>
	public UWidget FGenerateWidgetForString(string Item) { return default; }
	///<summary>FGenerateWidgetForObject</summary>
	public UWidget FGenerateWidgetForObject(UObject Item) { return default; }
	///<summary>Events</summary>
	public FEventReply FOnReply() { return default; }
	///<summary>FOnPointerEvent</summary>
	public FEventReply FOnPointerEvent(FGeometry MyGeometry,FPointerEvent MouseEvent) { return default; }
	///<summary>The parent slot of the UWidget.  Allows us to easily inline edit the layout controlling this widget.</summary>
	public UPanelSlot Slot;
	///<summary>A bindable delegate for bIsEnabled</summary>
	public FGetBool bIsEnabledDelegate;
	///<summary>Tooltip text to show when the user hovers over the widget with the mouse</summary>
	public FText ToolTipText;
	///<summary>A bindable delegate for ToolTipText</summary>
	public FGetText ToolTipTextDelegate;
	///<summary>Tooltip widget to show when the user hovers over the widget with the mouse</summary>
	public UWidget ToolTipWidget;
	///<summary>A bindable delegate for ToolTipWidget</summary>
	public FGetWidget ToolTipWidgetDelegate;
	///<summary>A bindable delegate for Visibility</summary>
	public FGetSlateVisibility VisibilityDelegate;
	///<summary>The render transform of the widget allows for arbitrary 2D transforms to be applied to the widget.</summary>
	public FWidgetTransform RenderTransform;
	///<summary>The render transform pivot controls the location about which transforms are applied.</summary>
	public FVector2D RenderTransformPivot;
	///<summary>Allows you to set a new flow direction</summary>
	public EFlowDirectionPreference FlowDirectionPreference;
	///<summary>Allows controls to be exposed as variables in a blueprint.  Not all controls need to be exposed</summary>
	public bool bIsVariable;
	///<summary>Flag if the Widget was created from a blueprint</summary>
	public bool bCreatedByConstructionScript;
	///<summary>Sets whether this widget can be modified interactively by the user</summary>
	public bool bIsEnabled;
	///<summary>bOverride_Cursor</summary>
	public bool bOverride_Cursor;
	///<summary>Override all of the default accessibility behavior and text for this widget.</summary>
	public bool bOverrideAccessibleDefaults;
	///<summary>Whether or not children of this widget can appear as distinct accessible widgets.</summary>
	public bool bCanChildrenBeAccessible;
	///<summary>Whether or not the widget is accessible, and how to describe it. If set to custom, additional customization options will appear.</summary>
	public ESlateAccessibleBehavior AccessibleBehavior;
	///<summary>How to describe this widget when it&#39;s being presented through a summary of a parent widget. If set to custom, additional customization options will appear.</summary>
	public ESlateAccessibleBehavior AccessibleSummaryBehavior;
	///<summary>When AccessibleBehavior is set to Custom, this is the text that will be used to describe the widget.</summary>
	public FText AccessibleText;
	///<summary>An optional delegate that may be assigned in place of AccessibleText for creating a TAttribute</summary>
	public FGetText AccessibleTextDelegate;
	///<summary>When AccessibleSummaryBehavior is set to Custom, this is the text that will be used to describe the widget.</summary>
	public FText AccessibleSummaryText;
	///<summary>An optional delegate that may be assigned in place of AccessibleSummaryText for creating a TAttribute</summary>
	public FGetText AccessibleSummaryTextDelegate;
	///<summary>If true prevents the widget or its child&#39;s geometry or layout information from being cached.  If this widget</summary>
	public bool bIsVolatile;
	///<summary>Stores the design time flag setting if the widget is hidden inside the designer</summary>
	public bool bHiddenInDesigner;
	///<summary>Stores the design time flag setting if the widget is expanded inside the designer</summary>
	public bool bExpandedInDesigner;
	///<summary>Stores the design time flag setting if the widget is locked inside the designer</summary>
	public bool bLockedInDesigner;
	///<summary>The cursor to show when the mouse is over the widget</summary>
	public EMouseCursor Cursor;
	///<summary>Controls how the clipping behavior of this widget.  Normally content that overflows the</summary>
	public EWidgetClipping Clipping;
	///<summary>The visibility of the widget</summary>
	public ESlateVisibility Visibility;
	///<summary>The opacity of the widget</summary>
	public float RenderOpacity;
	///<summary>A custom set of accessibility rules for this widget. If null, default rules for the widget are used.</summary>
	public USlateAccessibleWidgetData AccessibleWidgetData;
	///<summary>The navigation object for this widget is optionally created if the user has configured custom</summary>
	public UWidgetNavigation Navigation;
	///<summary>SetRenderTransform</summary>
	public void SetRenderTransform(FWidgetTransform InTransform) {}
	///<summary>SetRenderScale</summary>
	public void SetRenderScale(FVector2D Scale) {}
	///<summary>SetRenderShear</summary>
	public void SetRenderShear(FVector2D Shear) {}
	///<summary>SetRenderTransformAngle</summary>
	public void SetRenderTransformAngle(float Angle) {}
	///<summary>GetRenderTransformAngle</summary>
	public float GetRenderTransformAngle() { return default; }
	///<summary>SetRenderTranslation</summary>
	public void SetRenderTranslation(FVector2D Translation) {}
	///<summary>SetRenderTransformPivot</summary>
	public void SetRenderTransformPivot(FVector2D Pivot) {}
	///<summary>Gets the current enabled status of the widget</summary>
	public bool GetIsEnabled() { return default; }
	///<summary>Sets the current enabled status of the widget</summary>
	public virtual void SetIsEnabled(bool bInIsEnabled) {}
	///<summary>@return true if the widget was added to the viewport using AddToViewport or AddToPlayerScreen.</summary>
	public bool IsInViewport() { return default; }
	///<summary>Sets the tooltip text for the widget.</summary>
	public void SetToolTipText(FText InToolTipText) {}
	///<summary>Sets a custom widget as the tooltip of the widget.</summary>
	public void SetToolTip(UWidget Widget) {}
	///<summary>Sets the cursor to show over the widget.</summary>
	public void SetCursor(EMouseCursor InCursor) {}
	///<summary>Resets the cursor to use on the widget, removing any customization for it.</summary>
	public void ResetCursor() {}
	///<summary>Returns true if the widget is Visible, HitTestInvisible or SelfHitTestInvisible and the Render Opacity is greater than 0.</summary>
	public bool IsRendered() { return default; }
	///<summary>Returns true if the widget is Visible, HitTestInvisible or SelfHitTestInvisible.</summary>
	public bool IsVisible() { return default; }
	///<summary>Gets the current visibility of the widget.</summary>
	public ESlateVisibility GetVisibility() { return default; }
	///<summary>Sets the visibility of the widget.</summary>
	public virtual void SetVisibility(ESlateVisibility InVisibility) {}
	///<summary>Gets the current visibility of the widget.</summary>
	public float GetRenderOpacity() { return default; }
	///<summary>Sets the visibility of the widget.</summary>
	public void SetRenderOpacity(float InOpacity) {}
	///<summary>Gets the clipping state of this widget.</summary>
	public EWidgetClipping GetClipping() { return default; }
	///<summary>Sets the clipping state of this widget.</summary>
	public void SetClipping(EWidgetClipping InClipping) {}
	///<summary>Sets the forced volatility of the widget.</summary>
	public void ForceVolatile(bool bForce) {}
	///<summary>Returns true if the widget is currently being hovered by a pointer device</summary>
	public virtual bool IsHovered() { return default; }
	///<summary>Checks to see if this widget currently has the keyboard focus</summary>
	public bool HasKeyboardFocus() { return default; }
	///<summary>Checks to see if this widget is the current mouse captor</summary>
	public bool HasMouseCapture() { return default; }
	///<summary>Checks to see if this widget is the current mouse captor</summary>
	public bool HasMouseCaptureByUser(int UserIndex,int PointerIndex/*=-1*/) { return default; }
	///<summary>Sets the focus to this widget.</summary>
	public void SetKeyboardFocus() {}
	///<summary>Returns true if this widget is focused by a specific user.</summary>
	public bool HasUserFocus(APlayerController PlayerController) { return default; }
	///<summary>Returns true if this widget is focused by any user.</summary>
	public bool HasAnyUserFocus() { return default; }
	///<summary>Returns true if any descendant widget is focused by any user.</summary>
	public bool HasFocusedDescendants() { return default; }
	///<summary>Returns true if any descendant widget is focused by a specific user.</summary>
	public bool HasUserFocusedDescendants(APlayerController PlayerController) { return default; }
	///<summary>Sets the focus to this widget for the owning user</summary>
	public void SetFocus() {}
	///<summary>Sets the focus to this widget for a specific user (if setting focus for the owning user, prefer SetFocus())</summary>
	public void SetUserFocus(APlayerController PlayerController) {}
	///<summary>Forces a pre-pass.  A pre-pass caches the desired size of the widget hierarchy owned by this widget.</summary>
	public void ForceLayoutPrepass() {}
	///<summary>Invalidates the widget from the view of a layout caching widget that may own this widget.</summary>
	public void InvalidateLayoutAndVolatility() {}
	///<summary>Gets the widgets desired size.</summary>
	public FVector2D GetDesiredSize() { return default; }
	///<summary>Sets the widget navigation rules for all directions. This can only be called on widgets that are in a widget tree.</summary>
	public void SetAllNavigationRules(EUINavigationRule Rule,FName WidgetToFocus) {}
	///<summary>SetNavigationRule</summary>
	public void SetNavigationRule(EUINavigation Direction,EUINavigationRule Rule,FName WidgetToFocus) {}
	///<summary>Sets the widget navigation rules for a specific direction. This can only be called on widgets that are in a widget tree. This works only for non Explicit, non Custom and non CustomBoundary Rules.</summary>
	public void SetNavigationRuleBase(EUINavigation Direction,EUINavigationRule Rule) {}
	///<summary>Sets the widget navigation rules for a specific direction. This can only be called on widgets that are in a widget tree. This works only for Explicit Rule.</summary>
	public void SetNavigationRuleExplicit(EUINavigation Direction,UWidget InWidget) {}
	///<summary>Sets the widget navigation rules for a specific direction. This can only be called on widgets that are in a widget tree. This works only for Custom Rule.</summary>
	public void SetNavigationRuleCustom(EUINavigation Direction,FCustomWidgetNavigationDelegate InCustomDelegate) {}
	///<summary>Sets the widget navigation rules for a specific direction. This can only be called on widgets that are in a widget tree. This works only for CustomBoundary Rule.</summary>
	public void SetNavigationRuleCustomBoundary(EUINavigation Direction,FCustomWidgetNavigationDelegate InCustomDelegate) {}
	///<summary>Gets the parent widget</summary>
	public UPanelWidget GetParent() { return default; }
	///<summary>Removes the widget from its parent widget.  If this widget was added to the player&#39;s screen or the viewport</summary>
	public virtual void RemoveFromParent() {}
	///<summary>Gets the last geometry used to Tick the widget.  This data may not exist yet if this call happens prior to</summary>
	public FGeometry GetCachedGeometry() { return default; }
	///<summary>GetTickSpaceGeometry</summary>
	public FGeometry GetTickSpaceGeometry() { return default; }
	///<summary>GetPaintSpaceGeometry</summary>
	public FGeometry GetPaintSpaceGeometry() { return default; }
	///<summary>K2_AddFieldValueChangedDelegate</summary>
	public void K2_AddFieldValueChangedDelegate(FFieldNotificationId FieldId,FFieldValueChangedDynamicDelegate Delegate) {}
	///<summary>K2_RemoveFieldValueChangedDelegate</summary>
	public void K2_RemoveFieldValueChangedDelegate(FFieldNotificationId FieldId,FFieldValueChangedDynamicDelegate Delegate) {}
	///<summary>K2_BroadcastFieldValueChanged</summary>
	public void K2_BroadcastFieldValueChanged(FFieldNotificationId FieldId) {}
	///<summary>Gets the game instance associated with this UI.</summary>
	public UGameInstance GetGameInstance() { return default; }
	///<summary>Gets the player controller associated with this UI.</summary>
	public virtual APlayerController GetOwningPlayer() { return default; }
	///<summary>Gets the local player associated with this UI.</summary>
	public virtual ULocalPlayer GetOwningLocalPlayer() { return default; }
	///<summary>Gets the accessible text from the underlying Slate accessible widget</summary>
	public FText GetAccessibleText() { return default; }
	///<summary>Gets the accessible summary text from the underlying Slate accessible widget.</summary>
	public FText GetAccessibleSummaryText() { return default; }
	///<summary>Native property bindings.</summary>
	public TArray<UPropertyBinding> NativeBindings;
	///<summary>Any flags used by the designer at edit time.</summary>
	public byte DesignerFlags;
	///<summary>The friendly name for this widget displayed in the designer and BP graph.</summary>
	public string DisplayLabel;
	///<summary>Category name used in the widget designer for sorting purpose</summary>
	public string CategoryName;
}
