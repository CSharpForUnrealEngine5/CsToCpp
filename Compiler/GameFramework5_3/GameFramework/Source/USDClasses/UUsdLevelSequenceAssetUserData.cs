namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>We assign these to persistent LevelSequences that bind to one of the actors/components that the stage actor spawns.</summary>
[CppInclude("USDAssetUserData.h")]
public partial class UUsdLevelSequenceAssetUserData : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>The LevelSequence has a Guid that is changed every time its state is modified.</summary>
	public FGuid LastCheckedSignature;
	///<summary>Set of binding GUIDs that we already handled in the past.</summary>
	public TSet<FGuid> HandledBindingGuids;
}
