namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base Option Struct which holds an object, its orientation and scale</summary>
[CppInclude("WaveFunctionCollapseModel.h")]
public partial struct FWaveFunctionCollapseOption {
	public FSoftObjectPath BaseObject;
	public FRotator BaseRotator;
	public FVector BaseScale3D;
}
