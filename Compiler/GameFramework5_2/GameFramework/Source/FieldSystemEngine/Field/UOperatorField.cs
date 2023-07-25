#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemObjects.h")]
///<summary>Compute an operation between 2 incoming fields</summary>
public partial class UOperatorField : UFieldNodeBase {
// OperatorField
	public UObject SetOperatorField(float Magnitude,UObject LeftField,UObject RightField,EFieldOperationType Operation) { return default; }
	public float Magnitude;
	public UFieldNodeBase RightField;
	public UFieldNodeBase LeftField;
	public byte Operation;
}
