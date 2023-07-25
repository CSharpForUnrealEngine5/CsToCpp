#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BehaviorTreeManager.h")]
public partial class UBehaviorTreeManager : UObject {
// BehaviorTreeManager
	public int MaxDebuggerSteps;
	public TArray<FBehaviorTreeTemplateInfo> LoadedTemplates;
	public TArray<UBehaviorTreeComponent> ActiveComponents;
}
