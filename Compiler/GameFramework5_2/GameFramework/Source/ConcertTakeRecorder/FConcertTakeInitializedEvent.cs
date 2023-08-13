namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTakeRecorderMessages.h")]
public partial struct FConcertTakeInitializedEvent {
	public string TakePresetPath;
	public string TakeName;
	public TArray<byte> TakeData;
	public string TakeMetaDataPath;
	public FConcertLocalIdentifierState IdentifierState;
	public FTakeRecorderUserParameters Settings;
}
