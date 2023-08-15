namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FCompositingParamPayload</summary>
[CppInclude("CompositingElements/CompositingMaterialPass.h")]
public partial struct FCompositingParamPayload {
	public TMap<FName,float> ScalarParamOverrides;
	public TMap<FName,FLinearColor> VectorParamOverrides;
	public TMap<FName,UTexture> TextureParamOverrides;
}
