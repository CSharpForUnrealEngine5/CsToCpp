namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/PendingNetGame.h")]
public partial class UPendingNetGame : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Net driver created for contacting the new server</summary>
	public UNetDriver NetDriver;
	///<summary>Demo Net driver created for loading demos, but we need to go through pending net game</summary>
	public UDemoNetDriver DemoNetDriver;
}
