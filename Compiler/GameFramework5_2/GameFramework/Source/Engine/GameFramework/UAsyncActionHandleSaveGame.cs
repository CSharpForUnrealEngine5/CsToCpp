#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/AsyncActionHandleSaveGame.h")]
///<summary>Async action to handle async load/save of a USaveGame. This can be subclassed by a specific game</summary>
public partial class UAsyncActionHandleSaveGame : UBlueprintAsyncActionBase {
// AsyncActionHandleSaveGame
	public static UAsyncActionHandleSaveGame AsyncSaveGameToSlot(UObject WorldContextObject,USaveGame SaveGameObject,string SlotName,int UserIndex) { return default; }
	public static UAsyncActionHandleSaveGame AsyncLoadGameFromSlot(UObject WorldContextObject,string SlotName,int UserIndex) { return default; }
	public FOnAsyncHandleSaveGame Completed;
	public USaveGame SaveGameObject;
}
