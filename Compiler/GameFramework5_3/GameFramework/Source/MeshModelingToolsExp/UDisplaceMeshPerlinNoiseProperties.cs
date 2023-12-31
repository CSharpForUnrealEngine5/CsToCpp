namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>PropertySet for properties affecting the Perlin Noise displacement type.</summary>
[CppInclude("DisplaceMeshTool.h")]
public partial class UDisplaceMeshPerlinNoiseProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>PerlinLayerProperties</summary>
	public TArray<FPerlinLayerProperties> PerlinLayerProperties;
}
