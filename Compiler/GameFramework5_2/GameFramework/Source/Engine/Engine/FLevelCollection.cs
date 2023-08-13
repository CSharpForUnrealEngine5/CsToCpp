namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains a group of levels of a particular ELevelCollectionType within a UWorld</summary>
[CppInclude("Engine/World.h")]
public partial struct FLevelCollection {
	public AGameStateBase GameState;
	public UNetDriver NetDriver;
	public UDemoNetDriver DemoNetDriver;
	public ULevel PersistentLevel;
	public TSet<ULevel> Levels;
}
