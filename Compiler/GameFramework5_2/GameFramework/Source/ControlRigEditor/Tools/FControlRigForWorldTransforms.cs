#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specification containing a Control Rig and a list of selected Controls we use to get World Transforms for Snapping.</summary>
[CppInclude("Tools/ControlRigSnapper.h")]
public partial struct FControlRigForWorldTransforms {
	public TWeakObjectPtr<UControlRig> ControlRig;
	public TArray<string> ControlNames;
}
