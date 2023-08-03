#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A label component specific to nDisplay. Displays a widget with a consistent scale facing the root actor view origin.</summary>
[CppInclude("Components/DisplayClusterLabelComponent.h")]
public partial class UDisplayClusterLabelComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The root actor this label needs to know about</summary>
	public TWeakObjectPtr<ADisplayClusterRootActor> RootActor;
	///<summary>The widget component to display for this label</summary>
	public UDisplayClusterWidgetComponent WidgetComponent;
	///<summary>The widget class to apply to the widget component</summary>
	public TSoftObjectPtr<UClass> WidgetClass;
	///<summary>A uniform scale to apply to the text which will keep consistency across distance from the label to the root actor view</summary>
	public float WidgetScale;
}
