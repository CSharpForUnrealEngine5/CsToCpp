#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelInstance/LevelInstanceEditorObject.h")]
public partial class ULevelInstanceEditorObject : UObject {
	///<summary>If current Level edit has moved actors in/out of the level</summary>
	public bool bMovedActors;
	///<summary>List of packages to save when committing level</summary>
	public TArray<TWeakObjectPtr<UPackage>> OtherPackagesToSave;
}
