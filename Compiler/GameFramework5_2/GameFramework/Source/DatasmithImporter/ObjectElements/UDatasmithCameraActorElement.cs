#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* UDatasmithCameraActorElement</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithCameraActorElement : UDatasmithActorElement {
	public static UClass StaticClass() {return default;}
	///<summary>Get camera sensor width in millimeters</summary>
	public  float GetSensorWidth() { return default; }
	///<summary>Set camera sensor width in millimeters</summary>
	public  void SetSensorWidth(float SensorWidth) {}
	///<summary>Get framebuffer aspect ratio (width/height)</summary>
	public  float GetSensorAspectRatio() { return default; }
	///<summary>Set framebuffer aspect ratio (width/height)</summary>
	public  void SetSensorAspectRatio(float SensorAspectRatio) {}
	///<summary>Get camera focus distance in centimeters</summary>
	public  float GetFocusDistance() { return default; }
	///<summary>Set camera focus distance in centimeters</summary>
	public  void SetFocusDistance(float FocusDistance) {}
	///<summary>Get camera FStop also known as FNumber</summary>
	public  float GetFStop() { return default; }
	///<summary>Set camera FStop also known as FNumber</summary>
	public  void SetFStop(float FStop) {}
	///<summary>Get camera focal length in millimeters</summary>
	public  float GetFocalLength() { return default; }
	///<summary>Set camera focal length in millimeters</summary>
	public  void SetFocalLength(float FocalLength) {}
	///<summary>Get camera&#39;s postprocess</summary>
	public  UDatasmithPostProcessElement GetPostProcess() { return default; }
	///<summary>Get camera look at actor name</summary>
	public  string GetLookAtActor() { return default; }
	///<summary>Set camera look at actor name</summary>
	public  void SetLookAtActor(string ActorPathName) {}
	///<summary>Get camera look at allow roll state</summary>
	public  bool GetLookAtAllowRoll() { return default; }
	///<summary>Set camera look at allow roll state</summary>
	public  void SetLookAtAllowRoll(bool bAllow) {}
}
