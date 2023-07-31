#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Derive from this class to store the Input data. It is referenced in the Common Input Settings, found in the project settings UI.</summary>
[CppInclude("CommonInputBaseTypes.h")]
public partial class UCommonUIInputData : UObject {
	///<summary>DefaultClickAction</summary>
	public FDataTableRowHandle DefaultClickAction;
	///<summary>DefaultBackAction</summary>
	public FDataTableRowHandle DefaultBackAction;
	///<summary>EnhancedInputClickAction</summary>
	public UInputAction EnhancedInputClickAction;
	///<summary>EnhancedInputBackAction</summary>
	public UInputAction EnhancedInputBackAction;
}
