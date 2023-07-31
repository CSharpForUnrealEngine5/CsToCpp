#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataChannelAccessor.h")]
public partial class UNiagaraDataChannelWriter : UObject {
	///<summary>Owner</summary>
	public UNiagaraDataChannelHandler Owner;
	///<summary>Call before each batch of writes to allocate the data we&#39;ll be writing to.</summary>
	public  bool InitWrite(UActorComponent OwningComponent,int Count,bool bVisibleToGame/*=true*/,bool bVisibleToCPU/*=true*/,bool bVisibleToGPU/*=true*/) { return default; }
	///<summary>Num</summary>
	public  int Num() { return default; }
	///<summary>WriteFloat</summary>
	public  void WriteFloat(string VarName,int Index,double InData) {}
	///<summary>WriteVector2D</summary>
	public  void WriteVector2D(string VarName,int Index,FVector2D InData) {}
	///<summary>WriteVector</summary>
	public  void WriteVector(string VarName,int Index,FVector InData) {}
	///<summary>WriteVector4</summary>
	public  void WriteVector4(string VarName,int Index,FVector4 InData) {}
	///<summary>WriteQuat</summary>
	public  void WriteQuat(string VarName,int Index,FQuat InData) {}
	///<summary>WriteLinearColor</summary>
	public  void WriteLinearColor(string VarName,int Index,FLinearColor InData) {}
	///<summary>WriteInt</summary>
	public  void WriteInt(string VarName,int Index,int InData) {}
	///<summary>WriteBool</summary>
	public  void WriteBool(string VarName,int Index,bool InData) {}
	///<summary>WriteSpawnInfo</summary>
	public  void WriteSpawnInfo(string VarName,int Index,FNiagaraSpawnInfo InData) {}
}
