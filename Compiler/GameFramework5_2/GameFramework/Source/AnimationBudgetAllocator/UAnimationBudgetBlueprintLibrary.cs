#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationBudgetBlueprintLibrary.h")]
///<summary>Function library to expose the budget allocator to Blueprints</summary>
public partial class UAnimationBudgetBlueprintLibrary : UBlueprintFunctionLibrary {
// AnimationBudgetBlueprintLibrary
	public static void EnableAnimationBudget(UObject WorldContextObject,bool bEnabled) {}
	public static void SetAnimationBudgetParameters(UObject WorldContextObject,FAnimationBudgetAllocatorParameters InParameters) {}
}
