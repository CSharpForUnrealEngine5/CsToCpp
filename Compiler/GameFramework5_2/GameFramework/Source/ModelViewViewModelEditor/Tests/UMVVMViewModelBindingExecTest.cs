#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/MVVMBindingExecuteTest.h")]
public partial class UMVVMViewModelBindingExecTest : UObject {
// MVVMViewModelBindingExecTest
	public FMVVMBindingExecTextCounter PropertyA;
	public TArray<FMVVMBindingExecTextCounter> PropertyB;
	public int PropertyC;
	public TArray<int> PropertyD;
	public float PropertyFloat;
	public float PropertyFloatAccessor;
	public double PropertyDouble;
	public  FMVVMBindingExecTextCounter GetterA() { return default; }
	public  TArray<FMVVMBindingExecTextCounter> GetterB() { return default; }
	public  int GetterC() { return default; }
	public  TArray<int> GetterD() { return default; }
	public  float GetterFloat() { return default; }
	public  double GetterDouble() { return default; }
	public  void SetterA(FMVVMBindingExecTextCounter Value) {}
	public  void SetterB(TArray<FMVVMBindingExecTextCounter> Value) {}
	public  void SetterC(int Value) {}
	public  void SetterD(TArray<int> Value) {}
	public  void SetterFloat(float Value) {}
	public  void SetterDouble(double Value) {}
	public static int ConversionStructToInt(FMVVMBindingExecTextCounter Value) { return default; }
	public static int ConversionConstStructToInt(FMVVMBindingExecTextCounter Value) { return default; }
	public static TArray<int> ConversionArrayStructToArrayInt(TArray<FMVVMBindingExecTextCounter> Values) { return default; }
	public static FMVVMBindingExecTextCounter ConversionIntToStruct(int Value) { return default; }
	public static FMVVMBindingExecTextCounter ConversionConstIntToStruct(int Value) { return default; }
	public static TArray<FMVVMBindingExecTextCounter> ConversionArrayIntToArrayStruct(TArray<int> Values) { return default; }
	public static float ConversionIncFloat(float Value) { return default; }
	public static float ConversionIncDouble(double Value) { return default; }
}
