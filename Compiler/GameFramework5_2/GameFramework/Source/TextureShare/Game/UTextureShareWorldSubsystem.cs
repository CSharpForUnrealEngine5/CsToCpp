#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tickable TextureShare World Subsystem used to handle tick and react to level and world changes.</summary>
[CppInclude("Game/WorldSubsystem/TextureShareWorldSubsystem.h")]
public partial class UTextureShareWorldSubsystem : UTickableWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Get textureshare API UObject</summary>
	public  UTextureShare GetTextureShare() { return default; }
	///<summary>This UObject implements configuration and API</summary>
	public UTextureShare TextureShare;
}
