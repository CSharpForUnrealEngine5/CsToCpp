#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EQSTestingPawn.h")]
public partial class AEQSTestingPawn : ACharacter {
// EQSTestingPawn
	public UEnvQuery QueryTemplate;
	public TArray<FEnvNamedValue> QueryParams;
	public TArray<FAIDynamicParam> QueryConfig;
	public float TimeLimitPerStep;
	public int StepToDebugDraw;
	public EEnvQueryHightlightMode HighlightMode;
	public bool bDrawLabels;
	public bool bDrawFailedItems;
	public bool bReRunQueryOnlyOnFinishedMove;
	public bool bShouldBeVisibleInGame;
	public bool bTickDuringGame;
	public EEnvQueryRunMode QueryingMode;
	public FNavAgentProperties NavAgentProperties;
	public UEQSRenderingComponent EdRenderComp;
}
