#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Structure for arbitrarily oriented boxes (i.e. not necessarily axis-aligned).</summary>
public partial struct FOrientedBox {
// OrientedBox
	public FVector Center;
	public FVector AxisX;
	public FVector AxisY;
	public FVector AxisZ;
	public double ExtentX;
	public double ExtentY;
	public double ExtentZ;
}
