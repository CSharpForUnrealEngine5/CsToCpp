#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXControlConsoleActor.h")]
///<summary>Actor class for DMX Control Console</summary>
public partial class ADMXControlConsoleActor : AActor {
// DMXControlConsoleActor
	public  void StartSendingDMX() {}
	public  void StopSendingDMX() {}
	public UDMXControlConsoleData ControlConsoleData;
	public bool bAutoActivate;
	public bool bSendDMXInEditor;
	public USceneComponent RootSceneComponent;
}
