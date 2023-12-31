namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a component to allow interaction with the Widget Component.  This class allows you to</summary>
[CppInclude("Components/WidgetInteractionComponent.h")]
public partial class UWidgetInteractionComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Called when the hovered Widget Component changes.  The interaction component functions at the Slate</summary>
	public FOnHoveredWidgetChanged OnHoveredWidgetChanged;
	///<summary>Presses a key as if the mouse/pointer were the source of it.  Normally you would just use</summary>
	public virtual void PressPointerKey(FKey Key) {}
	///<summary>Releases a key as if the mouse/pointer were the source of it.  Normally you would just use</summary>
	public virtual void ReleasePointerKey(FKey Key) {}
	///<summary>Press a key as if it had come from the keyboard.  Avoid using this for &#39;a-z|A-Z&#39;, things like</summary>
	public virtual bool PressKey(FKey Key,bool bRepeat/*=false*/) { return default; }
	///<summary>Releases a key as if it had been released by the keyboard.</summary>
	public virtual bool ReleaseKey(FKey Key) { return default; }
	///<summary>Does both the press and release of a simulated keyboard key.</summary>
	public virtual bool PressAndReleaseKey(FKey Key) { return default; }
	///<summary>Transmits a list of characters to a widget by simulating a OnKeyChar event for each key listed in</summary>
	public virtual bool SendKeyChar(string Characters,bool bRepeat/*=false*/) { return default; }
	///<summary>Sends a scroll wheel event to the widget under the last hit result.</summary>
	public virtual void ScrollWheel(float ScrollDelta) {}
	///<summary>Get the currently hovered widget component.</summary>
	public UWidgetComponent GetHoveredWidgetComponent() { return default; }
	///<summary>Returns true if a widget under the hit result is interactive.  e.g. Slate widgets</summary>
	public bool IsOverInteractableWidget() { return default; }
	///<summary>Returns true if a widget under the hit result is focusable.  e.g. Slate widgets that</summary>
	public bool IsOverFocusableWidget() { return default; }
	///<summary>Returns true if a widget under the hit result is has a visibility that makes it hit test</summary>
	public bool IsOverHitTestVisibleWidget() { return default; }
	///<summary>Gets the last hit result generated by the component.  Returns the custom hit result if that was set.</summary>
	public FHitResult GetLastHitResult() { return default; }
	///<summary>Gets the last hit location on the widget in 2D, local pixel units of the render target.</summary>
	public FVector2D Get2DHitLocation() { return default; }
	///<summary>Set custom hit result.  This is only taken into account if InteractionSource is set to EWidgetInteractionSource::Custom.</summary>
	public void SetCustomHitResult(FHitResult HitResult) {}
	///<summary>Set the focus target of the virtual user managed by this component</summary>
	public void SetFocus(UWidget FocusWidget) {}
	///<summary>Represents the Virtual User Index.  Each virtual user should be represented by a different</summary>
	public int VirtualUserIndex;
	///<summary>Each user virtual controller or virtual finger tips being simulated should use a different pointer index.</summary>
	public int PointerIndex;
	///<summary>The trace channel to use when tracing for widget components in the world.</summary>
	public ECollisionChannel TraceChannel;
	///<summary>The distance in game units the component should be able to interact with a widget component.</summary>
	public float InteractionDistance;
	///<summary>Should we project from the world location of the component?  If you set this to false, you&#39;ll</summary>
	public EWidgetInteractionSource InteractionSource;
	///<summary>Should the interaction component perform hit testing (Automatic or Custom) and attempt to</summary>
	public bool bEnableHitTesting;
	///<summary>Shows some debugging lines and a hit sphere to help you debug interactions.</summary>
	public bool bShowDebug;
	///<summary>Determines the line thickness of the debug sphere.</summary>
	public float DebugSphereLineThickness;
	///<summary>Determines the thickness of the debug lines.</summary>
	public float DebugLineThickness;
	///<summary>Determines the color of the debug lines.</summary>
	public FLinearColor DebugColor;
	///<summary>Stores the custom hit result set by the player.</summary>
	public FHitResult CustomHitResult;
	///<summary>The 2D location on the widget component that was hit.</summary>
	public FVector2D LocalHitLocation;
	///<summary>The last 2D location on the widget component that was hit.</summary>
	public FVector2D LastLocalHitLocation;
	///<summary>The widget component we&#39;re currently hovering over.</summary>
	public UWidgetComponent HoveredWidgetComponent;
	///<summary>The last hit result we used.</summary>
	public FHitResult LastHitResult;
	///<summary>Are we hovering over any interactive widgets.</summary>
	public bool bIsHoveredWidgetInteractable;
	///<summary>Are we hovering over any focusable widget?</summary>
	public bool bIsHoveredWidgetFocusable;
	///<summary>Are we hovered over a widget that is hit test visible?</summary>
	public bool bIsHoveredWidgetHitTestVisible;
	///<summary>The arrow component we show at editor time.</summary>
	public UArrowComponent ArrowComponent;
}
