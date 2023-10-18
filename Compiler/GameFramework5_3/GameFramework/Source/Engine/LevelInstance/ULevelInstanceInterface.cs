namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelInstance/LevelInstanceInterface.h")]
public partial class ULevelInstanceInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>GetWorldAsset</summary>
	public virtual TSoftObjectPtr<UWorld> GetWorldAsset() { return default; }
	///<summary>SetWorldAsset</summary>
	public virtual bool SetWorldAsset(TSoftObjectPtr<UWorld> WorldAsset) { return default; }
	///<summary>IsLoaded</summary>
	public virtual bool IsLoaded() { return default; }
	///<summary>LoadLevelInstance</summary>
	public virtual void LoadLevelInstance() {}
	///<summary>UnloadLevelInstance</summary>
	public virtual void UnloadLevelInstance() {}
	///<summary>GetLoadedLevel</summary>
	public virtual ULevel GetLoadedLevel() { return default; }
}
