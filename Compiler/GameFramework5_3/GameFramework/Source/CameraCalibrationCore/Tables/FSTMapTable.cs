namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>STMap table containing list of points for each focus and zoom inputs</summary>
[CppInclude("Tables/STMapTable.h")]
public partial struct FSTMapTable {
	public TArray<FSTMapFocusPoint> FocusPoints;
}
