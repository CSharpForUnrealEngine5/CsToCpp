#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBookmarkEditorBlueprintLibrary.h")]
public partial class UVPBookmarkEditorBlueprintLibrary : UBlueprintFunctionLibrary {
// VPBookmarkEditorBlueprintLibrary
	public bool JumpToBookmarkInLevelEditor(UObject Bookmark) { return default; }
	public bool JumpToBookmarkInLevelEditorByIndex(int BookmarkIndex) { return default; }
	public UObject AddBookmarkAtCurrentLevelEditorPosition(UClass ActorClass,FVPBookmarkCreationContext CreationContext,FVector Offset,bool bFlattenRotation/*=true*/) { return default; }
	public void GetAllActorsClassThamImplementsVPBookmarkInterface(TArray<UClass> OutActorClasses) {}
}
