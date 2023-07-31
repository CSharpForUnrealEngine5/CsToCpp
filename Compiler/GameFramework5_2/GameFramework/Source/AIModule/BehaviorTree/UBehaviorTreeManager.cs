#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BehaviorTreeManager.h")]
public partial class UBehaviorTreeManager : UObject {
	///<summary>limit for recording execution steps for debugger</summary>
	public int MaxDebuggerSteps;
	///<summary>initialized tree templates</summary>
	public TArray<FBehaviorTreeTemplateInfo> LoadedTemplates;
	///<summary>ActiveComponents</summary>
	public TArray<UBehaviorTreeComponent> ActiveComponents;
}
