
singleton TSShapeConstructor(Holm_oak_bush_hugeDae)
{
   baseShape = "./holm_oak_bush_huge.dae";
   loadLights = "0";
};

function Holm_oak_bush_hugeDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
