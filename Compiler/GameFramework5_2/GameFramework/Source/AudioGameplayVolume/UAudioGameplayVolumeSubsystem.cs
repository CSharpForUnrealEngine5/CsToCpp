#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAudioGameplayVolumeSubsystem</summary>
[CppInclude("AudioGameplayVolumeSubsystem.h")]
public partial class UAudioGameplayVolumeSubsystem : UAudioEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>Components in our system</summary>
	public TMap<uint,UAudioGameplayVolumeComponent> AGVComponents;
}
