#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MSSettings.h")]
public partial class UMaterialPresetsSettings : UObject {
	///<summary>Replace default master material with your own custom master material for all 3D assets. Default material is used if field is left empty.</summary>
	public TLazyObjectPtr<UMaterial> MasterMaterial3d;
	///<summary>Replace default master material with your own custom master material for all Surfaces. Default material is used if field is left empty.</summary>
	public TLazyObjectPtr<UMaterial> MasterMaterialSurface;
	///<summary>Replace default master material with your own custom master material for all 3D Plants. Default material is used if field is left empty.</summary>
	public TLazyObjectPtr<UMaterial> MasterMaterialPlant;
}
