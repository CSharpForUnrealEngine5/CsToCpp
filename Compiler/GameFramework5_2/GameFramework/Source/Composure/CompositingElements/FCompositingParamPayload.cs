namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FCompositingParamPayload</summary>
[CppInclude("CompositingElements/CompositingMaterialPass.h")]
public partial struct FCompositingParamPayload {
	public TMap<string,float> ScalarParamOverrides;
	public TMap<string,FLinearColor> VectorParamOverrides;
	public TMap<string,UTexture> TextureParamOverrides;
}
