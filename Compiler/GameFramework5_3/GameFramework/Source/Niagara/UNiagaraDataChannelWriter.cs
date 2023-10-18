namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataChannelAccessor.h")]
public partial class UNiagaraDataChannelWriter : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Owner</summary>
	public UNiagaraDataChannelHandler Owner;
	///<summary>Call before each batch of writes to allocate the data we&#39;ll be writing to.</summary>
	public bool InitWrite(FNiagaraDataChannelSearchParameters SearchParams,int Count,bool bVisibleToGame/*=true*/,bool bVisibleToCPU/*=true*/,bool bVisibleToGPU/*=true*/) { return default; }
	///<summary>Num</summary>
	public int Num() { return default; }
	///<summary>WriteFloat</summary>
	public void WriteFloat(FName VarName,int Index,double InData) {}
	///<summary>WriteVector2D</summary>
	public void WriteVector2D(FName VarName,int Index,FVector2D InData) {}
	///<summary>WriteVector</summary>
	public void WriteVector(FName VarName,int Index,FVector InData) {}
	///<summary>WriteVector4</summary>
	public void WriteVector4(FName VarName,int Index,FVector4 InData) {}
	///<summary>WriteQuat</summary>
	public void WriteQuat(FName VarName,int Index,FQuat InData) {}
	///<summary>WriteLinearColor</summary>
	public void WriteLinearColor(FName VarName,int Index,FLinearColor InData) {}
	///<summary>WriteInt</summary>
	public void WriteInt(FName VarName,int Index,int InData) {}
	///<summary>WriteBool</summary>
	public void WriteBool(FName VarName,int Index,bool InData) {}
	///<summary>WriteSpawnInfo</summary>
	public void WriteSpawnInfo(FName VarName,int Index,FNiagaraSpawnInfo InData) {}
	///<summary>WritePosition</summary>
	public void WritePosition(FName VarName,int Index,FVector InData) {}
}
