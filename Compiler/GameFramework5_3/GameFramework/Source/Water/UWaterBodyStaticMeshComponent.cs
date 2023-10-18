namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>WaterBodyMeshComponent used to when rendering water statically without relying on the dynamic tessellation of the water zone/water mesh.</summary>
[CppInclude("WaterBodyStaticMeshComponent.h")]
public partial class UWaterBodyStaticMeshComponent : UWaterBodyMeshComponent {
	public static UClass StaticClass() {return default;}
}
