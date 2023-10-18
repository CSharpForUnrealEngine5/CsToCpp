namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Preferences/LightmassOptionsObject.h")]
public partial class ULightmassOptionsObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DebugSettings</summary>
	public FLightmassDebugOptions DebugSettings;
	///<summary>SwarmSettings</summary>
	public FSwarmDebugOptions SwarmSettings;
}
