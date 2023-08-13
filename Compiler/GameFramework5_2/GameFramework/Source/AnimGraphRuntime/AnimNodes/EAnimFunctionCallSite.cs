namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimNodes/AnimNode_CallFunction.h")]
///<summary>When to call the function during the execution of the animation graph</summary>
public enum EAnimFunctionCallSite {
	OnInitialize=0,
	OnUpdate=1,
	OnBecomeRelevant=2,
	OnEvaluate=3,
	OnInitializePostRecursion=4,
	OnUpdatePostRecursion=5,
	OnBecomeRelevantPostRecursion=6,
	OnEvaluatePostRecursion=7,
	OnStartedBlendingOut=8,
	OnStartedBlendingIn=9,
	OnFinishedBlendingOut=10,
	OnFinishedBlendingIn=11,
}
