namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGSelectPoints.h")]
public partial class UPCGSelectPointsSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Ratio</summary>
	public float Ratio;
	///<summary>bKeepZeroDensityPoints</summary>
	public bool bKeepZeroDensityPoints;
}
