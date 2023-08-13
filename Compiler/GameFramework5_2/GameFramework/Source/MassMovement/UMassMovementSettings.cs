namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassMovementSettings.h")]
public partial class UMassMovementSettings : UMassModuleSettings {
	public static UClass StaticClass() {return default;}
	///<summary>MovementStyles</summary>
	public TArray<FMassMovementStyle> MovementStyles;
}
