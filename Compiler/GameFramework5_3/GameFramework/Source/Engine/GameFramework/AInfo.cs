namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Info is the base class of an Actor that isn&#39;t meant to have a physical representation in the world, used primarily</summary>
[CppInclude("GameFramework/Info.h")]
public partial class AInfo : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Billboard Component displayed in editor</summary>
	public UBillboardComponent SpriteComponent;
}
