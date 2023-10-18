namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraTypes.h")]
public partial struct FNiagaraInputParameterCustomization {
	public ENiagaraInputWidgetType WidgetType;
	public bool bHasMinValue;
	public float MinValue;
	public bool bHasMaxValue;
	public float MaxValue;
	public bool bHasStepWidth;
	public float StepWidth;
	public TArray<FWidgetNamedInputValue> InputDropdownValues;
	public TArray<FNiagaraWidgetNamedIntegerInputValue> EnumStyleDropdownValues;
	public bool bBroadcastValueChangesOnCommitOnly;
}
