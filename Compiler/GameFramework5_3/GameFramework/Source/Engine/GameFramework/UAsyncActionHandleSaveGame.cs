namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Async action to handle async load/save of a USaveGame. This can be subclassed by a specific game</summary>
[CppInclude("GameFramework/AsyncActionHandleSaveGame.h")]
public partial class UAsyncActionHandleSaveGame : UBlueprintAsyncActionBase {
	public static UClass StaticClass() {return default;}
	///<summary>Schedule an async save to a specific slot. UGameplayStatics::AsyncSaveGameToSlot is the native version of this.</summary>
	public static UAsyncActionHandleSaveGame AsyncSaveGameToSlot(UObject WorldContextObject,USaveGame SaveGameObject,string SlotName,int UserIndex) { return default; }
	///<summary>Schedule an async load of a specific slot. UGameplayStatics::AsyncLoadGameFromSlot is the native version of this.</summary>
	public static UAsyncActionHandleSaveGame AsyncLoadGameFromSlot(UObject WorldContextObject,string SlotName,int UserIndex) { return default; }
	///<summary>Delegate called when the save/load completes</summary>
	public FOnAsyncHandleSaveGame Completed;
	///<summary>The object that was either saved or loaded</summary>
	public USaveGame SaveGameObject;
}
