#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_IsInteracting.h")]
///<summary>Returns true if the Control Rig is being interacted</summary>
public partial struct FRigUnit_IsInteracting {
// RigUnit_IsInteracting
	public bool bIsInteracting;
	public bool bIsTranslating;
	public bool bIsRotating;
	public bool bIsScaling;
	public TArray<FRigElementKey> Items;
}
