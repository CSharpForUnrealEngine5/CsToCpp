#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("USDReferenceOptions.h")]
///<summary>Options to display when adding a reference or a payload for a prim</summary>
public partial class UUsdReferenceOptions : UObject {
// UsdReferenceOptions
	public bool bInternalReference;
	public FFilePath TargetFile;
	public bool bUseDefaultPrim;
	public string TargetPrimPath;
	public float TimeCodeOffset;
	public float TimeCodeScale;
}
