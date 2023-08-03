#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Color Correction Window that functions the same way as Color Correction Regions except it modifies anything that is behind it.</summary>
[CppInclude("ColorCorrectWindow.h")]
public partial class AColorCorrectionWindow : AColorCorrectRegion {
	public static UClass StaticClass() {return default;}
	///<summary>MeshComponents</summary>
	public TArray<UStaticMeshComponent> MeshComponents;
	///<summary>Region type.</summary>
	public EColorCorrectWindowType WindowType;
	///<summary>~Begin IDisplayClusterStageActor interface</summary>
	public  void SetLongitude(double InValue) {}
	///<summary>GetLongitude</summary>
	public  double GetLongitude() { return default; }
	///<summary>SetLatitude</summary>
	public  void SetLatitude(double InValue) {}
	///<summary>GetLatitude</summary>
	public  double GetLatitude() { return default; }
	///<summary>SetDistanceFromCenter</summary>
	public  void SetDistanceFromCenter(double InValue) {}
	///<summary>GetDistanceFromCenter</summary>
	public  double GetDistanceFromCenter() { return default; }
	///<summary>SetSpin</summary>
	public  void SetSpin(double InValue) {}
	///<summary>GetSpin</summary>
	public  double GetSpin() { return default; }
	///<summary>SetPitch</summary>
	public  void SetPitch(double InValue) {}
	///<summary>GetPitch</summary>
	public  double GetPitch() { return default; }
	///<summary>SetYaw</summary>
	public  void SetYaw(double InValue) {}
	///<summary>GetYaw</summary>
	public  double GetYaw() { return default; }
	///<summary>SetRadialOffset</summary>
	public  void SetRadialOffset(double InValue) {}
	///<summary>GetRadialOffset</summary>
	public  double GetRadialOffset() { return default; }
	///<summary>SetScale</summary>
	public  void SetScale(FVector2D InScale) {}
	///<summary>GetScale</summary>
	public  FVector2D GetScale() { return default; }
	///<summary>SetOrigin</summary>
	public  void SetOrigin(FTransform InOrigin) {}
	///<summary>GetOrigin</summary>
	public  FTransform GetOrigin() { return default; }
	///<summary>SetPositionalParams</summary>
	public  void SetPositionalParams(FDisplayClusterPositionalParams InParams) {}
	///<summary>GetPositionalParams</summary>
	public  FDisplayClusterPositionalParams GetPositionalParams() { return default; }
	///<summary>PositionalParams</summary>
	public FDisplayClusterPositionalParams PositionalParams;
	///<summary>Origin</summary>
	public FTransform Origin;
}
