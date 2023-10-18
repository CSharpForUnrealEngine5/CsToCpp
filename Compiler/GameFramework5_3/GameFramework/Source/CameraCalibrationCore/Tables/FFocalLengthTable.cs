namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Focal Length table containing FxFy values for each focus and zoom input values</summary>
[CppInclude("Tables/FocalLengthTable.h")]
public partial struct FFocalLengthTable {
	public TArray<FFocalLengthFocusPoint> FocusPoints;
}
