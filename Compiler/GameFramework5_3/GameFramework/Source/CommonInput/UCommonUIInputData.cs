namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Derive from this class to store the Input data. It is referenced in the Common Input Settings, found in the project settings UI.</summary>
[CppInclude("CommonInputBaseTypes.h")]
public partial class UCommonUIInputData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultClickAction</summary>
	public FDataTableRowHandle DefaultClickAction;
	///<summary>DefaultBackAction</summary>
	public FDataTableRowHandle DefaultBackAction;
	///<summary>Newly created CommonButton widgets will use these hold values by default if bRequiresHold is true.</summary>
	public TSoftObjectPtr<UClass> DefaultHoldData;
	///<summary>EnhancedInputClickAction</summary>
	public UInputAction EnhancedInputClickAction;
	///<summary>EnhancedInputBackAction</summary>
	public UInputAction EnhancedInputBackAction;
}
