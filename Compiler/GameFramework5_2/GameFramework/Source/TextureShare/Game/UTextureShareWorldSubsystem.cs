#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Game/WorldSubsystem/TextureShareWorldSubsystem.h")]
///<summary>Tickable TextureShare World Subsystem used to handle tick and react to level and world changes.</summary>
public partial class UTextureShareWorldSubsystem : UTickableWorldSubsystem {
// TextureShareWorldSubsystem
	public UObject GetTextureShare() { return default; }
	public UTextureShare TextureShare;
}
