#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings specifically related to the one-time destructive fracturing of a mesh *</summary>
[CppInclude("FractureToolProperties.h")]
public partial class UFractureInitialDynamicStateSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Simulation state to be set on selected bones</summary>
	public EDynamicStateOverrideEnum InitialDynamicState;
}
