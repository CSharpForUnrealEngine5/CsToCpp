#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavGraph/NavigationGraphNodeComponent.h")]
public partial class UNavigationGraphNodeComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FNavGraphNode Node;
	///<summary>NextNodeComponent</summary>
	public UNavigationGraphNodeComponent NextNodeComponent;
	///<summary>PrevNodeComponent</summary>
	public UNavigationGraphNodeComponent PrevNodeComponent;
}
