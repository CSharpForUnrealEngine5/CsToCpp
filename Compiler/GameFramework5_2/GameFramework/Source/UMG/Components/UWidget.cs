#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/Widget.h")]
///<summary>This is the base class for all wrapped Slate controls that are exposed to UObjects.</summary>
public partial class UWidget : UVisual {
// Widget
	public bool FGetBool() { return default; }
	public float FGetFloat() { return default; }
	public int FGetInt32() { return default; }
	public string FGetText() { return default; }
	public FSlateColor FGetSlateColor() { return default; }
	public FLinearColor FGetLinearColor() { return default; }
	public FSlateBrush FGetSlateBrush() { return default; }
	public ESlateVisibility FGetSlateVisibility() { return default; }
	public EMouseCursor FGetMouseCursor() { return default; }
	public ECheckBoxState FGetCheckBoxState() { return default; }
	public UObject FGetWidget() { return default; }
	public UObject FGenerateWidgetForString(string Item) { return default; }
	public UObject FGenerateWidgetForObject(UObject Item) { return default; }
	public FEventReply FOnReply() { return default; }
	public FEventReply FOnPointerEvent(FGeometry MyGeometry,FPointerEvent MouseEvent) { return default; }
	public UPanelSlot Slot;
	public FGetBool bIsEnabledDelegate;
	public string ToolTipText;
	public FGetText ToolTipTextDelegate;
	public UWidget ToolTipWidget;
	public FGetWidget ToolTipWidgetDelegate;
	public FGetSlateVisibility VisibilityDelegate;
	public FWidgetTransform RenderTransform;
	public FVector2D RenderTransformPivot;
	public EFlowDirectionPreference FlowDirectionPreference;
	public bool bIsVariable;
	public bool bCreatedByConstructionScript;
	public bool bIsEnabled;
	public bool bOverride_Cursor;
	public bool bOverrideAccessibleDefaults;
	public bool bCanChildrenBeAccessible;
	public ESlateAccessibleBehavior AccessibleBehavior;
	public ESlateAccessibleBehavior AccessibleSummaryBehavior;
	public string AccessibleText;
	public FGetText AccessibleTextDelegate;
	public string AccessibleSummaryText;
	public FGetText AccessibleSummaryTextDelegate;
	public bool bIsVolatile;
	public bool bHiddenInDesigner;
	public bool bExpandedInDesigner;
	public bool bLockedInDesigner;
	public byte Cursor;
	public EWidgetClipping Clipping;
	public ESlateVisibility Visibility;
	public float RenderOpacity;
	public USlateAccessibleWidgetData AccessibleWidgetData;
	public UWidgetNavigation Navigation;
	public void SetRenderTransform(FWidgetTransform InTransform) {}
	public void SetRenderScale(FVector2D Scale) {}
	public void SetRenderShear(FVector2D Shear) {}
	public void SetRenderTransformAngle(float Angle) {}
	public float GetRenderTransformAngle() { return default; }
	public void SetRenderTranslation(FVector2D Translation) {}
	public void SetRenderTransformPivot(FVector2D Pivot) {}
	public bool GetIsEnabled() { return default; }
	public void SetIsEnabled(bool bInIsEnabled) {}
	public bool IsInViewport() { return default; }
	public void SetToolTipText(string InToolTipText) {}
	public void SetToolTip(UObject Widget) {}
	public void SetCursor(EMouseCursor InCursor) {}
	public void ResetCursor() {}
	public bool IsRendered() { return default; }
	public bool IsVisible() { return default; }
	public ESlateVisibility GetVisibility() { return default; }
	public void SetVisibility(ESlateVisibility InVisibility) {}
	public float GetRenderOpacity() { return default; }
	public void SetRenderOpacity(float InOpacity) {}
	public EWidgetClipping GetClipping() { return default; }
	public void SetClipping(EWidgetClipping InClipping) {}
	public void ForceVolatile(bool bForce) {}
	public bool IsHovered() { return default; }
	public bool HasKeyboardFocus() { return default; }
	public bool HasMouseCapture() { return default; }
	public bool HasMouseCaptureByUser(int UserIndex,int PointerIndex/*=-1*/) { return default; }
	public void SetKeyboardFocus() {}
	public bool HasUserFocus(UObject PlayerController) { return default; }
	public bool HasAnyUserFocus() { return default; }
	public bool HasFocusedDescendants() { return default; }
	public bool HasUserFocusedDescendants(UObject PlayerController) { return default; }
	public void SetFocus() {}
	public void SetUserFocus(UObject PlayerController) {}
	public void ForceLayoutPrepass() {}
	public void InvalidateLayoutAndVolatility() {}
	public FVector2D GetDesiredSize() { return default; }
	public void SetAllNavigationRules(EUINavigationRule Rule,string WidgetToFocus) {}
	public void SetNavigationRule(EUINavigation Direction,EUINavigationRule Rule,string WidgetToFocus) {}
	public void SetNavigationRuleBase(EUINavigation Direction,EUINavigationRule Rule) {}
	public void SetNavigationRuleExplicit(EUINavigation Direction,UObject InWidget) {}
	public void SetNavigationRuleCustom(EUINavigation Direction,FCustomWidgetNavigationDelegate InCustomDelegate) {}
	public void SetNavigationRuleCustomBoundary(EUINavigation Direction,FCustomWidgetNavigationDelegate InCustomDelegate) {}
	public UObject GetParent() { return default; }
	public void RemoveFromParent() {}
	public FGeometry GetCachedGeometry() { return default; }
	public FGeometry GetTickSpaceGeometry() { return default; }
	public FGeometry GetPaintSpaceGeometry() { return default; }
	public void K2_AddFieldValueChangedDelegate(FFieldNotificationId FieldId,FFieldValueChangedDynamicDelegate Delegate) {}
	public void K2_RemoveFieldValueChangedDelegate(FFieldNotificationId FieldId,FFieldValueChangedDynamicDelegate Delegate) {}
	public void K2_BroadcastFieldValueChanged(FFieldNotificationId FieldId) {}
	public UObject GetGameInstance() { return default; }
	public UObject GetOwningPlayer() { return default; }
	public UObject GetOwningLocalPlayer() { return default; }
	public string GetAccessibleText() { return default; }
	public string GetAccessibleSummaryText() { return default; }
	public TArray<UPropertyBinding> NativeBindings;
	public byte DesignerFlags;
	public string DisplayLabel;
	public string CategoryName;
}
