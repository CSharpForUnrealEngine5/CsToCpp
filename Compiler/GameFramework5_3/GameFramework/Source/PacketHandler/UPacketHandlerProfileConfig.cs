namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PacketHandler Configuration Profiles based on each NetDriver</summary>
[CppInclude("PacketHandlerProfileConfig.h")]
public partial class UPacketHandlerProfileConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Components</summary>
	public TArray<string> Components;
}
