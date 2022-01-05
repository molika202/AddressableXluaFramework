//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class BattleEntity {

    public MoveTargetComponent moveTarget { get { return (MoveTargetComponent)GetComponent(BattleComponentsLookup.MoveTarget); } }
    public bool hasMoveTarget { get { return HasComponent(BattleComponentsLookup.MoveTarget); } }

    public void AddMoveTarget(UnityEngine.Vector3 newTarget) {
        var index = BattleComponentsLookup.MoveTarget;
        var component = (MoveTargetComponent)CreateComponent(index, typeof(MoveTargetComponent));
        component.target = newTarget;
        AddComponent(index, component);
    }

    public void ReplaceMoveTarget(UnityEngine.Vector3 newTarget) {
        var index = BattleComponentsLookup.MoveTarget;
        var component = (MoveTargetComponent)CreateComponent(index, typeof(MoveTargetComponent));
        component.target = newTarget;
        ReplaceComponent(index, component);
    }

    public void RemoveMoveTarget() {
        RemoveComponent(BattleComponentsLookup.MoveTarget);
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

    static Entitas.IMatcher<BattleEntity> _matcherMoveTarget;

    public static Entitas.IMatcher<BattleEntity> MoveTarget {
        get {
            if (_matcherMoveTarget == null) {
                var matcher = (Entitas.Matcher<BattleEntity>)Entitas.Matcher<BattleEntity>.AllOf(BattleComponentsLookup.MoveTarget);
                matcher.componentNames = BattleComponentsLookup.componentNames;
                _matcherMoveTarget = matcher;
            }

            return _matcherMoveTarget;
        }
    }
}