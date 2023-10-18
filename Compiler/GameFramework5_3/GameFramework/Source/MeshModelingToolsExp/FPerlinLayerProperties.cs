namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Per-layer properties for Perlin noise. Each layer has independent Frequency and Intensity.</summary>
[CppInclude("DisplaceMeshTool.h")]
public partial struct FPerlinLayerProperties {
	public float Frequency;
	public float Intensity;
}
