namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Builders/SheetBuilder.h")]
public partial class USheetBuilder : UEditorBrushBuilder {
	public static UClass StaticClass() {return default;}
	///<summary>X</summary>
	public int X;
	///<summary>Y</summary>
	public int Y;
	///<summary>XSegments</summary>
	public int XSegments;
	///<summary>YSegments</summary>
	public int YSegments;
	///<summary>Axis</summary>
	public ESheetAxis Axis;
	///<summary>GroupName</summary>
	public FName GroupName;
}
