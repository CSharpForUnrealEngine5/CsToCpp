#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataDrivenCVars/DataDrivenCVars.h")]
public partial struct FDataDrivenConsoleVariable {
// DataDrivenConsoleVariable
	public FDataDrivenCVarType Type;
	public string Name;
	public string ToolTip;
	public float DefaultValueFloat;
	public int DefaultValueInt;
	public bool DefaultValueBool;
}
