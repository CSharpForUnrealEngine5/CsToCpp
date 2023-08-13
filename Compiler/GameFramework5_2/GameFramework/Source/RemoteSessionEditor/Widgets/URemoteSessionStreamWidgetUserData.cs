namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>URemoteSessionStreamWidgetUserData</summary>
[CppInclude("Widgets/SRemoteSessionStream.h")]
public partial class URemoteSessionStreamWidgetUserData : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>WidgetClass</summary>
	public UClass WidgetClass;
	///<summary>Size</summary>
	public FVector2D Size;
	///<summary>RenderTarget</summary>
	public UTextureRenderTarget2D RenderTarget;
	///<summary>Port</summary>
	public short Port;
}
