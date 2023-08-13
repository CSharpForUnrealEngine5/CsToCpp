namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/TestBTService_Log.h")]
public partial class UTestBTService_Log : UBTService {
	public static UClass StaticClass() {return default;}
	///<summary>LogActivation</summary>
	public int LogActivation;
	///<summary>LogDeactivation</summary>
	public int LogDeactivation;
	///<summary>KeyNameTick</summary>
	public string KeyNameTick;
	///<summary>KeyNameBecomeRelevant</summary>
	public string KeyNameBecomeRelevant;
	///<summary>KeyNameCeaseRelevant</summary>
	public string KeyNameCeaseRelevant;
	///<summary>LogTick</summary>
	public int LogTick;
	///<summary>bToggleValue</summary>
	public bool bToggleValue;
}
