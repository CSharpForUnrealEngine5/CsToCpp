namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGTextureData.h")]
public partial class UPCGTextureData : UPCGBaseTextureData {
	public static UClass StaticClass() {return default;}
	///<summary>~End UPCGData interface</summary>
	public void Initialize(UTexture2D InTexture,FTransform InTransform) {}
	///<summary>Texture</summary>
	public TWeakObjectPtr<UTexture2D> Texture;
}
