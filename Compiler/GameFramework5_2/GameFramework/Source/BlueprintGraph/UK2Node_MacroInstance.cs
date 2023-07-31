#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_MacroInstance.h")]
public partial class UK2Node_MacroInstance : UK2Node_Tunnel {
	///<summary>A macro is like a composite node, except that the associated graph lives</summary>
	public UEdGraph MacroGraph_DEPRECATED;
	///<summary>MacroGraphReference</summary>
	public FGraphReference MacroGraphReference;
	///<summary>Stored type info for what type the wildcard pins in this macro should become.</summary>
	public FEdGraphPinType ResolvedWildcardType;
}
