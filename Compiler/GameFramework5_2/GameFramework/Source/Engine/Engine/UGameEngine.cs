#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Engine that manages core systems that enable a game.</summary>
[CppInclude("Engine/GameEngine.h")]
public partial class UGameEngine : UEngine {
	///<summary>Maximium delta time the engine uses to populate FApp::DeltaTime. If 0, unbound.</summary>
	public float MaxDeltaTime;
	///<summary>Maximium time (in seconds) between the flushes of the logs on the server (best effort). If 0, this will happen every tick.</summary>
	public float ServerFlushLogInterval;
	///<summary>GameInstance</summary>
	public UGameInstance GameInstance;
}
