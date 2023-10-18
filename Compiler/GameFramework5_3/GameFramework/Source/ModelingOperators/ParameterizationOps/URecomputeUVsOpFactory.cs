namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Can be hooked up to a UMeshOpPreviewWithBackgroundCompute to perform UV solving operations.</summary>
[CppInclude("ParameterizationOps/RecomputeUVsOp.h")]
public partial class URecomputeUVsOpFactory : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public URecomputeUVsToolProperties Settings;
}
