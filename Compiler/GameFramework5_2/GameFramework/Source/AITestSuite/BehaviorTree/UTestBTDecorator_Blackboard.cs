namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/TestBTDecorator_Blackboard.h")]
public partial class UTestBTDecorator_Blackboard : UBTDecorator_Blackboard {
	public static UClass StaticClass() {return default;}
	///<summary>LogIndexBecomeRelevant</summary>
	public int LogIndexBecomeRelevant;
	///<summary>LogIndexCeaseRelevant</summary>
	public int LogIndexCeaseRelevant;
	///<summary>LogIndexCalculate</summary>
	public int LogIndexCalculate;
}
