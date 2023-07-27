#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCache.h")]
public partial class UNiagaraSimCache : UObject {
// NiagaraSimCache
	public  bool IsCacheValid() { return default; }
	public  bool IsEmpty() { return default; }
	public  ENiagaraSimCacheAttributeCaptureMode GetAttributeCaptureMode() { return default; }
	public  float GetStartSeconds() { return default; }
	public  int GetNumFrames() { return default; }
	public  int GetNumEmitters() { return default; }
	public  string GetEmitterName(int EmitterIndex) { return default; }
	public  TArray<string> GetEmitterNames() { return default; }
	public  void ReadIntAttribute(TArray<int> OutValues,string AttributeName,string EmitterName,int FrameIndex/*=0*/) {}
	public  void ReadFloatAttribute(TArray<float> OutValues,string AttributeName,string EmitterName,int FrameIndex/*=0*/) {}
	public  void ReadVector2Attribute(TArray<FVector2D> OutValues,string AttributeName,string EmitterName,int FrameIndex/*=0*/) {}
	public  void ReadVectorAttribute(TArray<FVector> OutValues,string AttributeName,string EmitterName,int FrameIndex/*=0*/) {}
	public  void ReadVector4Attribute(TArray<FVector4> OutValues,string AttributeName,string EmitterName,int FrameIndex/*=0*/) {}
	public  void ReadColorAttribute(TArray<FLinearColor> OutValues,string AttributeName/*=new FName("Color")*/,string EmitterName/*=NAME_None*/,int FrameIndex/*=0*/) {}
	public  void ReadPositionAttribute(TArray<FVector> OutValues,string AttributeName/*=new FName("Position")*/,string EmitterName/*=NAME_None*/,bool bLocalSpaceToWorld/*=true*/,int FrameIndex/*=0*/) {}
	public  void ReadPositionAttributeWithRebase(TArray<FVector> OutValues,FTransform Transform,string AttributeName/*=new FName("Position")*/,string EmitterName/*=NAME_None*/,int FrameIndex/*=0*/) {}
	public  void ReadQuatAttribute(TArray<FQuat> OutValues,string AttributeName/*=new FName("MeshOrientation")*/,string EmitterName/*=NAME_None*/,bool bLocalSpaceToWorld/*=true*/,int FrameIndex/*=0*/) {}
	public  void ReadQuatAttributeWithRebase(TArray<FQuat> OutValues,FQuat Quat,string AttributeName/*=new FName("MeshOrientation")*/,string EmitterName/*=NAME_None*/,int FrameIndex/*=0*/) {}
	public FGuid CacheGuid;
	public TSoftObjectPtr<UNiagaraSystem> SoftNiagaraSystem;
	public float StartSeconds;
	public float DurationSeconds;
	public FNiagaraSimCacheCreateParameters CreateParameters;
	public bool bNeedsReadComponentMappingRecache;
	public TArray<FNiagaraVMExecutableDataId> CachedScriptVMIds;
	public FNiagaraSimCacheLayout CacheLayout;
	public TArray<FNiagaraSimCacheFrame> CacheFrames;
	public TMap<FNiagaraVariableBase,UObject> DataInterfaceStorage;
}
