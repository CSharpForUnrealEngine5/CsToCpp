#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_TemporaryVariable.h")]
public partial class UK2Node_TemporaryVariable : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>VariableType</summary>
	public FEdGraphPinType VariableType;
	///<summary>Whether or not this variable should be flagged with CPF_SaveGame, and inherit its name from the GUID of the macro that that gave rise to it</summary>
	public bool bIsPersistent;
}
