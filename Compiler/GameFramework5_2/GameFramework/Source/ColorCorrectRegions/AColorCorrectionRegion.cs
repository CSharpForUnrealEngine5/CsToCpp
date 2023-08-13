namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A placeable Color Correction Regions actor that replaces previous implementation (blueprint).</summary>
[CppInclude("ColorCorrectRegion.h")]
public partial class AColorCorrectionRegion : AColorCorrectRegion {
	public static UClass StaticClass() {return default;}
	///<summary>MeshComponents</summary>
	public TArray<UStaticMeshComponent> MeshComponents;
}
