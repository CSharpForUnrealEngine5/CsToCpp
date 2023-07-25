#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DisplayClusterLabelComponent.h")]
///<summary>A label component specific to nDisplay. Displays a widget with a consistent scale facing the root actor view origin.</summary>
public partial class UDisplayClusterLabelComponent : USceneComponent {
// DisplayClusterLabelComponent
	public TWeakObjectPtr<ADisplayClusterRootActor> RootActor;
	public UDisplayClusterWidgetComponent WidgetComponent;
	public TSoftObjectPtr<UClass> WidgetClass;
	public float WidgetScale;
}
