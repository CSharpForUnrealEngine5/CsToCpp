#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Evaluate the input field according to the result of the culling field</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UCullingField : UFieldNodeBase {
	///<summary>Evaluate the input field according to the result of the culling field.</summary>
	public  UCullingField SetCullingField(UFieldNodeBase Culling,UFieldNodeBase Field,EFieldCullingOperationType Operation) { return default; }
	///<summary>Culling field to be used</summary>
	public UFieldNodeBase Culling;
	///<summary>Input field that will be evaluated according to the culling field result</summary>
	public UFieldNodeBase Field;
	///<summary>Evaluate the input field if the result of the culling field is equal to 0 (Inside) or different from 0 (Outside)</summary>
	public EFieldCullingOperationType Operation;
}
