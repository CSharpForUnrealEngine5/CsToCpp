#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Generic structure for returning most any kind of data from C++ to delegate functions</summary>
[CppInclude("Engine/PlatformInterfaceBase.h")]
public partial struct FPlatformInterfaceDelegateResult {
	public bool bSuccessful;
	public FPlatformInterfaceData Data;
}
