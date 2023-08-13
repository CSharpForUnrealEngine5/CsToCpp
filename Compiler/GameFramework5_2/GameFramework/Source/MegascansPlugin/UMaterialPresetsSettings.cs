namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MSSettings.h")]
public partial class UMaterialPresetsSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Replace default master material with your own custom master material for all 3D assets. Default material is used if field is left empty.</summary>
	public TLazyObjectPtr<UMaterial> MasterMaterial3d;
	///<summary>Replace default master material with your own custom master material for all Surfaces. Default material is used if field is left empty.</summary>
	public TLazyObjectPtr<UMaterial> MasterMaterialSurface;
	///<summary>Replace default master material with your own custom master material for all 3D Plants. Default material is used if field is left empty.</summary>
	public TLazyObjectPtr<UMaterial> MasterMaterialPlant;
}
