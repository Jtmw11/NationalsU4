
singleton TSShapeConstructor(Holm_oak_2Dae)
{
   baseShape = "./holm_oak_2.dae";
};

function Holm_oak_2Dae::onLoad(%this)
{
   %this.addImposter("25", "8", "0", "0", "256", "1", "0");
}
