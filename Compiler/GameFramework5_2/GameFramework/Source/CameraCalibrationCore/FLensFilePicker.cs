#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper to facilitate default LensFile vs picker</summary>
[CppInclude("LensFile.h")]
public partial struct FLensFilePicker {
	public bool bUseDefaultLensFile;
	public ULensFile LensFile;
}
