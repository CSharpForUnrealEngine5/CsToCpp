namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoolColumn.h")]
public partial struct FBoolColumn {
	public FInstancedStruct InputValue;
	public TArray<bool> RowValues_DEPRECATED;
	public EBoolColumnCellValue DefaultRowValue;
	public TArray<EBoolColumnCellValue> RowValuesWithAny;
}
