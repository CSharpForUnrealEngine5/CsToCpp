namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TextureShare plugin settings</summary>
[CppInclude("Game/Settings/TextureShareSettings.h")]
public partial class UTextureShareSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Enable base textureshare object creation by default</summary>
	public bool bCreateDefaults;
	///<summary>Process name for this app</summary>
	public string ProcessName;
}
