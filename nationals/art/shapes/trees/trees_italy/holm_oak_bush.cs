
singleton TSShapeConstructor(Holm_oak_bushDae)
{
   baseShape = "./holm_oak_bush.dae";
};

function Holm_oak_bushDae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "0", "0");
}
