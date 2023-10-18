namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Lightmass/LightmassPortal.h")]
public partial class ALightmassPortal : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>PortalComponent</summary>
	public ULightmassPortalComponent PortalComponent;
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
}
