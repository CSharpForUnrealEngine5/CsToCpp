namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for meshes used to render water bodies without relying on the water zone/water mesh.</summary>
[CppInclude("WaterBodyMeshComponent.h")]
public partial class UWaterBodyMeshComponent : UStaticMeshComponent {
	public static UClass StaticClass() {return default;}
}
