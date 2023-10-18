namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data structure for storing PIE login credentials</summary>
[CppInclude("PlayInEditorDataTypes.h")]
public partial struct FPIELoginInfo {
	public string Type;
	public string Id;
	public string Token;
}
