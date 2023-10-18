namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is the base class that both baked states and transitions use</summary>
[CppInclude("Animation/AnimStateMachineTypes.h")]
public partial struct FAnimationStateBase {
	public FName StateName;
}
