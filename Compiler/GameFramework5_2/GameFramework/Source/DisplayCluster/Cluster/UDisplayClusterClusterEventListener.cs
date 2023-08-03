#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Cluster/IDisplayClusterClusterEventListener.h")]
public partial class UDisplayClusterClusterEventListener : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>React on incoming JSON cluster events</summary>
	public  void OnClusterEventJson(FDisplayClusterClusterEventJson Event) {}
	///<summary>React on incoming binary cluster events</summary>
	public  void OnClusterEventBinary(FDisplayClusterClusterEventBinary Event) {}
}
