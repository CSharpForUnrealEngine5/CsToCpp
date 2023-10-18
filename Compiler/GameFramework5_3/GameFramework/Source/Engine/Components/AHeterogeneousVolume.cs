namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A placeable actor that represents a heterogeneous volume.</summary>
[CppInclude("Components/HeterogeneousVolumeComponent.h")]
public partial class AHeterogeneousVolume : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>HeterogeneousVolumeComponent</summary>
	public UHeterogeneousVolumeComponent HeterogeneousVolumeComponent;
}
