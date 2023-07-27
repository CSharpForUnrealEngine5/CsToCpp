#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBookmarkEditorBlueprintLibrary.h")]
public partial class UVPBookmarkEditorBlueprintLibrary : UBlueprintFunctionLibrary {
// VPBookmarkEditorBlueprintLibrary
	public static bool JumpToBookmarkInLevelEditor(UVPBookmark Bookmark) { return default; }
	public static bool JumpToBookmarkInLevelEditorByIndex(int BookmarkIndex) { return default; }
	public static AActor AddBookmarkAtCurrentLevelEditorPosition(UClass ActorClass,FVPBookmarkCreationContext CreationContext,FVector Offset,bool bFlattenRotation/*=true*/) { return default; }
	public static void GetAllActorsClassThamImplementsVPBookmarkInterface(TArray<UClass> OutActorClasses) {}
}
