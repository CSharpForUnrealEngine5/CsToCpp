namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper to facilitate default LensFile vs picker</summary>
[CppInclude("LensFile.h")]
public partial struct FLensFilePicker {
	public bool bUseDefaultLensFile;
	public ULensFile LensFile;
}
