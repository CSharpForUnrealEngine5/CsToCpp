namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolCutter.h")]
public partial class UFractureToolVoronoiCutterBase : UFractureToolCutterBase {
	public static UClass StaticClass() {return default;}
	///<summary>VoronoiLineSets</summary>
	public TArray<ULineSetComponent> VoronoiLineSets;
}
