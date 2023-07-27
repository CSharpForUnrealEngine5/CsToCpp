#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Interfaces/TurnBasedMatchInterface.h")]
public partial class UTurnBasedMatchInterface : UInterface {
// TurnBasedMatchInterface
	public  void OnMatchReceivedTurn(string Match,bool bDidBecomeActive) {}
	public  void OnMatchEnded(string Match) {}
}
