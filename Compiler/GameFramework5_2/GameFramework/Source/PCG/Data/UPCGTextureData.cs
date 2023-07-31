#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGTextureData.h")]
public partial class UPCGTextureData : UPCGBaseTextureData {
	///<summary>~End UPCGData interface</summary>
	public  void Initialize(UTexture2D InTexture,FTransform InTransform) {}
	///<summary>Texture</summary>
	public TWeakObjectPtr<UTexture2D> Texture;
}
