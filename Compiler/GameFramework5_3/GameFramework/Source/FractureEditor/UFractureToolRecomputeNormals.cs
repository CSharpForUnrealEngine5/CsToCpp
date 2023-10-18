namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Note this tool doesn&#39;t actually fracture, but it does remake pieces of geometry and shares a lot of machinery with the fracture tools</summary>
[CppInclude("FractureToolRecomputeNormals.h")]
public partial class UFractureToolRecomputeNormals : UFractureToolCutterBase {
	public static UClass StaticClass() {return default;}
	///<summary>NormalsSettings</summary>
	public UFractureRecomputeNormalsSettings NormalsSettings;
}
