namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selection from the UI to Snap To. Contains a set of Actors and/or Control Rigs to snap onto or from.</summary>
[CppInclude("Tools/ControlRigSnapper.h")]
public partial struct FControlRigSnapperSelection {
	public TArray<FActorForWorldTransforms> Actors;
	public TArray<FControlRigForWorldTransforms> ControlRigs;
}
