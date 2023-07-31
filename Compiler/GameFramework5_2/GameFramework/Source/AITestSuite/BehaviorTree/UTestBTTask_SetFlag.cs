#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/TestBTTask_SetFlag.h")]
public partial class UTestBTTask_SetFlag : UBTTaskNode {
	///<summary>KeyName</summary>
	public string KeyName;
	///<summary>bValue</summary>
	public bool bValue;
	///<summary>OnAbortKeyName</summary>
	public string OnAbortKeyName;
	///<summary>bOnAbortValue</summary>
	public bool bOnAbortValue;
	///<summary>TaskResult</summary>
	public EBTNodeResult TaskResult;
}
