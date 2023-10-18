namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AISenseConfig.h")]
public partial class UAISenseConfig : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DebugColor</summary>
	public FColor DebugColor;
	///<summary>specifies age limit after stimuli generated by this sense become forgotten. 0 means &quot;never&quot;</summary>
	public float MaxAge;
	///<summary>determines whether given sense starts in an enabled state</summary>
	public bool bStartsEnabled;
}
