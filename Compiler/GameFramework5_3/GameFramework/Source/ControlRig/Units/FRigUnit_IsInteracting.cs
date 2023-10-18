namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns true if the Control Rig is being interacted</summary>
[CppInclude("Units/Execution/RigUnit_IsInteracting.h")]
public partial struct FRigUnit_IsInteracting {
	public bool bIsInteracting;
	public bool bIsTranslating;
	public bool bIsRotating;
	public bool bIsScaling;
	public TArray<FRigElementKey> Items;
}
