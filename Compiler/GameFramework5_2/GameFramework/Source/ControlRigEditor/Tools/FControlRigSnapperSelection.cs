#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/ControlRigSnapper.h")]
///<summary>Selection from the UI to Snap To. Contains a set of Actors and/or Control Rigs to snap onto or from.</summary>
public partial struct FControlRigSnapperSelection {
// ControlRigSnapperSelection
	public TArray<FActorForWorldTransforms> Actors;
	public TArray<FControlRigForWorldTransforms> ControlRigs;
}
