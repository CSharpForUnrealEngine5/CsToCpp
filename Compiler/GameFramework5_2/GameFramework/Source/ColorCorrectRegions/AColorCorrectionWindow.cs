#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ColorCorrectWindow.h")]
///<summary>A Color Correction Window that functions the same way as Color Correction Regions except it modifies anything that is behind it.</summary>
public partial class AColorCorrectionWindow : AColorCorrectRegion {
// ColorCorrectionWindow
	public TArray<UStaticMeshComponent> MeshComponents;
	public EColorCorrectWindowType WindowType;
	public  void SetLongitude(double InValue) {}
	public  double GetLongitude() { return default; }
	public  void SetLatitude(double InValue) {}
	public  double GetLatitude() { return default; }
	public  void SetDistanceFromCenter(double InValue) {}
	public  double GetDistanceFromCenter() { return default; }
	public  void SetSpin(double InValue) {}
	public  double GetSpin() { return default; }
	public  void SetPitch(double InValue) {}
	public  double GetPitch() { return default; }
	public  void SetYaw(double InValue) {}
	public  double GetYaw() { return default; }
	public  void SetRadialOffset(double InValue) {}
	public  double GetRadialOffset() { return default; }
	public  void SetScale(FVector2D InScale) {}
	public  FVector2D GetScale() { return default; }
	public  void SetOrigin(FTransform InOrigin) {}
	public  FTransform GetOrigin() { return default; }
	public  void SetPositionalParams(FDisplayClusterPositionalParams InParams) {}
	public  FDisplayClusterPositionalParams GetPositionalParams() { return default; }
	public FDisplayClusterPositionalParams PositionalParams;
	public FTransform Origin;
}
