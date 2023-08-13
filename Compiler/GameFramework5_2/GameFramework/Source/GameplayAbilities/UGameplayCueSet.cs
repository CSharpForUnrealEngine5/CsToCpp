namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A set of gameplay cue actors to handle gameplay cue events</summary>
[CppInclude("GameplayCueSet.h")]
public partial class UGameplayCueSet : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>GameplayCueData</summary>
	public TArray<FGameplayCueNotifyData> GameplayCueData;
}
