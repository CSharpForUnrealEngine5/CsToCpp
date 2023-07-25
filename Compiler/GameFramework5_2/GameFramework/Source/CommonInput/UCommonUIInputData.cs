#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonInputBaseTypes.h")]
///<summary>Derive from this class to store the Input data. It is referenced in the Common Input Settings, found in the project settings UI.</summary>
public partial class UCommonUIInputData : UObject {
// CommonUIInputData
	public FDataTableRowHandle DefaultClickAction;
	public FDataTableRowHandle DefaultBackAction;
	public UInputAction EnhancedInputClickAction;
	public UInputAction EnhancedInputBackAction;
}
