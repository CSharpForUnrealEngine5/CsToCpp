namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Convert an integer field to a scalar one</summary>
[CppInclude("Field/FieldSystemObjects.h")]
public partial class UToFloatField : UFieldNodeFloat {
	public static UClass StaticClass() {return default;}
	///<summary>Convert an integer field to a float one</summary>
	public UToFloatField SetToFloatField(UFieldNodeInt IntegerField) { return default; }
	///<summary>Integer field to be converted to an a scalar one</summary>
	public UFieldNodeInt IntField;
}
