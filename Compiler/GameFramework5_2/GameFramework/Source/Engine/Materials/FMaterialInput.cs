#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Material input structs.</summary>
[CppInclude("Materials/Material.h")]
public partial struct FMaterialInput {
	public UMaterialExpression Expression;
	public int OutputIndex;
	public string InputName;
	public int Mask;
	public int MaskR;
	public int MaskG;
	public int MaskB;
	public int MaskA;
}
