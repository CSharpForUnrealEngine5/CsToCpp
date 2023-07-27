#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/CircularThrobber.h")]
///<summary>A throbber widget that orients images in a spinning circle.</summary>
public partial class UCircularThrobber : UWidget {
// CircularThrobber
	public int NumberOfPieces;
	public float Period;
	public float Radius;
	public FSlateBrush Image;
	public  void SetNumberOfPieces(int InNumberOfPieces) {}
	public  void SetPeriod(float InPeriod) {}
	public  void SetRadius(float InRadius) {}
	public bool bEnableRadius;
}
