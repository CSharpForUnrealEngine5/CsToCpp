namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects data from either input pin, based on a boolean condition.</summary>
[CppInclude("Elements/PCGBooleanSelect.h")]
public partial class UPCGBooleanSelectSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>bUseInputB</summary>
	public bool bUseInputB;
}
