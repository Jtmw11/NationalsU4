
singleton TSShapeConstructor(Juniper_ancient_01Dae)
{
   baseShape = "./Juniper_ancient_01.dae";
   loadLights = "0";
};

function Juniper_ancient_01Dae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "128", "1", "0");
}
