#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Convert a scalar field to a integer one</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UToIntegerField : UFieldNodeInt {
	///<summary>Convert a float field to a integer one</summary>
	public  UToIntegerField SetToIntegerField(UFieldNodeFloat FloatField) { return default; }
	///<summary>Scalar field to be converted to an an integer one</summary>
	public UFieldNodeFloat FloatField;
}
