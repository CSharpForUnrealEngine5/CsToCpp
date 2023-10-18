namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGProjectionElement.h")]
public partial class UPCGProjectionSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>ProjectionParams</summary>
	public FPCGProjectionParams ProjectionParams;
	///<summary>bKeepZeroDensityPoints</summary>
	public bool bKeepZeroDensityPoints;
}
