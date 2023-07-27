#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataChannelAccessor.h")]
///<summary>Initial simple API for reading and writing data in a data channel from game code / BP.</summary>
public partial class UNiagaraDataChannelReader : UObject {
// NiagaraDataChannelReader
	public UNiagaraDataChannelHandler Owner;
	public  bool InitAccess(UActorComponent OwningComponent) { return default; }
	public  int Num() { return default; }
	public  double ReadFloat(string VarName,int Index) { return default; }
	public  FVector2D ReadVector2D(string VarName,int Index) { return default; }
	public  FVector ReadVector(string VarName,int Index) { return default; }
	public  FVector4 ReadVector4(string VarName,int Index) { return default; }
	public  FQuat ReadQuat(string VarName,int Index) { return default; }
	public  FLinearColor ReadLinearColor(string VarName,int Index) { return default; }
	public  int ReadInt(string VarName,int Index) { return default; }
	public  bool ReadBool(string VarName,int Index) { return default; }
}
