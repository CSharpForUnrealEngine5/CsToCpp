#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FieldSystemComponent</summary>
[CppInclude("Field/FieldSystemComponent.h")]
public partial class UFieldSystemComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Field system asset to be used to store the construction fields. This asset is not required anymore and will be deprecated soon.</summary>
	public UFieldSystem FieldSystem;
	///<summary>If enabled the field will be pushed to the world fields and will be available to materials and niagara</summary>
	public bool bIsWorldField;
	///<summary>If enabled the field will be used by all the chaos solvers</summary>
	public bool bIsChaosField;
	///<summary>List of chaos solvers that will use the field</summary>
	public TArray<TSoftObjectPtr<AChaosSolverActor>> SupportedSolvers;
	///<summary>List of all the construction command</summary>
	public FFieldObjectCommands ConstructionCommands;
	///<summary>List of all the buffer command</summary>
	public FFieldObjectCommands BufferCommands;
	///<summary>ApplyUniformForce</summary>
	public  void ApplyLinearForce(bool Enabled,FVector Direction,float Magnitude) {}
	///<summary>SetDynamicState</summary>
	public  void ApplyStayDynamicField(bool Enabled,FVector Position,float Radius) {}
	///<summary>ApplyRadialForce</summary>
	public  void ApplyRadialForce(bool Enabled,FVector Position,float Magnitude) {}
	///<summary>FalloffRadialForce</summary>
	public  void ApplyRadialVectorFalloffForce(bool Enabled,FVector Position,float Radius,float Magnitude) {}
	///<summary>FalloffUniformForce</summary>
	public  void ApplyUniformVectorFalloffForce(bool Enabled,FVector Position,FVector Direction,float Radius,float Magnitude) {}
	///<summary>ApplyExternalStran</summary>
	public  void ApplyStrainField(bool Enabled,FVector Position,float Radius,float Magnitude,int Iterations) {}
	///<summary>AddTransientField</summary>
	public  void ApplyPhysicsField(bool Enabled,EFieldPhysicsType Target,UFieldSystemMetaData MetaData,UFieldNodeBase Field) {}
	///<summary>AddPersistentField</summary>
	public  void AddPersistentField(bool Enabled,EFieldPhysicsType Target,UFieldSystemMetaData MetaData,UFieldNodeBase Field) {}
	///<summary>RemovePersistentFields</summary>
	public  void RemovePersistentFields() {}
	///<summary>AddConstructionField</summary>
	public  void AddFieldCommand(bool Enabled,EFieldPhysicsType Target,UFieldSystemMetaData MetaData,UFieldNodeBase Field) {}
	///<summary>RemoveConstructionFields</summary>
	public  void ResetFieldSystem() {}
}
