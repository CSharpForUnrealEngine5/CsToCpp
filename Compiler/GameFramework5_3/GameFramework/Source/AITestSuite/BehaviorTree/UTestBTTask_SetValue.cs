namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/TestBTTask_SetValue.h")]
public partial class UTestBTTask_SetValue : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>KeyName</summary>
	public FName KeyName;
	///<summary>Value</summary>
	public int Value;
	///<summary>OnAbortKeyName</summary>
	public FName OnAbortKeyName;
	///<summary>OnAbortValue</summary>
	public int OnAbortValue;
	///<summary>TaskResult</summary>
	public EBTNodeResult TaskResult;
}
