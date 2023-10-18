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
	public virtual void SetLongitude(double InValue) {}
	///<summary>GetLongitude</summary>
	public virtual double GetLongitude() { return default; }
	///<summary>SetLatitude</summary>
	public virtual void SetLatitude(double InValue) {}
	///<summary>GetLatitude</summary>
	public virtual double GetLatitude() { return default; }
	///<summary>SetDistanceFromCenter</summary>
	public virtual void SetDistanceFromCenter(double InValue) {}
	///<summary>GetDistanceFromCenter</summary>
	public virtual double GetDistanceFromCenter() { return default; }
	///<summary>SetSpin</summary>
	public virtual void SetSpin(double InValue) {}
	///<summary>GetSpin</summary>
	public virtual double GetSpin() { return default; }
	///<summary>SetPitch</summary>
	public virtual void SetPitch(double InValue) {}
	///<summary>GetPitch</summary>
	public virtual double GetPitch() { return default; }
	///<summary>SetYaw</summary>
	public virtual void SetYaw(double InValue) {}
	///<summary>GetYaw</summary>
	public virtual double GetYaw() { return default; }
	///<summary>SetRadialOffset</summary>
	public virtual void SetRadialOffset(double InValue) {}
	///<summary>GetRadialOffset</summary>
	public virtual double GetRadialOffset() { return default; }
	///<summary>SetScale</summary>
	public virtual void SetScale(FVector2D InScale) {}
	///<summary>GetScale</summary>
	public virtual FVector2D GetScale() { return default; }
	///<summary>SetOrigin</summary>
	public virtual void SetOrigin(FTransform InOrigin) {}
	///<summary>GetOrigin</summary>
	public virtual FTransform GetOrigin() { return default; }
	///<summary>SetPositionalParams</summary>
	public virtual void SetPositionalParams(FDisplayClusterPositionalParams InParams) {}
	///<summary>GetPositionalParams</summary>
	public virtual FDisplayClusterPositionalParams GetPositionalParams() { return default; }
	///<summary>PositionalParams</summary>
	public FDisplayClusterPositionalParams PositionalParams;
	///<summary>Origin</summary>
	public FTransform Origin;
}
