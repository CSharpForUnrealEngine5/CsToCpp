namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoolColumn.h")]
public partial class UDEPRECATED_ChooserColumnBool : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>InputValue</summary>
	public object /*InputValue*/ InputValue;
	///<summary>array of results (cells for this column for each row in the table)</summary>
	public TArray<bool> RowValues;
}
