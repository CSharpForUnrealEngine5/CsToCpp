#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPBookmarkEditorBlueprintLibrary.h")]
public partial class UVPBookmarkEditorBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>JumpToBookmarkInLevelEditor</summary>
	public static bool JumpToBookmarkInLevelEditor(UVPBookmark Bookmark) { return default; }
	///<summary>JumpToBookmarkInLevelEditorByIndex</summary>
	public static bool JumpToBookmarkInLevelEditorByIndex(int BookmarkIndex) { return default; }
	///<summary>AddBookmarkAtCurrentLevelEditorPosition</summary>
	public static AActor AddBookmarkAtCurrentLevelEditorPosition(UClass ActorClass,FVPBookmarkCreationContext CreationContext,FVector Offset,bool bFlattenRotation/*=true*/) { return default; }
	///<summary>GetAllActorsClassThamImplementsVPBookmarkInterface</summary>
	public static void GetAllActorsClassThamImplementsVPBookmarkInterface(TArray<UClass> OutActorClasses) {}
}
