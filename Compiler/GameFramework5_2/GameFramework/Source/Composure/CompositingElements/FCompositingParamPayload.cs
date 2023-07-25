#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingElements/CompositingMaterialPass.h")]
///<summary>FCompositingParamPayload</summary>
public partial struct FCompositingParamPayload {
// CompositingParamPayload
	public TMap<string,float> ScalarParamOverrides;
	public TMap<string,FLinearColor> VectorParamOverrides;
	public TMap<string,UTexture> TextureParamOverrides;
}
