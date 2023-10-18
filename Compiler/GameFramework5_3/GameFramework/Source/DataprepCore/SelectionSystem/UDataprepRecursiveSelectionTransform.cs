namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSystem/DataprepSelectionTransform.h")]
public partial class UDataprepRecursiveSelectionTransform : UDataprepSelectionTransform {
	public static UClass StaticClass() {return default;}
	///<summary>How many times is it allowed to apply another transform on the result</summary>
	public int AllowRecursionLevels;
}
