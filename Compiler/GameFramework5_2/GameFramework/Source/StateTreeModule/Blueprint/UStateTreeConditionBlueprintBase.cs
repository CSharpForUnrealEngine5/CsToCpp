namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Base class for Blueprint based Conditions.</summary>
[CppInclude("Blueprint/StateTreeConditionBlueprintBase.h")]
public partial class UStateTreeConditionBlueprintBase : UStateTreeNodeBlueprintBase {
	public static UClass StaticClass() {return default;}
	///<summary>ReceiveTestCondition</summary>
	public bool ReceiveTestCondition() { return default; }
}
