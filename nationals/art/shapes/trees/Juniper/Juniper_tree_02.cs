
singleton TSShapeConstructor(Juniper_tree_02Dae)
{
   baseShape = "./Juniper_tree_02.dae";
   loadLights = "0";
};

function Juniper_tree_02Dae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
