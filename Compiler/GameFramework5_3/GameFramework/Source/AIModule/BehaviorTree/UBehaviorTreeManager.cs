namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BehaviorTreeManager.h")]
public partial class UBehaviorTreeManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>limit for recording execution steps for debugger</summary>
	public int MaxDebuggerSteps;
	///<summary>initialized tree templates</summary>
	public TArray<FBehaviorTreeTemplateInfo> LoadedTemplates;
	///<summary>ActiveComponents</summary>
	public TArray<UBehaviorTreeComponent> ActiveComponents;
}
