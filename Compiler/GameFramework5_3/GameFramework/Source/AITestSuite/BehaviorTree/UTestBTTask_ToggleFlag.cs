namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/TestBTTask_ToggleFlag.h")]
public partial class UTestBTTask_ToggleFlag : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>LogIndex</summary>
	public int LogIndex;
	///<summary>KeyName</summary>
	public FName KeyName;
	///<summary>NumToggles</summary>
	public int NumToggles;
	///<summary>TaskResult</summary>
	public EBTNodeResult TaskResult;
}
