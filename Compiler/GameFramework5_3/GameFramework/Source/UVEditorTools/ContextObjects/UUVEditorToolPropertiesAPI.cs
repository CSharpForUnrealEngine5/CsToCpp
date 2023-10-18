namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores pointers to additional property sets for the active tool, used by the UVEditor Mode and Toolkit to</summary>
[CppInclude("ContextObjects/UVToolContextObjects.h")]
public partial class UUVEditorToolPropertiesAPI : UUVToolContextObject {
	public static UClass StaticClass() {return default;}
	///<summary>ToolDisplayProperties</summary>
	public UObject ToolDisplayProperties;
}
