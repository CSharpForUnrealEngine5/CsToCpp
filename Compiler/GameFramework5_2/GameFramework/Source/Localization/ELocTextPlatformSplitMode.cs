#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocTextHelper.h")]
///<summary>How should we split platform specific localization data?</summary>
public enum ELocTextPlatformSplitMode {
	None=0,
	Confidential=1,
	All=2,
}
