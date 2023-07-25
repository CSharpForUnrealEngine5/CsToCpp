#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemObjects.h")]
///<summary>Evaluate the input field according to the result of the culling field</summary>
public partial class UCullingField : UFieldNodeBase {
// CullingField
	public UObject SetCullingField(UObject Culling,UObject Field,EFieldCullingOperationType Operation) { return default; }
	public UFieldNodeBase Culling;
	public UFieldNodeBase Field;
	public byte Operation;
}
