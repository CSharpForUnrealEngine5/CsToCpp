#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tools/ControlRigSnapper.h")]
///<summary>Specification containing a Control Rig and a list of selected Controls we use to get World Transforms for Snapping.</summary>
public partial struct FControlRigForWorldTransforms {
// ControlRigForWorldTransforms
	public TWeakObjectPtr<UControlRig> ControlRig;
	public TArray<string> ControlNames;
}
