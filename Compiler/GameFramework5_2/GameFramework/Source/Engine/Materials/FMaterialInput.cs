#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/Material.h")]
///<summary>Material input structs.</summary>
public partial struct FMaterialInput {
// MaterialInput
	public UMaterialExpression Expression;
	public int OutputIndex;
	public string InputName;
	public int Mask;
	public int MaskR;
	public int MaskG;
	public int MaskB;
	public int MaskA;
}
