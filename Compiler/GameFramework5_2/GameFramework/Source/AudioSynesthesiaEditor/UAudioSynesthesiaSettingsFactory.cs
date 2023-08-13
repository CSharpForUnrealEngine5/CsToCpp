namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAudioSynesthesiaSettingsFactory</summary>
[CppInclude("AudioSynesthesiaSettingsFactory.h")]
public partial class UAudioSynesthesiaSettingsFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The type of audio analyzer settings that will be created</summary>
	public UClass AudioSynesthesiaSettingsClass;
}
