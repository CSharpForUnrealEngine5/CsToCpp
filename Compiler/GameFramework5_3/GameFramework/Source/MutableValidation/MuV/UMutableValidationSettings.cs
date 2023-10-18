namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuV/MutableValidationSettings.h")]
public partial class UMutableValidationSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If true, validation of referenced COs from asset subject to data validation, will be run.</summary>
	public bool bEnableIndirectValidation;
}
