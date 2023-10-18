namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocalizableMessage.h")]
public partial struct FLocalizableMessage {
	public string Key;
	public string DefaultText;
	public TArray<FLocalizableMessageParameterEntry> Substitutions;
}
