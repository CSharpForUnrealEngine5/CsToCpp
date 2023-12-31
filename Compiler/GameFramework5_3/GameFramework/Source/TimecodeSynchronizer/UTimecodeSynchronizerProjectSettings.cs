namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimecodeSynchronizerProjectSettings.h")]
public partial class UTimecodeSynchronizerProjectSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Display the timecode synchronizer icon in the editor toolbar.</summary>
	public bool bDisplayInToolbar;
	///<summary>DefaultTimecodeSynchronizer</summary>
	public TSoftObjectPtr<UTimecodeSynchronizer> DefaultTimecodeSynchronizer;
}
