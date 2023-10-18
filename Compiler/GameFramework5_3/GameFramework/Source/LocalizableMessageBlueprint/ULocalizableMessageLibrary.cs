namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>BlueprintFunctionLibrary for LocalizableMessage</summary>
[CppInclude("LocalizableMessageLibrary.h")]
public partial class ULocalizableMessageLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Conversion function from LocalizableMessage to FText.</summary>
	public static FText Conv_LocalizableMessageToText(UObject WorldContextObject,FLocalizableMessage Message) { return default; }
	///<summary>Returns true if the message is empty</summary>
	public static bool IsEmpty_LocalizableMessage(FLocalizableMessage Message) { return default; }
	///<summary>Resets the Localizable Message</summary>
	public static void Reset_LocalizableMessage(FLocalizableMessage Message) {}
}
