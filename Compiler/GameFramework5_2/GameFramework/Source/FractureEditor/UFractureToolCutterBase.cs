namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolCutter.h")]
public partial class UFractureToolCutterBase : UFractureInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>CutterSettings</summary>
	public UFractureCutterSettings CutterSettings;
	///<summary>CollisionSettings</summary>
	public UFractureCollisionSettings CollisionSettings;
}
