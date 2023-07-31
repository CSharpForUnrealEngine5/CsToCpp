#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/TestBTTask_SetValue.h")]
public partial class UTestBTTask_SetValue : UBTTaskNode {
	///<summary>KeyName</summary>
	public string KeyName;
	///<summary>Value</summary>
	public int Value;
	///<summary>OnAbortKeyName</summary>
	public string OnAbortKeyName;
	///<summary>OnAbortValue</summary>
	public int OnAbortValue;
	///<summary>TaskResult</summary>
	public EBTNodeResult TaskResult;
}
