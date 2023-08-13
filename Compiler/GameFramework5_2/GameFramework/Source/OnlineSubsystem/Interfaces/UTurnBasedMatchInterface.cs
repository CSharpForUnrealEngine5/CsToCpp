namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Interfaces/TurnBasedMatchInterface.h")]
public partial class UTurnBasedMatchInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>OnMatchReceivedTurn</summary>
	public void OnMatchReceivedTurn(string Match,bool bDidBecomeActive) {}
	///<summary>OnMatchEnded</summary>
	public void OnMatchEnded(string Match) {}
}
