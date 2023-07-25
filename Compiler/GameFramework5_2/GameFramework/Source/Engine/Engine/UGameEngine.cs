#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/GameEngine.h")]
///<summary>Engine that manages core systems that enable a game.</summary>
public partial class UGameEngine : UEngine {
// GameEngine
	public float MaxDeltaTime;
	public float ServerFlushLogInterval;
	public UGameInstance GameInstance;
}
