namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A placeable actor that represents a participating media material around a planet, e.g. clouds.</summary>
[CppInclude("Components/VolumetricCloudComponent.h")]
public partial class AVolumetricCloud : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>VolumetricCloudComponent</summary>
	public UVolumetricCloudComponent VolumetricCloudComponent;
}
