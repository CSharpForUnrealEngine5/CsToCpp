namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure for arbitrarily oriented boxes (i.e. not necessarily axis-aligned).</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FOrientedBox {
	public FVector Center;
	public FVector AxisX;
	public FVector AxisY;
	public FVector AxisZ;
	public double ExtentX;
	public double ExtentY;
	public double ExtentZ;
}
