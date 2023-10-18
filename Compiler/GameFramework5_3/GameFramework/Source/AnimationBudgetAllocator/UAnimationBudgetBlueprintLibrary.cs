namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library to expose the budget allocator to Blueprints</summary>
[CppInclude("AnimationBudgetBlueprintLibrary.h")]
public partial class UAnimationBudgetBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Enable/disable the animation budgeting system.</summary>
	public static void EnableAnimationBudget(UObject WorldContextObject,bool bEnabled) {}
	///<summary>Set the parameters of the animation budgeting system.</summary>
	public static void SetAnimationBudgetParameters(UObject WorldContextObject,FAnimationBudgetAllocatorParameters InParameters) {}
}
