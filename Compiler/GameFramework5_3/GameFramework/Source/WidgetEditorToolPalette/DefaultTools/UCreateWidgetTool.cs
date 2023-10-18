namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UCreateWidgetTool is a tool that allows for a specific widget to be created on click</summary>
[CppInclude("DefaultTools/CreateWidgetTool.h")]
public partial class UCreateWidgetTool : USingleClickTool {
	public static UClass StaticClass() {return default;}
	///<summary>Properties</summary>
	public UCreateWidgetToolProperties Properties;
}
