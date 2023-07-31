#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A throbber widget that orients images in a spinning circle.</summary>
[CppInclude("Components/CircularThrobber.h")]
public partial class UCircularThrobber : UWidget {
	///<summary>How many pieces there are</summary>
	public int NumberOfPieces;
	///<summary>The amount of time for a full circle (in seconds)</summary>
	public float Period;
	///<summary>The radius of the circle. If the throbber is a child of Canvas Panel, the &#39;Size to Content&#39; option must be enabled in order to set Radius.</summary>
	public float Radius;
	///<summary>The throbber image.</summary>
	public FSlateBrush Image;
	///<summary>Sets how many pieces there are.</summary>
	public  void SetNumberOfPieces(int InNumberOfPieces) {}
	///<summary>Sets the amount of time for a full circle (in seconds).</summary>
	public  void SetPeriod(float InPeriod) {}
	///<summary>Sets the radius of the circle.</summary>
	public  void SetRadius(float InRadius) {}
	///<summary>bEnableRadius</summary>
	public bool bEnableRadius;
}
