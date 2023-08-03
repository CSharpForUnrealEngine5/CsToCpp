#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EQSTestingPawn.h")]
public partial class AEQSTestingPawn : ACharacter {
	public static UClass StaticClass() {return default;}
	///<summary>QueryTemplate</summary>
	public UEnvQuery QueryTemplate;
	///<summary>QueryParams</summary>
	public TArray<FEnvNamedValue> QueryParams;
	///<summary>QueryConfig</summary>
	public TArray<FAIDynamicParam> QueryConfig;
	///<summary>TimeLimitPerStep</summary>
	public float TimeLimitPerStep;
	///<summary>StepToDebugDraw</summary>
	public int StepToDebugDraw;
	///<summary>HighlightMode</summary>
	public EEnvQueryHightlightMode HighlightMode;
	///<summary>bDrawLabels</summary>
	public bool bDrawLabels;
	///<summary>bDrawFailedItems</summary>
	public bool bDrawFailedItems;
	///<summary>bReRunQueryOnlyOnFinishedMove</summary>
	public bool bReRunQueryOnlyOnFinishedMove;
	///<summary>bShouldBeVisibleInGame</summary>
	public bool bShouldBeVisibleInGame;
	///<summary>bTickDuringGame</summary>
	public bool bTickDuringGame;
	///<summary>QueryingMode</summary>
	public EEnvQueryRunMode QueryingMode;
	///<summary>NavAgentProperties</summary>
	public FNavAgentProperties NavAgentProperties;
	///<summary>Editor Preview</summary>
	public UEQSRenderingComponent EdRenderComp;
}
