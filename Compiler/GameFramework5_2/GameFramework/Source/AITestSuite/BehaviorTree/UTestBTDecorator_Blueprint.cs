namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/TestBTDecorator_Blueprint.h")]
public partial class UTestBTDecorator_Blueprint : UBTDecorator_BlueprintBase {
	public static UClass StaticClass() {return default;}
	///<summary>BPConditionType</summary>
	public EBPConditionType BPConditionType;
	///<summary>LogIndexBecomeRelevant</summary>
	public int LogIndexBecomeRelevant;
	///<summary>LogIndexCeaseRelevant</summary>
	public int LogIndexCeaseRelevant;
	///<summary>LogIndexCalculate</summary>
	public int LogIndexCalculate;
	///<summary>ObservingKeyName</summary>
	public string ObservingKeyName;
}
