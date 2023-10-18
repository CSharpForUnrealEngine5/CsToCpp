namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class used to define settings for Smart Object navigation and collision validation.</summary>
[CppInclude("SmartObjectTypes.h")]
public partial class USmartObjectSlotValidationFilter : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Parameters to use for validating entry locations or general collision validation.</summary>
	public FSmartObjectSlotValidationParams EntryParameters;
	///<summary>If true, use separate settings for validating exit locations.</summary>
	public bool bUseEntryParametersForExit;
	///<summary>Parameters to use for validating exit locations. The separate set allows to specify looser settings on exits.</summary>
	public FSmartObjectSlotValidationParams ExitParameters;
}
