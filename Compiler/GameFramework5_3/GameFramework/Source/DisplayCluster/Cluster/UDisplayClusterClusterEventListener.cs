namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Cluster/IDisplayClusterClusterEventListener.h")]
public partial class UDisplayClusterClusterEventListener : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>React on incoming JSON cluster events</summary>
	public void OnClusterEventJson(FDisplayClusterClusterEventJson Event) {}
	///<summary>React on incoming binary cluster events</summary>
	public void OnClusterEventBinary(FDisplayClusterClusterEventBinary Event) {}
}
