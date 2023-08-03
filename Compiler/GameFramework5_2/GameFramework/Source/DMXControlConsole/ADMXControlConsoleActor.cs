#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor class for DMX Control Console</summary>
[CppInclude("DMXControlConsoleActor.h")]
public partial class ADMXControlConsoleActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Sets current DMX Control Console to start sending DMX data</summary>
	public  void StartSendingDMX() {}
	///<summary>Sets current DMX Control Console to stop sending DMX data</summary>
	public  void StopSendingDMX() {}
	///<summary>The Control Console Data used in this actor</summary>
	public UDMXControlConsoleData ControlConsoleData;
	///<summary>True if the Control Console should send DMX data in runtime</summary>
	public bool bAutoActivate;
	///<summary>True if the Control Console should send DMX data in Editor</summary>
	public bool bSendDMXInEditor;
	///<summary>Scene component to make the Actor easily visible in Editor</summary>
	public USceneComponent RootSceneComponent;
}
