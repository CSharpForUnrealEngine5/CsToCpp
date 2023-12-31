namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Can be hooked up to a UMeshOpPreviewWithBackgroundCompute to perform UV Transform operations.</summary>
[CppInclude("Operators/UVEditorUVTransformOp.h")]
public partial class UUVEditorUVTransformOperatorFactory : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UUVEditorUVTransformPropertiesBase Settings;
}
