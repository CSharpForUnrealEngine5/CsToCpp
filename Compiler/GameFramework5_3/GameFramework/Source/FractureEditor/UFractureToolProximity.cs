namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolProximity.h")]
public partial class UFractureToolProximity : UFractureModalTool {
	public static UClass StaticClass() {return default;}
	///<summary>ProximitySettings</summary>
	public UFractureProximitySettings ProximitySettings;
	///<summary>ProximityActions</summary>
	public UFractureProximityActions ProximityActions;
}
