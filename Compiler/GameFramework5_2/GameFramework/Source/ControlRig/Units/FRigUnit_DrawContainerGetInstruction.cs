#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Get Imported Draw Container curve transform and color</summary>
[CppInclude("Units/Drawing/RigUnit_DrawContainer.h")]
public partial struct FRigUnit_DrawContainerGetInstruction {
	public string InstructionName;
	public FLinearColor Color;
	public FTransform Transform;
}
