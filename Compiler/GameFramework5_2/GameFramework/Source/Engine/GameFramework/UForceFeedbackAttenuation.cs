namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper class that can be created as an asset for force feedback attenuation properties which allows reuse</summary>
[CppInclude("GameFramework/ForceFeedbackAttenuation.h")]
public partial class UForceFeedbackAttenuation : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Attenuation</summary>
	public FForceFeedbackAttenuationSettings Attenuation;
}
