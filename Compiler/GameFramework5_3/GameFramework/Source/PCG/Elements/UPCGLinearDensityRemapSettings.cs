namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGDensityRemap.h")]
public partial class UPCGLinearDensityRemapSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>RemapMin</summary>
	public float RemapMin;
	///<summary>RemapMax</summary>
	public float RemapMax;
	///<summary>bMultiplyDensity</summary>
	public bool bMultiplyDensity;
}
