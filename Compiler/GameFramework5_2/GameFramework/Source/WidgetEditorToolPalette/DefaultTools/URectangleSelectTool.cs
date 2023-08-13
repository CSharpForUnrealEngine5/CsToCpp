namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>URectangleSelectTool is a simple marque widget select tool.</summary>
[CppInclude("DefaultTools/RectangleSelectTool.h")]
public partial class URectangleSelectTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>Properties of the tool are stored here</summary>
	public URectangleSelectProperties Properties;
}
