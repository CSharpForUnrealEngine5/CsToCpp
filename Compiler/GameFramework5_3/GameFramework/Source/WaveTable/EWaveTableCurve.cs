namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveTableSettings.h")]
public enum EWaveTableCurve {
	Linear=0,
	Linear_Inv=1,
	Exp=2,
	Exp_Inverse=3,
	Log=4,
	Sin=5,
	Sin_Full=6,
	SCurve=7,
	Shared=8,
	Custom=9,
	File=10,
	Count=11,
}
