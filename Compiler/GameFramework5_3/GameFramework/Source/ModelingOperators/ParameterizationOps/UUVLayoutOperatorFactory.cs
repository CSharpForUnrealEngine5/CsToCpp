namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Can be hooked up to a UMeshOpPreviewWithBackgroundCompute to perform UV Layout operations.</summary>
[CppInclude("ParameterizationOps/UVLayoutOp.h")]
public partial class UUVLayoutOperatorFactory : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UUVLayoutProperties Settings;
}
