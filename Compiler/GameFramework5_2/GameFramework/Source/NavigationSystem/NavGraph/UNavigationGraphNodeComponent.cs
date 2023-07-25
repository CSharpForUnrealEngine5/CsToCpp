#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavGraph/NavigationGraphNodeComponent.h")]
public partial class UNavigationGraphNodeComponent : USceneComponent {
// NavigationGraphNodeComponent
	public FNavGraphNode Node;
	public UNavigationGraphNodeComponent NextNodeComponent;
	public UNavigationGraphNodeComponent PrevNodeComponent;
}
