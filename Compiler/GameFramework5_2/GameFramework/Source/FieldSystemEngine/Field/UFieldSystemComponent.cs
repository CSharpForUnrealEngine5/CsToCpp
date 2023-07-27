#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Field/FieldSystemComponent.h")]
///<summary>FieldSystemComponent</summary>
public partial class UFieldSystemComponent : UPrimitiveComponent {
// FieldSystemComponent
	public UFieldSystem FieldSystem;
	public bool bIsWorldField;
	public bool bIsChaosField;
	public TArray<TSoftObjectPtr<AChaosSolverActor>> SupportedSolvers;
	public FFieldObjectCommands ConstructionCommands;
	public FFieldObjectCommands BufferCommands;
	public  void ApplyLinearForce(bool Enabled,FVector Direction,float Magnitude) {}
	public  void ApplyStayDynamicField(bool Enabled,FVector Position,float Radius) {}
	public  void ApplyRadialForce(bool Enabled,FVector Position,float Magnitude) {}
	public  void ApplyRadialVectorFalloffForce(bool Enabled,FVector Position,float Radius,float Magnitude) {}
	public  void ApplyUniformVectorFalloffForce(bool Enabled,FVector Position,FVector Direction,float Radius,float Magnitude) {}
	public  void ApplyStrainField(bool Enabled,FVector Position,float Radius,float Magnitude,int Iterations) {}
	public  void ApplyPhysicsField(bool Enabled,EFieldPhysicsType Target,UFieldSystemMetaData MetaData,UFieldNodeBase Field) {}
	public  void AddPersistentField(bool Enabled,EFieldPhysicsType Target,UFieldSystemMetaData MetaData,UFieldNodeBase Field) {}
	public  void RemovePersistentFields() {}
	public  void AddFieldCommand(bool Enabled,EFieldPhysicsType Target,UFieldSystemMetaData MetaData,UFieldNodeBase Field) {}
	public  void ResetFieldSystem() {}
}
