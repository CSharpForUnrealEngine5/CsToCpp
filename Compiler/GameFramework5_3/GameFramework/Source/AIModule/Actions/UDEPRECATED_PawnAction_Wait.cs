namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>uses system timers rather then ticking</summary>
[CppInclude("Actions/PawnAction_Wait.h")]
public partial class UDEPRECATED_PawnAction_Wait : UDEPRECATED_PawnAction {
	public static UClass StaticClass() {return default;}
	///<summary>TimeToWait</summary>
	public float TimeToWait;
}
