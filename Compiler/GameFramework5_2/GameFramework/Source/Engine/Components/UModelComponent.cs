namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ModelComponents are PrimitiveComponents that represent elements of BSP geometry in a ULevel object.</summary>
[CppInclude("Components/ModelComponent.h")]
public partial class UModelComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Description of collision</summary>
	public UBodySetup ModelBodySetup;
}
