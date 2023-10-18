namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ULevelInstanceComponent subclasses USceneComponent for Editing purposes so that we can have a proxy to the LevelInstanceActor&#39;s RootComponent transform without attaching to it.</summary>
[CppInclude("LevelInstance/LevelInstanceComponent.h")]
public partial class ULevelInstanceComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Filter</summary>
	public FWorldPartitionActorFilter Filter;
	///<summary>EditFilter</summary>
	public FWorldPartitionActorFilter EditFilter;
}
