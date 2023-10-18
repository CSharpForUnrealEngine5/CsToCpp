namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothConfig.h")]
///<summary>Different mass modes deciding the setup process.</summary>
public enum EClothMassMode {
	UniformMass=0,
	TotalMass=1,
	Density=2,
	MaxClothMassMode=3,
}
