
singleton TSShapeConstructor(Holm_oakDae)
{
   baseShape = "./holm_oak.dae";
};

function Holm_oakDae::onLoad(%this)
{
   %this.addImposter("25", "8", "0", "0", "128", "1", "0");
}
