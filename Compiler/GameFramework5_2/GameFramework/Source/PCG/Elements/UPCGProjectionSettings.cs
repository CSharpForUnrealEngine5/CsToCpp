#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
