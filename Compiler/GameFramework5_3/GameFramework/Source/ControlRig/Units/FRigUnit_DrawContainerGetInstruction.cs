namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Get Imported Draw Container curve transform and color</summary>
[CppInclude("Units/Drawing/RigUnit_DrawContainer.h")]
public partial struct FRigUnit_DrawContainerGetInstruction {
	public FName InstructionName;
	public FLinearColor Color;
	public FTransform Transform;
}
