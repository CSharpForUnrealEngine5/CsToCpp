namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>CommonUI Viewport to reroute input to UI first. Needed to allow CommonUI to route / handle inputs.</summary>
[CppInclude("CommonGameViewportClient.h")]
public partial class UCommonGameViewportClient : UGameViewportClient {
	public static UClass StaticClass() {return default;}
}
