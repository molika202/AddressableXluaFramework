//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class BattleEntity {

    public AITargetComponent aITarget { get { return (AITargetComponent)GetComponent(BattleComponentsLookup.AITarget); } }
    public bool hasAITarget { get { return HasComponent(BattleComponentsLookup.AITarget); } }

    public void AddAITarget(BattleEntity newTarget) {
        var index = BattleComponentsLookup.AITarget;
        var component = (AITargetComponent)CreateComponent(index, typeof(AITargetComponent));
        component.target = newTarget;
        AddComponent(index, component);
    }

    public void ReplaceAITarget(BattleEntity newTarget) {
        var index = BattleComponentsLookup.AITarget;
        var component = (AITargetComponent)CreateComponent(index, typeof(AITargetComponent));
        component.target = newTarget;
        ReplaceComponent(index, component);
    }

    public void RemoveAITarget() {
        RemoveComponent(BattleComponentsLookup.AITarget);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class BattleMatcher {

    static Entitas.IMatcher<BattleEntity> _matcherAITarget;

    public static Entitas.IMatcher<BattleEntity> AITarget {
        get {
            if (_matcherAITarget == null) {
                var matcher = (Entitas.Matcher<BattleEntity>)Entitas.Matcher<BattleEntity>.AllOf(BattleComponentsLookup.AITarget);
                matcher.componentNames = BattleComponentsLookup.componentNames;
                _matcherAITarget = matcher;
            }

            return _matcherAITarget;
        }
    }
}
