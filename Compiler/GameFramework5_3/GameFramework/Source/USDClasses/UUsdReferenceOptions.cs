namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Options to display when adding a reference or a payload for a prim</summary>
[CppInclude("USDReferenceOptions.h")]
public partial class UUsdReferenceOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>When enabled, the reference/payload will target a prim on this stage</summary>
	public bool bInternalReference;
	///<summary>File to use as the reference</summary>
	public FFilePath TargetFile;
	///<summary>Use the default prim of the target stage as the referenced/payload prim</summary>
	public bool bUseDefaultPrim;
	///<summary>Use a specific prim of the target stage as the referenced/payload prim</summary>
	public string TargetPrimPath;
	///<summary>Offset to apply to the referenced/payload prim&#39;s time sampled attributes</summary>
	public float TimeCodeOffset;
	///<summary>TimeCode scaling factor to apply to the referenced/payload prim&#39;s time sampled attributes</summary>
	public float TimeCodeScale;
}
