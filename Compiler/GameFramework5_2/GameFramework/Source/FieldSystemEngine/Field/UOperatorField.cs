namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute an operation between 2 incoming fields</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UOperatorField : UFieldNodeBase {
	public static UClass StaticClass() {return default;}
	///<summary>Compute an operation between 2 incoming fields</summary>
	public UOperatorField SetOperatorField(float Magnitude,UFieldNodeBase LeftField,UFieldNodeBase RightField,EFieldOperationType Operation) { return default; }
	///<summary>Magnitude of the operator field</summary>
	public float Magnitude;
	///<summary>Right field to be processed</summary>
	public UFieldNodeBase RightField;
	///<summary>Left field to be processed</summary>
	public UFieldNodeBase LeftField;
	///<summary>Type of operation you want to perform between the 2 fields</summary>
	public EFieldOperationType Operation;
}
