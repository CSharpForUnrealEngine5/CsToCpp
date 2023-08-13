namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/DialogueVoice.h")]
public partial class UDialogueVoice : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Gender</summary>
	public EGrammaticalGender Gender;
	///<summary>Plurality</summary>
	public EGrammaticalNumber Plurality;
	///<summary>LocalizationGUID</summary>
	public FGuid LocalizationGUID;
}
