#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosCloth/ChaosClothingSimulationInteractor.h")]
public partial class UChaosClothingInteractor : UClothingInteractor {
	///<summary>SetMaterialLinear</summary>
	public  void SetMaterialLinear(float EdgeStiffness/*=1.0f*/,float BendingStiffness/*=1.0f*/,float AreaStiffness/*=1.0f*/) {}
	///<summary>SetMaterial</summary>
	public  void SetMaterial(FVector2D EdgeStiffness/*=new FVector2D(1.0f,1.0f)*/,FVector2D BendingStiffness/*=new FVector2D(1.0f,1.0f)*/,FVector2D AreaStiffness/*=new FVector2D(1.0f,1.0f)*/) {}
	///<summary>SetLongRangeAttachmentLinear</summary>
	public  void SetLongRangeAttachmentLinear(float TetherStiffness/*=1.0f*/,float TetherScale/*=1.0f*/) {}
	///<summary>SetLongRangeAttachment</summary>
	public  void SetLongRangeAttachment(FVector2D TetherStiffness/*=new FVector2D(1.0f,1.0f)*/,FVector2D TetherScale/*=new FVector2D(1.0f,1.0f)*/) {}
	///<summary>SetCollision</summary>
	public  void SetCollision(float CollisionThickness/*=1.0f*/,float FrictionCoefficient/*=0.8f*/,bool bUseCCD/*=false*/,float SelfCollisionThickness/*=2.0f*/) {}
	///<summary>SetBackstop</summary>
	public  void SetBackstop(bool bEnabled/*=true*/) {}
	///<summary>SetDamping</summary>
	public  void SetDamping(float DampingCoefficient/*=0.01f*/,float LocalDampingCoefficient/*=0.0f*/) {}
	///<summary>Deprecated. This function cannot set different Low and High values for the Drag and Lift weight maps. Use SetWind instead.</summary>
	public  void SetAerodynamics(float DragCoefficient/*=0.07f*/,float LiftCoefficient/*=0.035f*/,FVector WindVelocity/*=new FVector(0.0f,0.0f,0.0f)*/) {}
	///<summary>SetWind</summary>
	public  void SetWind(FVector2D Drag/*=new FVector2D(0.07f,0.5f)*/,FVector2D Lift/*=new FVector2D(0.07f,0.5f)*/,float AirDensity/*=1.225e-6f*/,FVector WindVelocity/*=new FVector(0.0f,0.0f,0.0f)*/) {}
	///<summary>SetPressure</summary>
	public  void SetPressure(FVector2D Pressure/*=new FVector2D(0.0f,1.0f)*/) {}
	///<summary>SetGravity</summary>
	public  void SetGravity(float GravityScale/*=1.0f*/,bool bIsGravityOverridden/*=false*/,FVector GravityOverride/*=new FVector(0.0f,0.0f,-981.0f)*/) {}
	///<summary>SetAnimDriveLinear</summary>
	public  void SetAnimDriveLinear(float AnimDriveStiffness/*=0.0f*/) {}
	///<summary>SetAnimDrive</summary>
	public  void SetAnimDrive(FVector2D AnimDriveStiffness/*=new FVector2D(0.0f,1.0f)*/,FVector2D AnimDriveDamping/*=new FVector2D(0.0f,1.0f)*/) {}
	///<summary>SetVelocityScale</summary>
	public  void SetVelocityScale(FVector LinearVelocityScale/*=new FVector(0.75f,0.75f,0.75f)*/,float AngularVelocityScale/*=0.75f*/,float FictitiousAngularScale/*=1.0f*/) {}
	///<summary>ResetAndTeleport</summary>
	public  void ResetAndTeleport(bool bReset/*=false*/,bool bTeleport/*=false*/) {}
}
