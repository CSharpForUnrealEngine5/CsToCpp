#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_Event.h")]
public partial class UK2Node_Event : UK2Node_EditablePinBase {
	///<summary>Name of function signature that this event implements</summary>
	public string EventSignatureName_DEPRECATED;
	///<summary>Class that the function signature is from.</summary>
	public UClass EventSignatureClass_DEPRECATED;
	///<summary>Reference for the function this event is linked to</summary>
	public FMemberReference EventReference;
	///<summary>If true, we are actually overriding this function, not making a new event with a signature that matches</summary>
	public bool bOverrideFunction;
	///<summary>If true, this event is internal machinery, and should not be marked BlueprintCallable</summary>
	public bool bInternalEvent;
	///<summary>If this is not an override, allow user to specify a name for the function created by this entry point</summary>
	public string CustomFunctionName;
	///<summary>Additional function flags to apply to this function</summary>
	public uint FunctionFlags;
}
