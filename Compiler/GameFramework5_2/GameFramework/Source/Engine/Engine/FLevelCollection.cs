#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/World.h")]
///<summary>Contains a group of levels of a particular ELevelCollectionType within a UWorld</summary>
public partial struct FLevelCollection {
// LevelCollection
	public AGameStateBase GameState;
	public UNetDriver NetDriver;
	public UDemoNetDriver DemoNetDriver;
	public ULevel PersistentLevel;
	public TSet<ULevel> Levels;
}
