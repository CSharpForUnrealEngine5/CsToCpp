#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataChannelAccessor.h")]
public partial class UNiagaraDataChannelWriter : UObject {
// NiagaraDataChannelWriter
	public UNiagaraDataChannelHandler Owner;
	public bool InitWrite(UObject OwningComponent,int Count,bool bVisibleToGame/*=true*/,bool bVisibleToCPU/*=true*/,bool bVisibleToGPU/*=true*/) { return default; }
	public int Num() { return default; }
	public void WriteFloat(string VarName,int Index,double InData) {}
	public void WriteVector2D(string VarName,int Index,FVector2D InData) {}
	public void WriteVector(string VarName,int Index,FVector InData) {}
	public void WriteVector4(string VarName,int Index,FVector4 InData) {}
	public void WriteQuat(string VarName,int Index,FQuat InData) {}
	public void WriteLinearColor(string VarName,int Index,FLinearColor InData) {}
	public void WriteInt(string VarName,int Index,int InData) {}
	public void WriteBool(string VarName,int Index,bool InData) {}
	public void WriteSpawnInfo(string VarName,int Index,FNiagaraSpawnInfo InData) {}
}
